using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_model
{
    class Association
    {
        private Zone zone;
        private List<Farming> farmings;

        private List<Relation> relations;

        public Association()
        {
            farmings = new List<Farming>();
        }

        public void association(String department)
        {

        }

        public void loadZone(String departmentRoute)
        {

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

                    if (infor[3].Equals(Farming.noregister))
                    {
                        MinTemperature = Convert.ToDouble(infor[3]);
                    }
                    
                    if (infor[4].Equals(Farming.noregister))
                    {
                        MaxTemperature = Convert.ToDouble(infor[4]);
                    }
                    

                    if (infor[5].Equals(Farming.noregister))
                    {
                        String[] partialinfor = infor[5].Split('-');                        
                        RelativeHumidity[0] = Convert.ToDouble(partialinfor[0]);
                        RelativeHumidity[1] = Convert.ToDouble(partialinfor[1]);
                    }

                    Farming farming = new Farming(Name, LiquidPrecipitation, RelativeHumidity, WindSpeed, MinTemperature, MaxTemperature);                        );
                    farmings.Add(farming);

                    line = file.ReadLine();
                }
            }
        }

        public void Match() 
        { 
        
        }

        public Zone GetZone { get => zone; set => zone = value; }
        public List<Farming> GetFarmings { get => farmings; set => farmings = value; }
        public List<Relation> GetRelations { get => relations; set => relations = value; }
    }
}