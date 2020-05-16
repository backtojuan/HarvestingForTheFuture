using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_model
{
    class Area
    {           
        private int LiquidPrecipitation;
        private double RelativeHumidity;
        private double Temperature;        
        private double Windspeed;
        
        public Area(int LiquidPrecipitation, double RelativeHumidity, double Temperature, double Windspeed)
        {
            this.LiquidPrecipitation = LiquidPrecipitation;
            this.RelativeHumidity = RelativeHumidity;
            this.Temperature = Temperature;
            this.Windspeed = Windspeed;
        }

        public int GetLiquidPrecipitation { get => LiquidPrecipitation; set => LiquidPrecipitation = value; }
        public double GetRelativeHumidity { get => RelativeHumidity; set => RelativeHumidity = value; }
        public double GetTemperature { get => Temperature; set => Temperature = value; }
        public double GetConcentration { get => Windspeed; set => Windspeed = value; }

    }
}