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
            double [] data = MainController.GetInfoChartHumidity(Relation);
            int [] harvData = MainController.GetHumidityHarv(Relation);
            //int year = 2011;
            for(int i = 0; i < data.Length; i++)
            {
                userControl11.AddPointInHumidityDep(i+1, data[i]);
                userControl11.AddPointInHumidityMaxHarv(i+1, harvData[1]);
                userControl11.AddPointInHumidityMinHarv(i + 1, harvData[1]);
            }
        }
    }
}
