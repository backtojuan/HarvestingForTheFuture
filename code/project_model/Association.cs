using System;
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

        public Association()
        {
            farmings = new List<Farming>();
            loadFarming(Farming.path);
            loadZone(Analyzer.path);
        }

        public void loadZone(String path)
        {
            zone = new Zone();
            using(System.IO.StreamReader file = new System.IO.StreamReader(path)) 
            {
                String line = file.ReadLine();

                while (line != null) 
                {
                    String[] infor = line.Split(';');

                    String name = infor[0];
                    double estimatedliquidprecipitation = Convert.ToDouble(infor[1]);
                    double estimatedrelativehumidity = Convert.ToDouble(infor[2]);
                    double estimatedtemperature = Convert.ToDouble(infor[3]);
                    double estimatedwindspeed = Convert.ToDouble(infor[4]);


                    Area area = new Area(name,estimatedliquidprecipitation,estimatedrelativehumidity,estimatedtemperature,estimatedwindspeed);
                    zone.AddArea(area);
                    line = file.ReadLine();
                }
            }
        }

        public void loadFarming(String path)
        {
            using (System.IO.StreamReader file = new System.IO.StreamReader(path))
            {
                String line = file.ReadLine();
                line = file.ReadLine();

                while (line != null)
                {
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
                int i = 0;
                while (i < 10)
                {
                    Relation relation = new Relation("neutro",(area.GetLiquidPrecipitation/farmings.ElementAt(i).GetLiquidPrecipitation),
                        (area.GetRelativeHumidity/farmings.ElementAt(i).GetRelativeHumidity[0]),
                        (area.GetTemperature/farmings.ElementAt(i).GetMaxTemperature),
                        (area.GetWindSpeed/farmings.ElementAt(i).GetWindSpeed), area, farmings.ElementAt(i));

                    relations.Add(relation);
                }
                i++;
            }
        }
        
        public Boolean Match(int value, double inf, double sup)
        {
            Boolean compatible = false;
            
            if(inf < value && value < sup) 
            {
                compatible = true;
            }

            return compatible;
        }

        public Zone GetZone { get => zone; set => zone = value; }
        public List<Farming> GetFarmings { get => farmings; set => farmings = value; }
        public List<Relation> GetRelations { get => relations; set => relations = value; }
    }
}