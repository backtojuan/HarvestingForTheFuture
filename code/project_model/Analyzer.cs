using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using model;
using System.Security.AccessControl;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Runtime.ConstrainedExecution;

namespace project_model
{
    /**
     * This class allows to do the right processing and estimating of the recolected data of interest.
     */
    public class Analyzer
    {
        private Zone zone;

        public const String path = "..\\..\\..\\..\\code\\Data\\Zones\\";

        private List<String> departments = new List<String> { "ANTIOQUIA","BOYACÁ","CESAR","CHOCÓ","CUNDINAMARCA","LA_GUAJIRA","MAGDALENA","META",
                                                             "SANTANDER", "TOLIMA", "VALLE_DEL_CAUCA"};

        private List<String> variables = new List<String> { User.LiquidPrecipitation,User.RelativeHumidity,User.Temperature,User.WindSpeed};

        public const double zvalue = 2.33;

        /**
         * Analyzer constructor
         */
        public Analyzer()
        {
            zone = new Zone();
            Load();            
            Save();
        }
       
        /**
         * This method loads the divided individual reports in order to get ready to do an estimation from them, calculates the estimation of each year
         * for each variable.
         */
        private void Load()
        {
            foreach (String department in departments)
            {

                String lat = "";
                String longi = "";

                List<Data> totaldata = new List<Data>();

                double[] liquidrecipitation = new double[2] { 0 , 0 };
                double[] relativehumidity = new double[2] { 0 , 0 };
                double[] temperature = new double[2] { 0 , 0 };
                double[] windspeed = new double[2] { 0, 0 };

                List<double> liquidprecipitationestimations = new List<double>();
                List<double> relativehumidityestimations = new List<double>();
                List<double> temperaturestimations = new List<double>();
                List<double> windspeedestimations = new List<double>();

                foreach (String var in variables)
                {                    
                    String general = "..\\..\\..\\..\\code\\Data\\" + department + "\\" + var;                    
                    List<double> partialdata = new List<double>();
                    List<double> estimationsofeachyear = new List<double>();

                    if (Directory.Exists(general))
                    {
                        int i = 0;
                        while (i < 7)
                        {

                            String year = "201" + (i + 1);
                            String path = "..\\..\\..\\..\\code\\Data\\" + department + "\\" + var + "\\" + year + "\\" + var + ".csv";

                            using (System.IO.StreamReader file = new System.IO.StreamReader(path))
                            {
                                String line = file.ReadLine();

                                while (line != null)
                                {
                                    String[] infor = line.Split(';');

                                    String[] partialdate = infor[0].Split(' ');

                                    String date = partialdate[0];
                                    String enviromentalauthority = infor[1];
                                    String stationname = infor[2];
                                    String technology = infor[3];
                                    String latitude = infor[4];
                                    String longitude = infor[5];
                                    String deparmentcode = infor[6];
                                    String deparmentname = infor[7];
                                    String municipalitycode = infor[8];
                                    String municipalityname = infor[9];
                                    String typeofstation = infor[10];
                                    String exhibitiontime = infor[11];
                                    String variable = infor[12];
                                    String units = infor[13];
                                    String concentration = infor[14];

                                    Data data = new Data(date, enviromentalauthority, stationname, technology, latitude, longitude, deparmentcode, deparmentname, municipalitycode,
                                        municipalityname, typeofstation, exhibitiontime, variable, units, concentration);

                                    lat = latitude;
                                    longi = longitude;

                                    partialdata.Add(Convert.ToDouble(data.GetConcentration, System.Globalization.CultureInfo.InvariantCulture));
                                    totaldata.Add(data);

                                    line = file.ReadLine();
                                }
                            }
                            if (partialdata.Any())
                            {
                                estimationsofeachyear.Add(partialdata.Average());
                                partialdata.Clear();
                            }
                            else
                            {
                                estimationsofeachyear.Add(0);
                            }
                            i++;
                        }
                    }
                    if (var.Equals(User.LiquidPrecipitation))
                    {
                        if (estimationsofeachyear.Any())
                        {
                            liquidrecipitation = EstimateLiquidPrecipitation(totaldata);
                            liquidprecipitationestimations = estimationsofeachyear;
                            totaldata.Clear();
                        }
                    }
                    else if (var.Equals(User.RelativeHumidity))
                    {
                        if (estimationsofeachyear.Any())
                        {
                            relativehumidity = EstimateRelativeHumidity(totaldata);
                            relativehumidityestimations = estimationsofeachyear;
                            totaldata.Clear();
                        }
                    }
                    else if (var.Equals(User.Temperature))
                    {
                        if (estimationsofeachyear.Any())
                        {
                            temperature = EstimateTemperature(totaldata);
                            temperaturestimations = estimationsofeachyear;
                            totaldata.Clear();
                        }    
                    }
                    else if (var.Equals(User.WindSpeed)) 
                    {
                        if (estimationsofeachyear.Any())
                        {
                            windspeed = EstimateWindSpeed(totaldata);
                            windspeedestimations = estimationsofeachyear;
                            totaldata.Clear();
                        }                        
                    }
                }
                createArea(department, lat, longi, liquidrecipitation[0],
                    relativehumidity[0], temperature[0], windspeed[0], liquidrecipitation[1], relativehumidity[1], temperature[1],
                    windspeed[1], liquidprecipitationestimations, relativehumidityestimations, temperaturestimations, windspeedestimations);
            }            
        }

