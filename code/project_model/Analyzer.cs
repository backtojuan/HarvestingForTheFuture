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
         * This works like a dictionary where evey list inside of the general list contains the data recolected for an specified year (since 2011 until 2017) and so on.
         */
        private List<List<Data>> LiquidPrecipitationData;
        private List<List<Data>> RelativeHumidityData;
        private List<List<Data>> TemperatureData;
        private List<List<Data>> WindSpeedData;
        
        public Analyzer()
        {
            LiquidPrecipitationData = new List<List<Data>>();
            RelativeHumidityData = new List<List<Data>>();
            TemperatureData = new List<List<Data>>();
            WindSpeedData = new List<List<Data>>();

            zone = new Zone();            
        }

        /**
         * This method loads the divided individual reports in order to get ready to do an estimation from them.
         */
        public void LoadRequest(String namevalue, String var)
        {
            
            String general = "..\\..\\..\\..\\code\\Data\\" + namevalue + "\\" + var;
            
            if (Directory.Exists(general)) 
            {
                int i = 0;
                while (i < 7)
                {
                    String text = "";

                    String year = "201" + (i + 1);
                    String path = "..\\..\\..\\..\\code\\Data\\" + namevalue + "\\" + var + "\\" + year + "\\" + var + ".csv";
                    List<Data> partialdata = new List<Data>();

                    text += year + "\n";
                    text += path + "\n";

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
                            text += data.toString() + "\n";
                            line = file.ReadLine();
                        }
                        if (var.Equals(User.LP))
                        {
                            LiquidPrecipitationData.Add(partialdata);
                        }                        
                        else if (var.Equals(User.RH))
                        {
                            RelativeHumidityData.Add(partialdata);
                        }
                        else if (var.Equals(User.TMP))
                        {
                            TemperatureData.Add(partialdata);
                        }
                        else if (var.Equals(User.WS)) 
                        {
                            WindSpeedData.Add(partialdata);
                        }
                        i++;
                    }
                }
            }            
        }
            
        /**
         * This method estimates the liquid precipitation of an Area
         */
        public int EstimateLiquidPrecipitation() 
        {
            int estimator = 0;

            if (!LiquidPrecipitationData.Any())
            {                
                int sumofvalues = 0;
                int totalvalues = 0;

                int i = 0;
                while (i < 7)
                {
                    totalvalues += LiquidPrecipitationData.ElementAt(i).Count();

                    foreach (Data data in LiquidPrecipitationData.ElementAt(i))
                    {
                        sumofvalues += Convert.ToInt32(data.GetConcentration);
                    }
                    i++;
                }
                estimator = sumofvalues / totalvalues;                
            }

            return estimator;
        }

        /**
        * This method estimates the relative humedity of an Area
        */
        public double EstimateRH() 
        {
            double estimator = 0;

            if (!RelativeHumidityData.Any())
            {
                double sumofvalues = 0;
                int totalvalues = 0;

                int i = 0;
                while (i < 7)
                {
                    totalvalues += RelativeHumidityData.ElementAt(i).Count();

                    foreach (Data data in RelativeHumidityData.ElementAt(i))
                    {
                        sumofvalues += Convert.ToDouble(data.GetConcentration);
                    }
                    i++;
                }

                estimator = sumofvalues / totalvalues;
            }

            return estimator;
        }

        /**
        * This method estimates the temperature of an Area
        */
        public double EstimateTemperature()
        {
            double estimator = 0;

            if (!TemperatureData.Any())
            {
                double sumofvalues = 0;
                int totalvalues = 0;

                int i = 0;
                while (i < 7)
                {
                    totalvalues += TemperatureData.ElementAt(i).Count();

                    foreach (Data data in TemperatureData.ElementAt(i))
                    {
                        sumofvalues += Convert.ToDouble(data.GetConcentration);
                    }
                    i++;
                }

                estimator = sumofvalues / totalvalues;
            }
            
            return estimator;
        }

        /**
        * This method estimates the windspeed of an Area
        */
        public double EstimateWindSpeed()
        {            
            double estimator = 0;

            if (!WindSpeedData.Any())
            {
                double sumofvalues = 0;
                int totalvalues = 0;

                int i = 0;
                while (i < 7)
                {
                    totalvalues += WindSpeedData.ElementAt(i).Count();

                    foreach (Data data in WindSpeedData.ElementAt(i))
                    {
                        sumofvalues += Convert.ToDouble(data.GetConcentration);
                    }
                    i++;
                }

                estimator = sumofvalues / totalvalues;
            }

            return estimator;
        }

        /**
         * This method creates the Area Requested in order to add it to the collected areas
         */
        public void createArea() 
        {
            int estimatedLiquidPrecipitation = EstimateLiquidPrecipitation();
            double estimatedRelativeHumidity = EstimateRH();
            double estimatedTemperature = EstimateTemperature();
            double estimatedWindSpeed = EstimateWindSpeed();

            Area area = new Area(estimatedLiquidPrecipitation, estimatedRelativeHumidity, estimatedTemperature, estimatedWindSpeed);

            zone.AddArea(area);
        }
    }
}