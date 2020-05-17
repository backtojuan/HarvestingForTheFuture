using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

using model;

namespace project_model
{
    /**
     * This class allows to do the right processing and estimating of the recolected data of interest.
     */
    class Analyzer
    {
        private Zone zone;

        /**
         * This works like a dictionary where evey list inside of the general list contains another list for each department of the data 
         * recolected for an specified year (since 2011 until 2017) and so on.
         */
        private List<List<List<List<Data>>>> data;

        private const double zvalue = 1.64;

        /**
         * Analyzer constructor
         */
        public Analyzer()
        {
            init();
            zone = new Zone();
        }

        private void init() {
            for (int i = 0; i < data.Count; i++)
            {
                data.Add(new List<List<List<Data>>>());
            }

            data.ElementAt(0).ElementAt(0).Add(LoadRequest("ANTIOQUIA",User.LiquidPrecipitation));
            data.ElementAt(0).ElementAt(1).Add(LoadRequest("ANTIOQUIA", User.RelativeHumidity));
            data.ElementAt(0).ElementAt(2).Add(LoadRequest("ANTIOQUIA", User.Temperature));
            data.ElementAt(0).ElementAt(3).Add(LoadRequest("ANTIOQUIA", User.WindSpeed));

            data.ElementAt(1).ElementAt(0).Add(LoadRequest("BOYACÁ", User.LiquidPrecipitation));
            data.ElementAt(1).ElementAt(1).Add(LoadRequest("BOYACÁ", User.RelativeHumidity));
            data.ElementAt(1).ElementAt(2).Add(LoadRequest("BOYACÁ", User.Temperature));
            data.ElementAt(1).ElementAt(3).Add(LoadRequest("BOYACÁ", User.WindSpeed));

            data.ElementAt(2).ElementAt(0).Add(LoadRequest("CESAR", User.LiquidPrecipitation));
            data.ElementAt(2).ElementAt(1).Add(LoadRequest("CESAR", User.RelativeHumidity));
            data.ElementAt(2).ElementAt(2).Add(LoadRequest("CESAR", User.Temperature));
            data.ElementAt(2).ElementAt(3).Add(LoadRequest("CESAR", User.WindSpeed));

            data.ElementAt(3).ElementAt(0).Add(LoadRequest("CHOCÓ", User.LiquidPrecipitation));
            data.ElementAt(3).ElementAt(1).Add(LoadRequest("CHOCÓ", User.RelativeHumidity));
            data.ElementAt(3).ElementAt(2).Add(LoadRequest("CHOCÓ", User.Temperature));
            data.ElementAt(3).ElementAt(3).Add(LoadRequest("CHOCÓ", User.WindSpeed));

            data.ElementAt(4).ElementAt(0).Add(LoadRequest("CUNDINAMARCA", User.LiquidPrecipitation));
            data.ElementAt(4).ElementAt(1).Add(LoadRequest("CUNDINAMARCA", User.RelativeHumidity));
            data.ElementAt(4).ElementAt(2).Add(LoadRequest("CUNDINAMARCA", User.Temperature));
            data.ElementAt(4).ElementAt(3).Add(LoadRequest("CUNDINAMARCA", User.WindSpeed));

            data.ElementAt(5).ElementAt(0).Add(LoadRequest("LA_GUAJIRA", User.LiquidPrecipitation));
            data.ElementAt(5).ElementAt(1).Add(LoadRequest("LA_GUAJIRA", User.RelativeHumidity));
            data.ElementAt(5).ElementAt(2).Add(LoadRequest("LA_GUAJIRA", User.Temperature));
            data.ElementAt(5).ElementAt(3).Add(LoadRequest("LA_GUAJIRA", User.WindSpeed));

            data.ElementAt(6).ElementAt(0).Add(LoadRequest("MAGDALENA", User.LiquidPrecipitation));
            data.ElementAt(6).ElementAt(1).Add(LoadRequest("MAGDALENA", User.RelativeHumidity));
            data.ElementAt(6).ElementAt(2).Add(LoadRequest("MAGDALENA", User.Temperature));
            data.ElementAt(6).ElementAt(3).Add(LoadRequest("MAGDALENA", User.WindSpeed));

            data.ElementAt(7).ElementAt(0).Add(LoadRequest("META", User.LiquidPrecipitation));
            data.ElementAt(7).ElementAt(1).Add(LoadRequest("META", User.RelativeHumidity));
            data.ElementAt(7).ElementAt(2).Add(LoadRequest("META", User.Temperature));
            data.ElementAt(7).ElementAt(3).Add(LoadRequest("META", User.WindSpeed));

            data.ElementAt(8).ElementAt(0).Add(LoadRequest("SANTANDER", User.LiquidPrecipitation));
            data.ElementAt(8).ElementAt(1).Add(LoadRequest("SANTANDER", User.RelativeHumidity));
            data.ElementAt(8).ElementAt(2).Add(LoadRequest("SANTANDER", User.Temperature));
            data.ElementAt(8).ElementAt(3).Add(LoadRequest("SANTANDER", User.WindSpeed));

            data.ElementAt(9).ElementAt(0).Add(LoadRequest("TOLIMA", User.LiquidPrecipitation));
            data.ElementAt(9).ElementAt(1).Add(LoadRequest("TOLIMA", User.RelativeHumidity));
            data.ElementAt(9).ElementAt(2).Add(LoadRequest("TOLIMA", User.Temperature));
            data.ElementAt(9).ElementAt(3).Add(LoadRequest("TOLIMA", User.WindSpeed));

            data.ElementAt(10).ElementAt(0).Add(LoadRequest("VALLE_DEL_CAUCA", User.LiquidPrecipitation));
            data.ElementAt(10).ElementAt(1).Add(LoadRequest("VALLE_DEL_CAUCA", User.RelativeHumidity));
            data.ElementAt(10).ElementAt(2).Add(LoadRequest("VALLE_DEL_CAUCA", User.Temperature));
            data.ElementAt(10).ElementAt(3).Add(LoadRequest("VALLE_DEL_CAUCA", User.WindSpeed));

            createArea("ANTIOQUIA", 0);
            createArea("BOYACÁ", 1);
            createArea("CESAR", 2);
            createArea("CHOCÓ", 3);
            createArea("CUNDINAMARCA", 4);
            createArea("LA_GUAJIRA", 5);
            createArea("MAGDALENA", 6);
            createArea("META", 7);
            createArea("SANTANDER", 8);
            createArea("TOLIMA", 9);
            createArea("VALLE_DEL_CAUCA", 10);          
        }

