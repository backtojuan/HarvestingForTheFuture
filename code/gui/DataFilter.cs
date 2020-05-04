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
    public partial class DataFilter : Form
    {
        private DataGridView datagridview;

        Button button = new Button();
        Button right = new Button();
        Button left = new Button();

        public DataFilter()
        {
            InitializeComponent();

            //Initialize a label tag
            Label label = new Label();
            label.Text = "DATA RESULTS";
            label.ForeColor = Color.Black;
            label.Location = new Point(25, 25);
            this.Controls.Add(label);
            label.Show();

            //initializes a button to close the form mandatory
            button.Text = "Accept";
            button.BackColor = Color.Transparent;
            button.ForeColor = Color.Black;
            button.Location = new Point(150, 20);
            button.Size = new Size(100, 25);
            button.Cursor = Cursors.Hand;
            button.Click += (sender, args) =>
            {
                this.Close();
            };
            this.Controls.Add(button);
            button.Show();
        }

        /**
         * This method initializes the data grid with when one column has been selected to be shown
         */
        public void FillDataGridViewColumn(String column, List<Data> data)
        {
            data.Reverse();
            datagridview = new DataGridView();
            datagridview.Columns.Add(column, column);

            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagridview.Location = new Point(25, 50);
            datagridview.Size = new Size(950, 250);
            datagridview.AllowUserToAddRows = false;

            foreach (Data row in data)
            {
                int i = datagridview.Rows.Add();

                if (column.Equals("Date"))
                {
                    datagridview.Rows[i].Cells[0].Value = row.GetDate;
                    this.Controls.Add(datagridview);
                    datagridview.Show();
                }
                else if (column.Equals("Enviromental authority"))
                {
                    datagridview.Rows[i].Cells[0].Value = row.GetEnvironmentalAuthority;
                    this.Controls.Add(datagridview);
                    datagridview.Show();
                }
                else if (column.Equals("Station name"))
                {
                    datagridview.Rows[i].Cells[0].Value = row.GetStationName;
                    this.Controls.Add(datagridview);
                    datagridview.Show();
                }
                else if (column.Equals("Technology"))
                {
                    datagridview.Rows[i].Cells[0].Value = row.GetTechnology;
                    this.Controls.Add(datagridview);
                    datagridview.Show();
                }
                else if (column.Equals("Latitude"))
                {
                    datagridview.Rows[i].Cells[0].Value = row.GetLatitude;
                    this.Controls.Add(datagridview);
                    datagridview.Show();
                }
                else if (column.Equals("Longitude"))
                {
                    datagridview.Rows[i].Cells[0].Value = row.GetLongitude;
                    this.Controls.Add(datagridview);
                    datagridview.Show();
                }
                else if (column.Equals("Department name"))
                {
                    datagridview.Rows[i].Cells[0].Value = row.GetDepartmentName;
                    this.Controls.Add(datagridview);
                    datagridview.Show();
                }
                else if (column.Equals("Department code"))
                {
                    datagridview.Rows[i].Cells[0].Value = row.GetDepartmentCode;
                    this.Controls.Add(datagridview);
                    datagridview.Show();
                }
                else if (column.Equals("Municipality name"))
                {
                    datagridview.Rows[i].Cells[0].Value = row.GetMunicipalityName;
                    this.Controls.Add(datagridview);
                    datagridview.Show();
                }
                else if (column.Equals("Municipality code"))
                {
                    datagridview.Rows[i].Cells[0].Value = row.GetMunicipalityCode;
                    this.Controls.Add(datagridview);
                    datagridview.Show();
                }
                else if (column.Equals("Type of station"))
                {
                    datagridview.Rows[i].Cells[0].Value = row.GetTypeofStation;
                    this.Controls.Add(datagridview);
                    datagridview.Show();
                }
                else if (column.Equals("Exhibition time"))
                {
                    datagridview.Rows[i].Cells[0].Value = row.GetExhibitionTime;
                    this.Controls.Add(datagridview);
                    datagridview.Show();
                }
                else if (column.Equals("Variable"))
                {
                    datagridview.Rows[i].Cells[0].Value = row.GetVariable;
                    this.Controls.Add(datagridview);
                    datagridview.Show();
                }
                else if (column.Equals("Units"))
                {
                    datagridview.Rows[i].Cells[0].Value = row.GetUnits;
                    this.Controls.Add(datagridview);
                    datagridview.Show();
                }
                else if (column.Equals("Concentration"))
                {
                    datagridview.Rows[i].Cells[0].Value = row.GetConcentration;
                    this.Controls.Add(datagridview);
                    datagridview.Show();
                }
            }
            this.right.Enabled = true;
            this.left.Enabled = true;
        }

        /**
        * This method initializes the data grid with when all columns has to be shown
        */
        public void FillDataGridView(List<Data> data)
        {
            data.Reverse();
            datagridview = new DataGridView();

            datagridview.Columns.Add("Date", "Date");
            datagridview.Columns.Add("EnviromentalAuthority", "EnviromentalAuthority");
            datagridview.Columns.Add("StationName", "StationName");
            datagridview.Columns.Add("Technology", "Technology");
            datagridview.Columns.Add("Latitude", "Latitude");
            datagridview.Columns.Add("Longitude", "Longitude");
            datagridview.Columns.Add("DepartmentCode", "DepartmentCode");
            datagridview.Columns.Add("DepartmentName", "DepartmentName");
            datagridview.Columns.Add("MunicipalityCode", "MunicipalityCode");
            datagridview.Columns.Add("MunicipalityName", "MunicipalityName");
            datagridview.Columns.Add("TypeofStation", "TypeofStation");
            datagridview.Columns.Add("ExhibitionTime", "ExhibitionTime");
            datagridview.Columns.Add("Variable", "Variable");
            datagridview.Columns.Add("Units", "Units");
            datagridview.Columns.Add("Concentration", "Concentration");

            foreach (Data row in data)
            {
                int i = datagridview.Rows.Add();

                datagridview.Rows[i].Cells[0].Value = row.GetDate;
                datagridview.Rows[i].Cells[1].Value = row.GetEnvironmentalAuthority;
                datagridview.Rows[i].Cells[2].Value = row.GetStationName;
                datagridview.Rows[i].Cells[3].Value = row.GetTechnology;
                datagridview.Rows[i].Cells[4].Value = row.GetLatitude;
                datagridview.Rows[i].Cells[5].Value = row.GetLongitude;
                datagridview.Rows[i].Cells[6].Value = row.GetDepartmentCode;
                datagridview.Rows[i].Cells[7].Value = row.GetDepartmentName;
                datagridview.Rows[i].Cells[8].Value = row.GetMunicipalityCode;
                datagridview.Rows[i].Cells[9].Value = row.GetMunicipalityName;
                datagridview.Rows[i].Cells[10].Value = row.GetTypeofStation;
                datagridview.Rows[i].Cells[11].Value = row.GetExhibitionTime;
                datagridview.Rows[i].Cells[12].Value = row.GetVariable;
                datagridview.Rows[i].Cells[13].Value = row.GetUnits;
                datagridview.Rows[i].Cells[14].Value = row.GetConcentration;
            }
            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagridview.Location = new Point(25, 50);
            datagridview.Size = new Size(950, 250);
            datagridview.AllowUserToAddRows = false;

            this.Controls.Add(datagridview);
            datagridview.Show();

            this.right.Enabled = true;
            this.left.Enabled = true;
        }
    }
}