using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_model
{
    /**
     * Serializable class Area allows to save information about an area
     */
    [Serializable]
    public class Area
    {
        private String name;

        private String latitude;
        private String longitude;

        private List<double> liquidprecipitationestimations;
        private List<double> relativehumidityestimations;
        private List<double> temperatureestimations;
        private List<double> windspeedestimations;

        private double LiquidPrecipitation;
        private double RelativeHumidity;
        private double Temperature;
        private double Windspeed;

        private double LiquidPrecipitationConfidence;
        private double RelativeHumidityConfidence;
        private double TemperatureConfidence;
        private double WindspeedConfidence;

        /**
         * Area constructor
         */
        public Area(String name, String latitude, String longitude, List<double> liquidprecipitationestimations, List<double> relativehumidityestimations,
            List<double> temperatureestimations, List<double> windspeedestimations, double LiquidPrecipitation, double RelativeHumidity, double Temperature, 
            double Windspeed, double LiquidPrecipitationConfidence, double RelativeHumidityConfidence, double TemperatureConfidence, double WindspeedConfidence)
        {
            this.name = name;
            this.latitude = latitude;
            this.longitude = longitude;
            this.liquidprecipitationestimations = liquidprecipitationestimations;
            this.relativehumidityestimations = relativehumidityestimations;
            this.temperatureestimations = temperatureestimations;
            this.windspeedestimations = windspeedestimations;
            this.LiquidPrecipitation = LiquidPrecipitation;
            this.RelativeHumidity = RelativeHumidity;
            this.Temperature = Temperature;
            this.Windspeed = Windspeed;
            this.LiquidPrecipitationConfidence = LiquidPrecipitationConfidence;
            this.RelativeHumidityConfidence = RelativeHumidityConfidence;
            this.TemperatureConfidence = TemperatureConfidence;
            this.WindspeedConfidence = WindspeedConfidence;
        }

        /**
         * This Gets and Sets important values in this class
         */
        public String GetName { get => name; set => name = value; }
        public string Latitude { get => latitude; set => latitude = value; }
        public string Longitude { get => longitude; set => longitude = value; }
        public List<double> Liquidprecipitationestimations { get => liquidprecipitationestimations; set => liquidprecipitationestimations = value; }
        public List<double> Relativehumidityestimations { get => relativehumidityestimations; set => relativehumidityestimations = value; }
        public List<double> Temperatureestimations { get => temperatureestimations; set => temperatureestimations = value; }
        public List<double> Windspeedestimations { get => windspeedestimations; set => windspeedestimations = value; }
        public double GetLiquidPrecipitation { get => LiquidPrecipitation; set => LiquidPrecipitation = value; }
        public double GetRelativeHumidity { get => RelativeHumidity; set => RelativeHumidity = value; }
        public double GetTemperature { get => Temperature; set => Temperature = value; }
        public double GetWindSpeed { get => Windspeed; set => Windspeed = value; }
        public double GetLiquidPrecipitationConfidence { get => LiquidPrecipitationConfidence; set => LiquidPrecipitationConfidence = value; }
        public double GetRelativeHumidityConfidence { get => RelativeHumidityConfidence; set => RelativeHumidityConfidence = value; }
        public double GetTemperatureConfidence { get => TemperatureConfidence; set => TemperatureConfidence = value; }
        public double GetWindspeedConfidence { get => WindspeedConfidence; set => WindspeedConfidence = value; }
    }
}