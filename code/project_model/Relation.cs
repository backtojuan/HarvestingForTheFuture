using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_model
{
    class Relation
    {
        private String Color;
        private double TemperaturePercent;
        private double LiquidPrecipiationPercent;
        private double UVBRadiationPercent;

        public Relation()
        {

        }

        public Relation(String Color,  double TemperaturePercent, double LiquidPrecipiationPercent, double UVBRadiationPercent)
        {
            this.Color = Color;
            this.TemperaturePercent = TemperaturePercent;
            this.LiquidPrecipiationPercent = LiquidPrecipiationPercent;
            this.UVBRadiationPercent = UVBRadiationPercent;
        }

        public String GetColor { get => Color; set => Color = value; }
        public double GetTemperaturePercent { get => TemperaturePercent; set => TemperaturePercent = value; }
        public double GetLiquidPrecipiationPercent { get => LiquidPrecipiationPercent; set => LiquidPrecipiationPercent = value; }
        public double GetUVBRadiationPercent { get => UVBRadiationPercent; set => UVBRadiationPercent = value; }
}
}
