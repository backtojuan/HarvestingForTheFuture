using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;


namespace project_model
{
    /**
     * This class works like a connection between areas and farmings
     */
    public class Association
    {

        private Zone zone;

        private List<Farming> farmings;
        private List<Relation> relations;

        /**
         * Association constructor
         */
        public Association(String area)
        {
            zone = new Zone();
            farmings = new List<Farming>();
            loadFarming(Farming.path);
            loadZone(area);
            relations = new List<Relation>();
        }

        /**
         * This method deserialize the object saved on previous moments and recover it to be used
         */
        private void loadZone(String department)
        {
            IFormatter formatter = new BinaryFormatter();
            Stream stream = new FileStream(Analyzer.path + department, FileMode.Open,FileAccess.Read);
            Area area = (Area)formatter.Deserialize(stream);
            zone.AddArea(area);
        }

        /**
         * This method loads the farmings saved on a textfile
         */
        private void loadFarming(String path)
        {
            using (System.IO.StreamReader file = new System.IO.StreamReader(path))
            {
                String line = file.ReadLine();
                line = file.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    String[] infor = line.Split(';');

                    String Name = infor[0];
                    double LiquidPrecipitation = 0;
                    double WindSpeed = 0;
                    double MinTemperature = 0;
                    double MaxTemperature = 0;
                    double[] RelativeHumidity = new double[2];

                    if (!infor[1].Equals(Farming.noregister))
                    {
                        LiquidPrecipitation = Convert.ToDouble(infor[1]);
                    }

                    if (!infor[2].Equals(Farming.noregister))
                    {
                        WindSpeed = Convert.ToDouble(infor[2]);
                    }

                    if (!infor[3].Equals(Farming.noregister))
                    {
                        MinTemperature = Convert.ToDouble(infor[3]);
                    }

                    if (!infor[4].Equals(Farming.noregister))
                    {
                        MaxTemperature = Convert.ToDouble(infor[4]);
                    }


                    if (!infor[5].Equals(Farming.noregister))
                    {
                        String[] partialinfor = infor[5].Split('-');
                        RelativeHumidity[0] = Convert.ToDouble(partialinfor[0]);
                        RelativeHumidity[1] = Convert.ToDouble(partialinfor[1]);
                    }

                    Farming farming = new Farming(Name, LiquidPrecipitation, RelativeHumidity, WindSpeed, MinTemperature, MaxTemperature);
                    farmings.Add(farming);

                    line = file.ReadLine();
                }
            }
        }

        /**
         * This method compares an area with each farming of interest in order to determine wether it's compatible to be harvested or not
         */
        public void Compare()
        {
            foreach (Area area in zone.GetAreas)
            {
                List<Relation> relationS = new List<Relation>();
                int i = 0;
                while (i < farmings.Count)
                {
                    double LiquidPrecipitationPercent = Match(farmings.ElementAt(i).GetLiquidPrecipitation,
                                                        ((area.GetLiquidPrecipitation)*1000),
                                                        ((area.GetLiquidPrecipitation - area.GetLiquidPrecipitationConfidence)*1000),
                                                        ((area.GetLiquidPrecipitation + area.GetLiquidPrecipitationConfidence))*1000);

                    
                    double RelativeHumidityPercent = Match(farmings.ElementAt(i).GetRelativeHumidity[0],
                                                        farmings.ElementAt(i).GetRelativeHumidity[1],
                                                        area.GetRelativeHumidity,
                                                        (area.GetRelativeHumidity - area.GetRelativeHumidityConfidence),
                                                        (area.GetRelativeHumidity + area.GetRelativeHumidityConfidence));
                                        
                    double TemperaturePercent = Match(farmings.ElementAt(i).GetMinTemperature,
                                                    farmings.ElementAt(i).GetMaxTemperature,
                                                    area.GetTemperature,
                                                    (area.GetTemperature - area.GetTemperatureConfidence),
                                                    (area.GetTemperature + area.GetTemperatureConfidence));
                    
                    double WindSpeedPercent = Match(farmings.ElementAt(i).GetWindSpeed,
                                                        area.GetWindSpeed,
                                                        (area.GetWindSpeed - area.GetWindspeedConfidence),
                                                        (area.GetWindSpeed + area.GetWindspeedConfidence));

                    double compatibility = (LiquidPrecipitationPercent + RelativeHumidityPercent + TemperaturePercent + WindSpeedPercent) / 6;

                    Relation relation = new Relation(compatibility, LiquidPrecipitationPercent, RelativeHumidityPercent, TemperaturePercent,
                        WindSpeedPercent, area, farmings.ElementAt(i));

                   relations.Add(relation);
                    i++;
                }
            }

        }

        /**
         * This method measures the compatibility percent of the expected value and the current value of the variable of interest.
         */
        public double Match(double expected, double current, double inf, double sup)
        {
            double compatible = 0;

            if (inf < expected && expected < sup)
            {
                compatible = current / expected;
            }
            return compatible;
        }

        /**
        * This method measures the compatibility percent of the expected value and the current value of the variable of interest.
        */
        public double Match(double expectedinf, double expectedsup, double current, double inf, double sup) 
        {
            double compatible = 0;

            if ((expectedinf < inf && inf < expectedsup)) 
            {
                compatible = current / expectedinf;
            }
			else if((expectedinf < sup && sup < expectedsup))
			{
				compatible = current / expectedsup;
			}
            return compatible;
        }

        /**
         * This Gets and Sets important values in this class
         */
        public Zone GetZone { get => zone; set => zone = value; }
        public List<Farming> GetFarmings { get => farmings; set => farmings = value; }
        public List<Relation> GetRelations { get => relations; set => relations = value; }
    }
}