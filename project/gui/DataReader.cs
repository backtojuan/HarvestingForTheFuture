using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using model;

namespace gui
{
    public partial class DataReader : Form
    {
        private List<Data> data;
        
        public DataReader()
        {
            InitializeComponent();
        }

        /**
         * Shows a warning message to user
         */
        private void ShowWarning() {

            MessageBox.Show("You need to enter the complete criteria to request the filtering",
                "WARNING", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        /**
         * Launches a new form to show the results
        */
        private void LaunchResults() 
        {
            DataFilter datafilter = new DataFilter();
            //datafilter.FillDataGridView(data);
            datafilter.FillDataListView(data);
            datafilter.ShowDialog();
        }

        private void Filter_Click(object sender, EventArgs e)
        {
            User user = new User();
           
            String request = User.URL;

            String offset = amount.Text;
            String limit = this.limit.Text;
            String val = this.val.Text;

            if (offset.Equals("") || limit.Equals(""))
            {
                ShowWarning();
            }
            else {
                request += User.Limit + limit + User.Addition + User.Amount + offset;
                user.Load(Convert.ToInt32(limit),request);
                data = user.GetData();
                LaunchResults();
            }
        }
    }
}