        /**
         * This method serializes the areas loaded in order to be used for later.
         */
        private void Save()
        {
            foreach (Area area in zone.GetAreas)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream mySavior = new FileStream(path + area.GetName, FileMode.Create, FileAccess.Write);
                formatter.Serialize(mySavior, area);

                mySavior.Close();
            }
        }

        /**
         * This method estimates the liquid precipitation of an Area
         */
        private double[] EstimateLiquidPrecipitation(List<Data> liquidprecipitationdata)
        {
            double[] estimator = new double[2];
            List<double> observations = new List<double>();

            if (liquidprecipitationdata.Any())
            {
                double sumofvalues = 0;
                int totalvalues = 0;

                foreach (Data data in liquidprecipitationdata)
                {
                    sumofvalues += double.Parse(data.GetConcentration, System.Globalization.CultureInfo.InvariantCulture);
                    observations.Add(double.Parse(data.GetConcentration, System.Globalization.CultureInfo.InvariantCulture));
                    totalvalues++;
                }
                estimator[0] = sumofvalues / totalvalues;
                estimator[1] = CalculateConfidenceInterval(estimator[0], totalvalues, CalculateStandardDeviation(observations), zvalue);
            }
            return estimator;
        }

        /**
        * This method estimates the relative humedity of an Area
        */
        private double[] EstimateRelativeHumidity(List<Data> relativehumiditydata)
        {
            double[] estimator = new double[2];
            List<double> observations = new List<double>();

            if (relativehumiditydata.Any())
            {
                double sumofvalues = 0;
                int totalvalues = 0;

                foreach (Data data in relativehumiditydata)
                {
                    sumofvalues += double.Parse(data.GetConcentration, System.Globalization.CultureInfo.InvariantCulture);
                    observations.Add(double.Parse(data.GetConcentration, System.Globalization.CultureInfo.InvariantCulture));
                    totalvalues++;
                }
                estimator[0] = sumofvalues / totalvalues;
                estimator[1] = CalculateConfidenceInterval(estimator[0], totalvalues, CalculateStandardDeviation(observations), zvalue);
            }

            return estimator;
        }

        /**
        * This method estimates the temperature of an Area
        */
        private double[] EstimateTemperature(List<Data> temperaturedata)
        {
            double[] estimator = new double[2];
            List<double> observations = new List<double>();

            if (temperaturedata.Any())
            {
                double sumofvalues = 0;
                int totalvalues = 0;

                foreach (Data data in temperaturedata)
                {
                    sumofvalues += double.Parse(data.GetConcentration, System.Globalization.CultureInfo.InvariantCulture);
                    observations.Add(double.Parse(data.GetConcentration, System.Globalization.CultureInfo.InvariantCulture));
                    totalvalues++;
                }
                estimator[0] = sumofvalues / totalvalues;
                estimator[1] = CalculateConfidenceInterval(estimator[0], totalvalues, CalculateStandardDeviation(observations), zvalue);
            }
            return estimator;
        }

        /**
        * This method estimates the windspeed of an Area
        */
        private double[] EstimateWindSpeed(List<Data> windspeeddata)
        {
            double[] estimator = new double[2];
            List<double> observations = new List<double>();

            if (windspeeddata.Any())
            {
                double sumofvalues = 0;
                int totalvalues = 0;

                foreach (Data data in windspeeddata)
                {
                    sumofvalues += double.Parse(data.GetConcentration, System.Globalization.CultureInfo.InvariantCulture);
                    observations.Add(double.Parse(data.GetConcentration, System.Globalization.CultureInfo.InvariantCulture));
                    totalvalues++;
                }
                estimator[0] = sumofvalues / totalvalues;
                estimator[1] = CalculateConfidenceInterval(estimator[0], totalvalues, CalculateStandardDeviation(observations), zvalue);
            }
            return estimator;
        }

        /**
         * this method calculates the standard deviation of a given set of values
         */
        private double CalculateStandardDeviation(List<double> observations)
        {
            double sd = 0;
            double average = 0;
            double sumOfSquaresOfDifferences = 0;
            if (observations.Any())
            {
                average = observations.Average();
                sumOfSquaresOfDifferences = observations.Select(val => (val - average) * (val - average)).Sum();
                sd = Math.Sqrt(sumOfSquaresOfDifferences / observations.Count());
            }
            return sd;
        }

        /**
         * This method calculates the confidence interval for the estimated value of a variable
         */
        private double CalculateConfidenceInterval(double estimator, int totalvalues, double standarddeviation, double zvalue)
        {
            double calculated = zvalue * (standarddeviation / (Math.Sqrt(totalvalues)));

            return calculated;
        }

        /**
        * This method creates the Area Requested in order to add it to the collected areas
        */
        private void createArea(String name, String latitude, String longitude,double estimatedliquidprecipitation, double estimatedrelativehumidity, 
            double estimatedtemperature, double estimatedwindspeed, double liquidprecipitacionconfidence, double relativehumidityconfidence, 
            double temperaturaconfidence,double windspeedconfidence, List<double> liquidprecipitationestimations, List<double> relativehumidityestimations,
            List<double> temperatureestimitations, List<double> windspeedestimations)
        {
            Area area = new Area(name,latitude,longitude,liquidprecipitationestimations,relativehumidityestimations, temperatureestimitations,
                windspeedestimations,estimatedliquidprecipitation, estimatedrelativehumidity, estimatedtemperature, estimatedwindspeed,
                liquidprecipitacionconfidence, relativehumidityconfidence, temperaturaconfidence, windspeedconfidence);

            zone.AddArea(area);
        }

        /**
         * This Gets and Sets zone relation
         */
        public Zone GetZone { get => zone; set => zone = value; }
    }
}