using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_model
{
    public class Relation
    {
        private Area Area;
        private Farming Farming;
       
        private double compatibility;
        
        private double LiquidPrecipiationPercent;
        private double[] RelativeHumidityPercent;
        private double[] TemperaturePercent;
        private double WindSpeedPercent;

        public Relation(double compatibility, double LiquidPrecipiationPercent, double[] RelativeHumidityPercent, double[] TemperaturePercent, 
            double WindSpeedPercent, Area Area, Farming Farming)
        {            
            this.compatibility = compatibility;
            this.RelativeHumidityPercent = RelativeHumidityPercent;
            this.LiquidPrecipiationPercent = LiquidPrecipiationPercent;
            this.TemperaturePercent = TemperaturePercent;
            this.WindSpeedPercent = WindSpeedPercent;
            this.Area = Area;
            this.Farming = Farming;
        }
        
        public double GetCompatibility { get => compatibility; set => compatibility = value; }
        public double GetLiquidPrecipiationPercent { get => LiquidPrecipiationPercent; set => LiquidPrecipiationPercent = value; }
        public double[] GetRelativeHumidityPercent { get => RelativeHumidityPercent; set => RelativeHumidityPercent = value; }
        public double[] GetTemperaturePercent { get => TemperaturePercent; set => TemperaturePercent = value; }
        public double GetWindSpeedPercent { get => WindSpeedPercent; set => WindSpeedPercent = value; }
        public Area GetArea { get => Area; set => Area = value; }
        public Farming GetFarming { get => Farming; set => Farming = value; }
    }
}
