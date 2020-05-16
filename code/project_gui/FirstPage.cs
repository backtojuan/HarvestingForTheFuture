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
    public partial class FirstPage : Form
    {
        public FirstPage()
        {
            InitializeComponent();
            //addElementsComboBox();

            //agregar metodo de carga;
            //departamentos.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        private void flowLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void ir_Click(object sender, EventArgs e)
        {

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
