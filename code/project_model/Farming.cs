using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project_model
{
    public class Farming
    {
        private string Name;
        private int LiquidPrecipitation;
        private int[] RelativeHumidity;
        private int WindSpeed;
        private int MinTemperature;
        private int MaxTemperature;

        public const String path = "..\\..\\..\\..\\code\\data\\CULTIVOS\\DATOSDECULTIVOS.csv";
        public const String noregister = "S/R";

        public Farming(String Name, int LiquidPrecipitation, int[] RelativeHumidity, int WindSpeed, int MinTemperature, int MaxTemperature)
        {
            this.Name = Name;
            this.RelativeHumidity = RelativeHumidity;
            this.LiquidPrecipitation = LiquidPrecipitation;
            this.MinTemperature = MinTemperature;
            this.MaxTemperature = MaxTemperature;
            this.WindSpeed = WindSpeed;
        }

        public string GetName { get => Name; set => Name = value; }
        public int GetLiquidPrecipitation { get => LiquidPrecipitation; set => LiquidPrecipitation = value; }
        public int[] GetRelativeHumidity { get => RelativeHumidity; set => RelativeHumidity = value; }
        public int GetWindSpeed { get => WindSpeed; set => WindSpeed = value; }
        public int GetMinTemperature { get => MinTemperature; set => MinTemperature = value; }
        public int GetMaxTemperature { get => MaxTemperature; set => MaxTemperature = value; }
    }
}