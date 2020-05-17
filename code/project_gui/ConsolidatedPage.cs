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
            userControl11.LoadPage();
            Test();
        }

        public void SetDepartmentLabel(String name)
        {
            //cambiar titulo
            departmentLabel.Text = name;
        }

        public void Test()
        {
            harvestingCmb.Items.Add("Antioquia");
            harvestingCmb.Items.Add("Valle del cauca ");
        }

        /*
         * 
         */
        private void harvestingCmb_SelectedIndexChanged(object sender, EventArgs e)
        {
            //actualizar info cuando cambie el cultivo

            //cambiar titulo del cultivo
            userControl11.SetHarvestingLabel(harvestingCmb.Text);
            //cambiar descripción del cultivo
            //cargar el data grid con la info

            //add all harvesting like option
            //in this option the description harvesting ir null


        }

        

    }
}
