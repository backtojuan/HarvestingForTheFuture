using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_model
{
    class Relation
    {
        private Area Area;
        private Farming Farming;

        private String Color;
        private double TemperaturePercent;
        private double LiquidPrecipiationPercent;

        public Relation()
        {

        }

        public Relation(String Color, double TemperaturePercent, double LiquidPrecipiationPercent, Area Area, Farming Farming)
        {
            this.Color = Color;
            this.TemperaturePercent = TemperaturePercent;
            this.LiquidPrecipiationPercent = LiquidPrecipiationPercent;
            this.Area = Area;
            this.Farming = Farming;
        }

        public String GetColor { get => Color; set => Color = value; }
        public double GetTemperaturePercent { get => TemperaturePercent; set => TemperaturePercent = value; }
        public double GetLiquidPrecipiationPercent { get => LiquidPrecipiationPercent; set => LiquidPrecipiationPercent = value; }
        public Area GetArea { get => Area; set => Area = value; }
        public Farming GetFarming { get => Farming; set => Farming = value; }

    }
}
