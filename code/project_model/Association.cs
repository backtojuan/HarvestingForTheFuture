using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;


namespace project_model
{
    public class Association
    {

        private Zone zone;

        private List<Farming> farmings;
        private List<Relation> relations;

        public Association(String area)
        {
            farmings = new List<Farming>();
            loadFarming(Farming.path);
            loadZone(area);
            relations = new List<Relation>();
        }

        private void loadZone(String department)
        {
            zone = new Zone();
            using (System.IO.StreamReader file = new System.IO.StreamReader(Analyzer.path + department + ".csv"))
            {
                String line = file.ReadLine();

                while (line != null)
                {
                    String[] infor = line.Split(' ');

                    String name = infor[0];
                    double estimatedliquidprecipitation = Convert.ToDouble(infor[1]);
                    double estimatedrelativehumidity = Convert.ToDouble(infor[2]);
                    double estimatedtemperature = Convert.ToDouble(infor[3]);
                    double estimatedwindspeed = Convert.ToDouble(infor[4]);
                    double liquidprecipitationconfidence = Convert.ToDouble(infor[5]);
                    double relativehumidityconfidence = Convert.ToDouble(infor[6]);
                    double temperatureconfidence = Convert.ToDouble(infor[7]);
                    double windspeedconfidence = Convert.ToDouble(infor[8]);

                    Area area = new Area(name, estimatedliquidprecipitation, estimatedrelativehumidity, estimatedtemperature, estimatedwindspeed,
                        liquidprecipitationconfidence, relativehumidityconfidence, temperatureconfidence, windspeedconfidence);
                    zone.AddArea(area);
                    line = file.ReadLine();
                }
            }
        }

        private void loadFarming(String path)
        {
            using (System.IO.StreamReader file = new System.IO.StreamReader(path))
            {
                String line = file.ReadLine();
                line = file.ReadLine();

                while (line != null)
                {
                    Console.WriteLine(line);
                    String[] infor = line.Split(',');

                    String Name = infor[0];
                    int LiquidPrecipitation = 0;
                    int WindSpeed = 0;
                    int MinTemperature = 0;
                    int MaxTemperature = 0;
                    int[] RelativeHumidity = new int[2];

                    if (!infor[1].Equals(Farming.noregister))
                    {
                        LiquidPrecipitation = Convert.ToInt32(infor[1]);
                    }

                    if (!infor[2].Equals(Farming.noregister))
                    {
                        WindSpeed = Convert.ToInt32(infor[2]);
                    }

                    if (!infor[3].Equals(Farming.noregister))
                    {
                        MinTemperature = Convert.ToInt32(infor[3]);
                    }

                    if (!infor[4].Equals(Farming.noregister))
                    {
                        MaxTemperature = Convert.ToInt32(infor[4]);
                    }


                    if (!infor[5].Equals(Farming.noregister))
                    {
                        String[] partialinfor = infor[5].Split('-');
                        RelativeHumidity[0] = Convert.ToInt32(partialinfor[0]);
                        RelativeHumidity[1] = Convert.ToInt32(partialinfor[1]);
                    }

                    Farming farming = new Farming(Name, LiquidPrecipitation, RelativeHumidity, WindSpeed, MinTemperature, MaxTemperature);
                    farmings.Add(farming);

                    line = file.ReadLine();
                }
            }
        }

        public void Compare()
        {
            foreach (Area area in zone.GetAreas)
            {
                List<Relation> relationS = new List<Relation>();
                int i = 0;
                while (i < farmings.Count)
                {
                    double LiquidPrecipitationPercent = Match(farmings.ElementAt(i).GetLiquidPrecipitation / 1000,
                                                        area.GetLiquidPrecipitation,
                                                        (area.GetLiquidPrecipitation - area.GetLiquidPrecipitationConfidence),
                                                        (area.GetLiquidPrecipitation + area.GetLiquidPrecipitationConfidence));

                    double[] RelativeHumidityPercent = new double[2];

                    RelativeHumidityPercent[0] = Match(farmings.ElementAt(i).GetRelativeHumidity[0] / 100,
                                                         area.GetRelativeHumidity,
                                                         (area.GetRelativeHumidity - area.GetRelativeHumidityConfidence),
                                                         (area.GetRelativeHumidity + area.GetRelativeHumidityConfidence));

                    RelativeHumidityPercent[0] = Match(farmings.ElementAt(i).GetRelativeHumidity[1] / 100,
                                                        area.GetRelativeHumidity,
                                                        (area.GetRelativeHumidity - area.GetRelativeHumidityConfidence),
                                                        (area.GetRelativeHumidity + area.GetRelativeHumidityConfidence));

                    double[] TemperaturePercent = new double[2];

                    TemperaturePercent[0] = Match(farmings.ElementAt(i).GetMinTemperature,
                                                        area.GetTemperature,
                                                        (area.GetTemperature - area.GetTemperatureConfidence),
                                                        (area.GetTemperature + area.GetTemperatureConfidence));

                    TemperaturePercent[0] = Match(farmings.ElementAt(i).GetMaxTemperature,
                                                        area.GetTemperature,
                                                        (area.GetTemperature - area.GetTemperatureConfidence),
                                                        (area.GetTemperature + area.GetTemperatureConfidence));

                    double WindSpeedPercent = Match(farmings.ElementAt(i).GetWindSpeed,
                                                        area.GetWindSpeed,
                                                        (area.GetWindSpeed - area.GetWindspeedConfidence),
                                                        (area.GetWindSpeed + area.GetWindspeedConfidence));

                    double compatibility = (LiquidPrecipitationPercent + RelativeHumidityPercent[0] + RelativeHumidityPercent[1] + TemperaturePercent[0] +
                        TemperaturePercent[1] + WindSpeedPercent) / 6;

                    Relation relation = new Relation(compatibility, LiquidPrecipitationPercent, RelativeHumidityPercent, TemperaturePercent,
                        WindSpeedPercent, area, farmings.ElementAt(i));

                    relations.Add(relation);
                    i++;
                }
            }

        }

        public double Match(int expected, double current, double inf, double sup)
        {
            double compatible = 0;

            if (inf < expected && expected < sup)
            {
                compatible = current / expected;
            }
            return compatible;
        }

        public Zone GetZone { get => zone; set => zone = value; }
        public List<Farming> GetFarmings { get => farmings; set => farmings = value; }
        public List<Relation> GetRelations { get => relations; set => relations = value; }
    }
}