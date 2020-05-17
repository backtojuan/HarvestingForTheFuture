using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_model
{
    public class Area
    {
        private String name;
        private double LiquidPrecipitation;
        private double RelativeHumidity;
        private double Temperature;
        private double Windspeed;
        private double LiquidPrecipitationConfidence;
        private double RelativeHumidityConfidence;
        private double TemperatureConfidence;
        private double WindspeedConfidence;


        public Area(String name, double LiquidPrecipitation, double RelativeHumidity, double Temperature, double Windspeed,
            double LiquidPrecipitationConfidence, double RelativeHumidityConfidence, double TemperatureConfidence, double WindspeedConfidence)
        {
            this.name = name;
            this.LiquidPrecipitation = LiquidPrecipitation;
            this.RelativeHumidity = RelativeHumidity;
            this.Temperature = Temperature;
            this.Windspeed = Windspeed;
            this.LiquidPrecipitationConfidence = LiquidPrecipitationConfidence;
            this.RelativeHumidityConfidence = RelativeHumidityConfidence;
            this.TemperatureConfidence = TemperatureConfidence;
            this.WindspeedConfidence = WindspeedConfidence;
        }

        public String toString() 
        {
            return name + " " + LiquidPrecipitation + " " + RelativeHumidity + " " + Temperature + " " + Windspeed;
        
        }

        public String GetName { get => name; set => name = value; }
        public double GetLiquidPrecipitation { get => LiquidPrecipitation; set => LiquidPrecipitation = value; }
        public double GetRelativeHumidity { get => RelativeHumidity; set => RelativeHumidity = value; }
        public double GetTemperature { get => Temperature; set => Temperature = value; }
        public double GetWindSpeed { get => Windspeed; set => Windspeed = value; }
        public double GetiquidPrecipitationConfidence { get => LiquidPrecipitationConfidence; set => LiquidPrecipitationConfidence = value; }
        public double GetRelativeHumidityConfidence { get => RelativeHumidityConfidence; set => RelativeHumidityConfidence = value; }
        public double GetTemperatureConfidence { get => TemperatureConfidence; set => TemperatureConfidence = value; }
        public double GetWindspeedConfidence { get => WindspeedConfidence; set => WindspeedConfidence = value; }
    }
}