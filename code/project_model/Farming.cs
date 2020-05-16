using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_model
{
    class Farming
    {
        private String Name;
        private int LiquidPrecipitation;
        private double RelativeHumidity;
        private double WindSpeed;
        private double MinTemperature;
        private double MaxTemperature;
       
        public Farming(String Name, int LiquidPrecipitation, double RelativeHumidity, double WindSpeed, double MinTemperature, double MaxTemperature)
        {
            this.Name = Name;
            this.RelativeHumidity = RelativeHumidity;
            this.LiquidPrecipitation = LiquidPrecipitation;            
            this.MinTemperature = MinTemperature;
            this.MaxTemperature = MaxTemperature;
            this.WindSpeed = WindSpeed;
        }

        public string GetName { get => Name; set => Name = value; }
        public int GetLiquidPrecipitation { get => LiquidPrecipitation; set => LiquidPrecipitation = value; }
        public double GetRelativeHumidity { get => RelativeHumidity; set => RelativeHumidity = value; }
        public double GetWindSpeed { get => WindSpeed; set => WindSpeed = value; }
        public double GetMinTemperature { get => MinTemperature; set => MinTemperature = value; }
        public double GetMaxTemperature { get => MaxTemperature; set => MaxTemperature = value; }
    }
}