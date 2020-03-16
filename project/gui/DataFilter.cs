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

        public DataFilter()
        {
            InitializeComponent();

            //Initialize a label tag
            Label label = new Label();
            label.Text = "DATA RESULTS";
            label.ForeColor = Color.White;
            label.Location = new Point(25,25);
            this.Controls.Add(label);
            label.Show();

            //initializes a button to close the form mandatory
            Button button = new Button();
            button.Text = "Accept";
            button.BackColor = Color.DarkGray;
            button.ForeColor = Color.Black;
            button.Location = new Point(150,20);
            button.Size = new Size(100, 25);
            button.Click += (sender, args) =>
            {
                this.Close();
            };
            this.Controls.Add(button);
            button.Show();
        }

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
            datagridview.Location = new Point(25,50);
            datagridview.Size = new Size(950,250);
            datagridview.AllowUserToAddRows = false;

            //this.Controls.Add(datagridview);
            //datagridview.Show();
        }

        public void FillDataListView(List<Data> data) 
        {
            data.Reverse();
            ListView dataview = new ListView();

            dataview.View = View.Details;

            dataview.Columns.Add("Date", "Date");
            dataview.Columns.Add("EnviromentalAuthority", "EnviromentalAuthority");
            dataview.Columns.Add("StationName", "StationName");
            dataview.Columns.Add("Technology", "Technology");
            dataview.Columns.Add("Latitude", "Latitude");
            dataview.Columns.Add("Longitude", "Longitude");
            dataview.Columns.Add("DepartmentCode", "DepartmentCode");
            dataview.Columns.Add("DepartmentName", "DepartmentName");
            dataview.Columns.Add("MunicipalityCode", "MunicipalityCode");
            dataview.Columns.Add("MunicipalityName", "MunicipalityName");
            dataview.Columns.Add("TypeofStation", "TypeofStation");
            dataview.Columns.Add("ExhibitionTime", "ExhibitionTime");
            dataview.Columns.Add("Variable", "Variable");
            dataview.Columns.Add("Units", "Units");
            dataview.Columns.Add("Concentration", "Concentration");


            foreach (Data row in data) 
            {
                ListViewItem list = new ListViewItem(row.GetDate);
                list.SubItems.Add(row.GetEnvironmentalAuthority);
                list.SubItems.Add(row.GetStationName);
                list.SubItems.Add(row.GetTechnology);
                list.SubItems.Add(row.GetLatitude);
                list.SubItems.Add(row.GetLongitude);
                list.SubItems.Add(row.GetDepartmentCode);
                list.SubItems.Add(row.GetDepartmentName);
                list.SubItems.Add(row.GetMunicipalityCode);
                list.SubItems.Add(row.GetMunicipalityName);
                list.SubItems.Add(row.GetTypeofStation);
                list.SubItems.Add(row.GetExhibitionTime);
                list.SubItems.Add(row.GetVariable);
                list.SubItems.Add(row.GetUnits);
                list.SubItems.Add(row.GetConcentration);

                dataview.Items.Add(list);
            }

            dataview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.ColumnContent);
            dataview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            dataview.Location = new Point(25,50);
            dataview.Size = new Size(950,250);
            dataview.BackColor = Color.DarkGray;
            dataview.ForeColor = Color.Black;

            this.Controls.Add(dataview);
            dataview.Show();
        }
    }
}
