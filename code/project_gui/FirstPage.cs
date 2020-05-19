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
using project_model;

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
            MainController = new MainController(this);            
        }

        public void LoadFirstPage(List<String> departmets)
        {
            addElementsComboBox(departmets, departmentsCmb);
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

        /*
         * Carga la pagina ConsolidatedPage
         */
        private void ir_Click(object sender, EventArgs e)
        {
            //cargar consolidatedPage
            MainController.LoadConsolidatedPage(departmentsCmb.Text);                                                            
        }

        /*
         * Agrega los elementos de la lista pasada por paramtro al combobox indicado
         */
        private void addElementsComboBox(List<String> list, ComboBox comboBox)
        {
            for (int i=0; i < list.Count; i++)
            {
                comboBox.Items.Add(list.ElementAt(i));
            }
        }

        /*
         * Evento, sucede al hacer clic sobre el boton de actualizar
         * actualiza la base de datos, incia el llamado para el pre-procedamiento
         */
        private void actualice_Click(object sender, EventArgs e)
        {
            MainController.ActualizeDB();
        }

        /*
         * Cambia la información que se muestra en la interfaz
         * de acuerdo al departamento seleccionado.
         */
        private void departments_SelectedIndexChanged(object sender, EventArgs e)
        {
            desciptionLabel.Text = MainController.GetDepartmentDescription(departmentsCmb.Text);
            //image.
        }
    }
}
