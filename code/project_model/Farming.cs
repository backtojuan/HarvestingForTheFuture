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
        private String Latitude;
        private String Longitude;
        private int LiquidPrecipitation;
        private double WindSpeed;
        private int UVBRadiation;
        private double MinTemperature;
        private double MaxTemperature;

        public Farming()
        {

        }

        public Farming(String Latitude, String Longitude, int LiquidPrecipitation, double WindSpeed, int UVBRadiation, 
            double MinTemperature, double MaxTemperature, String Name)
        {
            this.Name = Name;
            this.Latitude = Latitude;
            this.Longitude = Longitude;
            this.LiquidPrecipitation = LiquidPrecipitation;
            this.WindSpeed = WindSpeed;
            this.UVBRadiation = UVBRadiation;
            this.MinTemperature = MinTemperature;
            this.MaxTemperature = MaxTemperature;
        }

        public string GetName { get => Name; set => Name = value; }
        public string GetLatitude { get => Latitude; set => Latitude = value; }
        public string GetLongitude { get => Longitude; set => Longitude = value; }
        public int GetLiquidPrecipitation { get => LiquidPrecipitation; set => LiquidPrecipitation = value; }
        public double GetWindSpeed { get => WindSpeed; set => WindSpeed = value; }
        public int GetUVBRadiation { get => UVBRadiation; set => UVBRadiation = value; }
        public double GetMinTemperature { get => MinTemperature; set => MinTemperature = value; }
        public double GetMaxTemperature { get => MaxTemperature; set => MaxTemperature = value; }
    }
}
