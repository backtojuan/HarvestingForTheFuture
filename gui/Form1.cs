using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using model;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace gui
{
    public partial class DataReader : Form
    {
        public DataReader()
        {
            InitializeComponent();
            User user = new User();
            user.Load();

            Consulta.Text = user.GetData().ElementAt(0).toString();

        }
    }
}
