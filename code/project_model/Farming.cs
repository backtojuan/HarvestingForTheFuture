using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_model
{
    /**
     * This class saves information for farmings of interest
     */
    public class Farming
    {
        private string Name;
        private double LiquidPrecipitation;
        private double[] RelativeHumidity;
        private double WindSpeed;
        private double MinTemperature;
        private double MaxTemperature;

        public const String path = "..\\..\\..\\..\\code\\Data\\CULTIVOS\\DATOSDECULTIVOS.csv";
        public const String noregister = "S/R";

        /**
         * Farming constructor
         */
        public Farming(String Name, double LiquidPrecipitation, double[] RelativeHumidity, double WindSpeed, double MinTemperature, double MaxTemperature)
        {
            this.Name = Name;
            this.RelativeHumidity = RelativeHumidity;
            this.LiquidPrecipitation = LiquidPrecipitation;
            this.MinTemperature = MinTemperature;
            this.MaxTemperature = MaxTemperature;
            this.WindSpeed = WindSpeed;
        }

        /**
         * This Gets and Sets important values in this class
         */
        public string GetName { get => Name; set => Name = value; }
        public double GetLiquidPrecipitation { get => LiquidPrecipitation; set => LiquidPrecipitation = value; }
        public double[] GetRelativeHumidity { get => RelativeHumidity; set => RelativeHumidity = value; }
        public double GetWindSpeed { get => WindSpeed; set => WindSpeed = value; }
        public double GetMinTemperature { get => MinTemperature; set => MinTemperature = value; }
        public double GetMaxTemperature { get => MaxTemperature; set => MaxTemperature = value; }
    }
}