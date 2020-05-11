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
        private double WindSpeed;
        private double MinTemperature;
        private double MaxTemperature;

        public Farming()
        {

        }

        public Farming(int LiquidPrecipitation, double WindSpeed,
            double MinTemperature, double MaxTemperature, String Name)
        {
            this.Name = Name;
            this.LiquidPrecipitation = LiquidPrecipitation;
            this.WindSpeed = WindSpeed;
            this.MinTemperature = MinTemperature;
            this.MaxTemperature = MaxTemperature;
        }

        public string GetName { get => Name; set => Name = value; }
        public int GetLiquidPrecipitation { get => LiquidPrecipitation; set => LiquidPrecipitation = value; }
        public double GetWindSpeed { get => WindSpeed; set => WindSpeed = value; }
        public double GetMinTemperature { get => MinTemperature; set => MinTemperature = value; }
        public double GetMaxTemperature { get => MaxTemperature; set => MaxTemperature = value; }

    }
}