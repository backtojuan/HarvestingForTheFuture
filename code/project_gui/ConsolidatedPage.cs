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

        private DataTable table;

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

            table = new DataTable();
            table.Columns.Add(new DataColumn("Posicion", typeof(int)));
            table.Columns.Add(new DataColumn("Nombre", typeof(String)));
            table.Columns.Add(new DataColumn("Compatibilidad", typeof(double)));
            

            Test();
        }

        public void SetDepartmentLabel(String name)
        {
            //cambiar titulo
            departmentLabel.Text = name;
        }

        public void AddToDataGridView(int pos, String name, double Comp)
        {
            table.Rows.Add(pos, name, Comp);
        }

        public void Test()
        {
            AddToDataGridView(1, "Papa", 90);
            AddToDataGridView(2, "Tomate", 85);
            AddToDataGridView(3, "Trigo", 70);
            dataGridView.DataSource = table;
        }

        /*
         * 
         */
        

        

    }
}
