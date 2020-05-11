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
        private double RH;
        private double Temperature;
        private double Concentration;

        public Area()
        {

        }
        public Area(int LiquidPrecipitation, double RH, double Temperature, double Concentration)
        {            
            this.LiquidPrecipitation = LiquidPrecipitation;
            this.RH = RH;            
            this.Temperature = Temperature;
            this.Concentration = Concentration;
        }

        public int GetLiquidPrecipitation { get => LiquidPrecipitation; set => LiquidPrecipitation = value; }
        public double GetRH { get => RH; set => RH = value; }        
        public double GetTemperature { get => Temperature; set => Temperature = value; }
        public double GetConcentration { get => Concentration; set => Concentration = value; }

    }
}