        /**
         * This method loads the divided individual reports in order to get ready to do an estimation from them.
         */
        public List<Data> LoadRequest(String namevalue, String var)
        {
            List<Data> dataofyears = new List<Data>();

            String general = "..\\..\\..\\..\\code\\Data\\" + namevalue + "\\" + var;
            List<Data> partialdata = new List<Data>();

            if (Directory.Exists(general))
            {
                int i = 0;
                while (i < 7)
                {
                    
                    String year = "201" + (i + 1);
                    String path = "..\\..\\..\\..\\code\\Data\\" + namevalue + "\\" + var + "\\" + year + "\\" + var + ".csv";
                                        
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
            return dataofyears;
        }

        /**
         * This method estimates the liquid precipitation of an Area
         */
        public double EstimateLiquidPrecipitation(int department)
        {
            double estimator = 0;
            List<Data> liquidprecipitationdata = data.ElementAt(department).ElementAt(0).ElementAt(0);
            List<double> observations = new List<double>();

            if (!liquidprecipitationdata.Any()) {
                double sumofvalues = 0;
                int totalvalues = 0;

                foreach (Data data in liquidprecipitationdata) 
                {
                    sumofvalues += Convert.ToInt32(data.GetConcentration);
                    totalvalues ++;                    
                }                
                estimator = sumofvalues / totalvalues;
            }            
            return estimator;            
        }

        /**
        * This method estimates the relative humedity of an Area
        */
        public double EstimateRelativeHumidity(int department)
        {
            double estimator = 0;
            List<Data> relativehumiditydata = data.ElementAt(department).ElementAt(1).ElementAt(0);
            List<double> observations = new List<double>();

            if (!relativehumiditydata.Any())
            {
                double sumofvalues = 0;
                int totalvalues = 0;

                foreach (Data data in relativehumiditydata)
                {
                    sumofvalues += Convert.ToInt32(data.GetConcentration);
                    totalvalues++;
                }
                estimator = sumofvalues / totalvalues;
            }

            return estimator;
        }

        /**
        * This method estimates the temperature of an Area
        */
        public double EstimateTemperature(int department)
        {
            double estimator = 0;
            List<Data> temperaturedata = data.ElementAt(department).ElementAt(2).ElementAt(0);
            List<double> observations = new List<double>();

            if (!temperaturedata.Any())
            {
                double sumofvalues = 0;
                int totalvalues = 0;

                foreach (Data data in temperaturedata)
                {
                    sumofvalues += Convert.ToInt32(data.GetConcentration);
                    totalvalues++;
                }
                estimator = sumofvalues / totalvalues;
            }
            return estimator;
        }

        /**
        * This method estimates the windspeed of an Area
        */
        public double EstimateWindSpeed(int department)
        {
            double estimator = 0;
            List<Data> windspeeddata = data.ElementAt(department).ElementAt(3).ElementAt(0);
            List<double> observations = new List<double>();

            if (!windspeeddata.Any())
            {
                double sumofvalues = 0;
                int totalvalues = 0;

                foreach (Data data in windspeeddata)
                {
                    sumofvalues += Convert.ToInt32(data.GetConcentration);
                    totalvalues++;
                }
                estimator = sumofvalues / totalvalues;
            }
            return estimator;
        }

        /**
         * this method calculates the standard deviation of a given set of values
         */
        private double CalculateStandardDeviation(List<double> observations)
        {
            double average = observations.Average();
            double sumOfSquaresOfDifferences = observations.Select(val => (val - average) * (val - average)).Sum();
            double sd = Math.Sqrt(sumOfSquaresOfDifferences / observations.Count());

            return sd;
        }

        /**
         * This method calculates the confidence interval for the estimated value of a variable
         */
        private double[] CalculateConfidenceInterval(double estimator,int totalvalues, double standarddeviation, double zvalue)         
        {
            double[] confidenceinterval = new double[2];
            double calculated = zvalue * (standarddeviation / (Math.Sqrt(totalvalues)));

            confidenceinterval[0] = estimator - calculated;
            confidenceinterval[1] = estimator + calculated;

            return confidenceinterval;
        }

        /**
        * This method creates the Area Requested in order to add it to the collected areas
        */
        public void createArea(string name, int department) 
        {
            double estimatedLiquidPrecipitation = EstimateLiquidPrecipitation(department);
            double estimatedRelativeHumidity = EstimateRelativeHumidity(department);
            double estimatedTemperature = EstimateTemperature(department);
            double estimatedWindSpeed = EstimateWindSpeed(department);

            Area area = new Area(name,estimatedLiquidPrecipitation, estimatedRelativeHumidity, estimatedTemperature, estimatedWindSpeed);

            zone.AddArea(area);
        }
    }
}