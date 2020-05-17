using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project_gui;

namespace project_gui
{
    public partial class FirstPage : Form
    {
        /*
         * Representa la relación con la controladora principal MainController
         */
        private MainController MainController;

        public FirstPage()
        {
            InitializeComponent();
            //Inicializa MainController
            MainController = new MainController(this);

            //addElementsComboBox();

            //agregar metodo de carga;
            //departamentos.DropDownStyle = ComboBoxStyle.DropDownList;
            Test();
            
        }
        /*
         * Es un metod con información que cambia algunas cosas de la interfaz
         * para realizar pruebas del funcionamiento mientras se realiza la conexión con el modelo
         */
        public void Test()
        {
            List<String> list = new List<string>();
            list.Add("Valle del Cauca");
            list.Add("Arauca");
            addElementsComboBox(list, departmentsCmb);
        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        /*
         * Carga la pagina ConsolidatedPage
         */
        private void ir_Click(object sender, EventArgs e)
        {
            //cargar consolidatedPage
            MainController.LoadConsolidatedPage(departmentsCmb.Text);
        }

        private void departamentos_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }
        private void addElementsComboBox(List<String> list, ComboBox comboBox)
        {

            for (int i=0; i < list.Count; i++)
            {
                comboBox.Items.Add(list.ElementAt(i));
            }
        }

        private void image_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FirstPage_Load(object sender, EventArgs e)
        {

        }
    }
}
