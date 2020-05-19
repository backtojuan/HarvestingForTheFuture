using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;




namespace project_gui
{
    public partial class ConsolidatedPage : Form
    {

        private MainController MainController;


        public ConsolidatedPage(MainController main)
        {
            MainController = main;
            InitializeComponent();
            LoadPage();
        }

        /*
         * 
         */
        public void LoadPage()
        {
            double lat = MainController.GetLatitude();
            double lon = MainController.GetLongitude();
            userControl11.LoadPage(this, lat, lon);
        }

        public void SetDepartmentLabel(String name)
        {
            //cambiar titulo
            departmentLabel.Text = name;
        }

        /*
         * Agrega una fila al DataGridView de UserControl
         */
        public void AddToDataGridView(int pos, String name, double comp)
        {
            userControl11.AddToDataGridView(pos, name, comp);
        }


        /*
         * todas la s graficas
         */
        public void ShowInfoHarvesting(String Harvesting, int Relation)
        {
            //Llamar metodo para mostar info
            List<double> liquid = MainController.GetInfoLiquidPrecipitationEstimations(Relation);
            List<double> humidity = MainController.GetInfoChartHumidity(Relation);
            List<double> temperature = MainController.GetInfoChartTemperature(Relation);
            List<double> windspeed = MainController.GetInfoChartWindSpeed(Relation);

            double liquidN = MainController.GetLiquidPrecipitation(Relation);
            double[] humidityN = MainController.GetInfoHumidity(Relation);
            double maxTemp = MainController.GetInfoMaxTemperature(Relation);
            double minTemp = MainController.GetInfoMinTemperature(Relation);
            double windSpeedN = MainController.GetInfoWindSpeed(Relation);
            //int year = 2011;
            for (int i = 2010; i < 2017; i++)
            {
                //Liquid Precipitation
                if (i < liquid.Count)
                    userControl11.AddPointInLiquidPrecDep(i + 1, liquid[i]);
                userControl11.AddPointInLiquidPrecHar(i + 1, liquidN);
                //Relative Humidity
                if (i < humidity.Count)
                    userControl11.AddPointInHumidityDep(i + 1, humidity[i]);
                userControl11.AddPointInHumidityMaxHarv(i + 1, humidityN[1]);
                userControl11.AddPointInHumidityMinHarv(i + 1, humidityN[0]);
                //Temperature
                if (i < temperature.Count)
                    userControl11.AddPointInTemperatureDep(i + 1, temperature[i]);
                userControl11.AddPointInTemperatureMaxHar(i + 1, maxTemp);
                userControl11.AddPointInTemperatureMinHar(i + 1, minTemp);
                //Wind Speed
                if (i < windspeed.Count)
                    userControl11.AddPointInWindSpeedDep(i + 1, windspeed[i]);
                userControl11.AddPointInWindSpeedcHar(i + 1, windSpeedN);
            }
        }
    }
}
