using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_model
{
    class Area
    {
        private String Latitude;
        private String Longitude;
        private int LiquidPrecipitation;
        private double RH;
        private int UVBRadiation;
        private double Temperature;
        private double Concentration;
        
        public Area()
        {
            
        }
        public Area(String Latitude, String Longitude, int LiquidPrecipitation,  double RH, int UVBRadiation,  double Temperature, double Concentration)
        {
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            this.LiquidPrecipitation = LiquidPrecipitation;
            this.RH = RH;
            this.UVBRadiation = UVBRadiation;
            this.Temperature = Temperature;
            this.Concentration = Concentration;
        }

        public string GetLatitude { get => Latitude; set => Latitude = value; }
        public string GetLongitude { get => Longitude; set => Longitude = value; }
        public int GetLiquidPrecipitation { get => LiquidPrecipitation; set => LiquidPrecipitation = value; }
        public double GetRH { get => RH ; set => RH = value; }
        public int GetUVBRadiation { get => UVBRadiation; set => UVBRadiation = value; }
        public double GetTemperature { get => Temperature; set => Temperature = value; }
        public double GetConcentration { get => Concentration; set => Concentration = value; }

    }
}
