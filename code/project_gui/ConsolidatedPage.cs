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
            //cargar cultivos
            userControl11.LoadPage(this);

            
            

            //Test();
        }

        public void SetDepartmentLabel(String name)
        {
            //cambiar titulo
            departmentLabel.Text = name;
        }

        

        public void Test()
        {
            
            
            //dataGridView.DataSource = table;

        }

        /*
         * Agrega una fila al DataGridView de UserControl
         */
        public void AddToDataGridView(int pos, String name, double comp)
        {
            userControl11.AddToDataGridView(pos, name, comp);
        }


        /*
         * 
         */
        public void ShowInfoHarvesting(String Harvesting, int Relation)
        {
            //Llamar metodo para mostar info
            double [] data = MainController.GetInfoChartHumidity(Relation);
            //int year = 2011;
            for(int i = 0; i < data.Length; i++)
            {
                userControl11.AddPointInHumidity(i+1, data[i]);

            }
        }




    }
}
