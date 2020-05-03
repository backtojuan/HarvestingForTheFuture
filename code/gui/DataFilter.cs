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

        private int limit;
        private int amount;
        private int pass;

        private int pos;

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

            //initializes a button to navigate trough data            
            right.Text = ">>>";
            right.BackColor = Color.Transparent;
            right.ForeColor = Color.Black;
            right.Location = new Point(850, 20);
            right.Size = new Size(100, 25);
            right.Cursor = Cursors.Hand;
            right.Click += (sender, args) =>
            {
                if (pos <= limit)
                {
                    pos++;
                    pass = pass + amount;
                }
            };
            this.Controls.Add(right);
            right.Show();

            //initializes a button to navigate trough data            
            left.Text = "<<<";
            left.BackColor = Color.Transparent;
            left.ForeColor = Color.Black;
            left.Location = new Point(750, 20);
            left.Size = new Size(100, 25);
            left.Cursor = Cursors.Hand;
            left.Click += (sender, args) =>
            {
                if (pos > 1)
                {
                    pos--;
                    pass = pass - amount;
                }
            };
            this.Controls.Add(left);
            right.Show();
        }

        public void setLimit(int limit)
        {
            this.limit = limit;
        }

        public void setAmount(int amount)
        {
            this.amount = amount;
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

        public void FillDataGridViewVarious(List<Data> data, Double limit)
        {
            MessageBox.Show("Size " + data.Count());

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

            for (int i = 0; i < amount; i++)
            {
                int j = datagridview.Rows.Add();

                datagridview.Rows[j].Cells[0].Value = data.ElementAt(i).GetDate;
                datagridview.Rows[j].Cells[1].Value = data.ElementAt(i).GetEnvironmentalAuthority;
                datagridview.Rows[j].Cells[2].Value = data.ElementAt(i).GetStationName;
                datagridview.Rows[j].Cells[3].Value = data.ElementAt(i).GetTechnology;
                datagridview.Rows[j].Cells[4].Value = data.ElementAt(i).GetLatitude;
                datagridview.Rows[j].Cells[5].Value = data.ElementAt(i).GetLongitude;
                datagridview.Rows[j].Cells[6].Value = data.ElementAt(i).GetDepartmentCode;
                datagridview.Rows[j].Cells[7].Value = data.ElementAt(i).GetDepartmentName;
                datagridview.Rows[j].Cells[8].Value = data.ElementAt(i).GetMunicipalityCode;
                datagridview.Rows[j].Cells[9].Value = data.ElementAt(i).GetMunicipalityName;
                datagridview.Rows[j].Cells[10].Value = data.ElementAt(i).GetTypeofStation;
                datagridview.Rows[j].Cells[11].Value = data.ElementAt(i).GetExhibitionTime;
                datagridview.Rows[j].Cells[12].Value = data.ElementAt(i).GetVariable;
                datagridview.Rows[j].Cells[13].Value = data.ElementAt(i).GetUnits;
                datagridview.Rows[j].Cells[14].Value = data.ElementAt(i).GetConcentration;
            }

            pos = 1;
            pass = amount;

            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagridview.Location = new Point(25, 50);
            datagridview.Size = new Size(950, 250);
            datagridview.AllowUserToAddRows = false;

            this.Controls.Add(datagridview);
            datagridview.Show();
        }


        public void FillDataGridViewVariousForward(List<Data> data, Double limit)
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

            for (int i = pass - amount; i < pass; i++)
            {
                int j = datagridview.Rows.Add();

                datagridview.Rows[j].Cells[0].Value = data.ElementAt(i).GetDate;
                datagridview.Rows[j].Cells[1].Value = data.ElementAt(i).GetEnvironmentalAuthority;
                datagridview.Rows[j].Cells[2].Value = data.ElementAt(i).GetStationName;
                datagridview.Rows[j].Cells[3].Value = data.ElementAt(i).GetTechnology;
                datagridview.Rows[j].Cells[4].Value = data.ElementAt(i).GetLatitude;
                datagridview.Rows[j].Cells[5].Value = data.ElementAt(i).GetLongitude;
                datagridview.Rows[j].Cells[6].Value = data.ElementAt(i).GetDepartmentCode;
                datagridview.Rows[j].Cells[7].Value = data.ElementAt(i).GetDepartmentName;
                datagridview.Rows[j].Cells[8].Value = data.ElementAt(i).GetMunicipalityCode;
                datagridview.Rows[j].Cells[9].Value = data.ElementAt(i).GetMunicipalityName;
                datagridview.Rows[j].Cells[10].Value = data.ElementAt(i).GetTypeofStation;
                datagridview.Rows[j].Cells[11].Value = data.ElementAt(i).GetExhibitionTime;
                datagridview.Rows[j].Cells[12].Value = data.ElementAt(i).GetVariable;
                datagridview.Rows[j].Cells[13].Value = data.ElementAt(i).GetUnits;
                datagridview.Rows[j].Cells[14].Value = data.ElementAt(i).GetConcentration;
            }

            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagridview.Location = new Point(25, 50);
            datagridview.Size = new Size(950, 250);
            datagridview.AllowUserToAddRows = false;

            this.Controls.Add(datagridview);
            datagridview.Show();
        }

        public void FillDataGridViewVariousBackward(List<Data> data, Double limit)
        {
            data.Reverse();
            datagridview = new DataGridView();

            for (int i = (pass - amount); i < pass; i++)
            {
                int j = datagridview.Rows.Add();

                datagridview.Rows[j].Cells[0].Value = data.ElementAt(i).GetDate;
                datagridview.Rows[j].Cells[1].Value = data.ElementAt(i).GetEnvironmentalAuthority;
                datagridview.Rows[j].Cells[2].Value = data.ElementAt(i).GetStationName;
                datagridview.Rows[j].Cells[3].Value = data.ElementAt(i).GetTechnology;
                datagridview.Rows[j].Cells[4].Value = data.ElementAt(i).GetLatitude;
                datagridview.Rows[j].Cells[5].Value = data.ElementAt(i).GetLongitude;
                datagridview.Rows[j].Cells[6].Value = data.ElementAt(i).GetDepartmentCode;
                datagridview.Rows[j].Cells[7].Value = data.ElementAt(i).GetDepartmentName;
                datagridview.Rows[j].Cells[8].Value = data.ElementAt(i).GetMunicipalityCode;
                datagridview.Rows[j].Cells[9].Value = data.ElementAt(i).GetMunicipalityName;
                datagridview.Rows[j].Cells[10].Value = data.ElementAt(i).GetTypeofStation;
                datagridview.Rows[j].Cells[11].Value = data.ElementAt(i).GetExhibitionTime;
                datagridview.Rows[j].Cells[12].Value = data.ElementAt(i).GetVariable;
                datagridview.Rows[j].Cells[13].Value = data.ElementAt(i).GetUnits;
                datagridview.Rows[j].Cells[14].Value = data.ElementAt(i).GetConcentration;
            }

            datagridview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            datagridview.Location = new Point(25, 50);
            datagridview.Size = new Size(950, 250);
            datagridview.AllowUserToAddRows = false;

            this.Controls.Add(datagridview);
            datagridview.Show();
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
