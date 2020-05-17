using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using model;
using System.Security.AccessControl;

namespace project_model
{
    /**
     * This class allows to do the right processing and estimating of the recolected data of interest.
     */
    public class Analyzer
    {
        private Zone zone;

        public const String path = "..\\..\\..\\..\\code\\data\\Zones\\ZONE.csv";
        public const double zvalue = 1.64;

        private List<String> deparments = new List<String> { "ANTIOQUIA","BOYACÁ","CESAR","CHOCÓ","CUNDINAMARCA","LA_GUAJIRA","MAGDALENA","META",
                                                             "SANTANDER", "TOLIMA", "VALLE_DEL_CAUCA"};
        /**
         * Analyzer constructor
         */
        public Analyzer()
        {
            zone = new Zone();
            if (!Directory.Exists(path))
            {
                init();
            }
        }

        private void init() {
            
            foreach (String department in deparments)
            {                                
                createArea(department, EstimateLiquidPrecipitation(LoadRequest(department, User.LiquidPrecipitation))[0],
                EstimateRelativeHumidity(LoadRequest(department, User.RelativeHumidity))[0], 
                EstimateTemperature(LoadRequest(department, User.Temperature))[0],
                EstimateWindSpeed(LoadRequest(department, User.WindSpeed))[0]);
            }

            using (System.IO.StreamWriter file = new System.IO.StreamWriter(path)) 
            {
                foreach (Area area in zone.GetAreas) 
                {
                    file.WriteLine(area.toString());

                    /**+EstimateLiquidPrecipitation(LoadRequest(area.GetName, User.LiquidPrecipitation))[1] +
                    ";" + EstimateRelativeHumidity(LoadRequest(area.GetName, User.RelativeHumidity))[1] + ";" +
                    EstimateTemperature(LoadRequest(area.GetName, User.Temperature))[1] + ";" +
                    EstimateWindSpeed(LoadRequest(area.GetName, User.WindSpeed))[1]*/
                }
            }                              
        }

        /**
         * This method loads the divided individual reports in order to get ready to do an estimation from them.
         */
        public List<Data> LoadRequest(String namevalue, String var)
        {            
            String general = "..\\..\\..\\..\\code\\data\\" + namevalue + "\\" + var;
            
            List<Data> partialdata = new List<Data>();

            if (Directory.Exists(general))
            {
                int i = 0;
                while (i < 7)
                {
                    
                    String year = "201" + (i + 1);
                    String path = "..\\..\\..\\..\\code\\data\\" + namevalue + "\\" + var + "\\" + year + "\\" + var + ".csv";
                                        
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

                            partialdata.Add(data);
                            
                            line = file.ReadLine();
                        }                                                
                    }                    
                    i++;
                }                
            }
            return partialdata;
        }

        /**
         * This method estimates the liquid precipitation of an Area
         */
        public double[] EstimateLiquidPrecipitation(List<Data> liquidprecipitationdata)
        {
            double[] estimator = new double[2];            
            List<double> observations = new List<double>();

            if (liquidprecipitationdata.Any()) {
                double sumofvalues = 0;
                int totalvalues = 0;

                foreach (Data data in liquidprecipitationdata)
                {
                    sumofvalues += double.Parse(data.GetConcentration, System.Globalization.CultureInfo.InvariantCulture);
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
        public double[] EstimateRelativeHumidity(List<Data> relativehumiditydata)
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
        public double[] EstimateTemperature(List<Data> temperaturedata)
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
        public double[] EstimateWindSpeed(List<Data> windspeeddata)
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
            if (observations.Any())
            {
                double average = observations.Average();
                double sumOfSquaresOfDifferences = observations.Select(val => (val - average) * (val - average)).Sum();
                sd = Math.Sqrt(sumOfSquaresOfDifferences / observations.Count());
            }
            return sd;
        }

        /**
         * This method calculates the confidence interval for the estimated value of a variable
         */
        private double CalculateConfidenceInterval(double estimator,int totalvalues, double standarddeviation, double zvalue)         
        {            
            double calculated = zvalue * (standarddeviation / (Math.Sqrt(totalvalues)));            

            return calculated;
        }

        /**
        * This method creates the Area Requested in order to add it to the collected areas
        */
        public void createArea(String name, double estimatedliquidprecipitation, double estimatedrelativehumidity, double estimatedtemperature,
            double estimatedwindspeed) 
        {
            Area area = new Area(name,estimatedliquidprecipitation, estimatedrelativehumidity, estimatedtemperature, estimatedwindspeed);
            zone.AddArea(area);
        }

        public Zone GetZone { get => zone; }
    }
}