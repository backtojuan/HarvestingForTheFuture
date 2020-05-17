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

        

        public ConsolidatedPage()
        {
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

            
            

            Test();
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
         * 
         */
         public void ShowInfoHarvesting(String Harvesting)
        {
            //Llamar metodo para mostar info
            //MainController.
        }



    }
}
