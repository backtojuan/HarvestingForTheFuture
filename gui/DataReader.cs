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
            initializelistview();
            User user = new User();
            user.Load(0, 0, "");
            
            List<Data> data = user.GetData();

            foreach (Data row in data)
            {
                dataview.Items.Add(new ListViewItem(new String[] { row.GetDate + "" + row.GetEnvironmentalAuthority + "" + row.GetStationName
                 + "" + row.GetTechnology + "" + row.GetLatitude + "" + row.GetLongitude + "" + row.GetDepartmentCode + "" +
                 row.GetDepartmentName + "" + row.GetMunicipalityCode + row.GetMunicipalityName + "" + row.GetTypeofStation
                 + "" + row.GetExhibitionTime + "" + row.GetVariable + "" + "" + row.GetUnits + "" + row.GetConcentration}));
            }
        }

        public void initializelistview() 
        {
            dataview.View = View.Details;
            dataview.Columns.Add("Date");
            dataview.Columns.Add("EnviromentalAuthority");
            dataview.Columns.Add("StationName");
            dataview.Columns.Add("Technology");
            dataview.Columns.Add("Latitude");
            dataview.Columns.Add("Longitude");
            dataview.Columns.Add("DepartmentCode");
            dataview.Columns.Add("DepartmentName");
            dataview.Columns.Add("MunicipalityCode");
            dataview.Columns.Add("MunicipalityName");
            dataview.Columns.Add("TypeofStation");
            dataview.Columns.Add("ExhibitionTime");
            dataview.Columns.Add("Variable");
            dataview.Columns.Add("Units");
            dataview.Columns.Add("Concentration");
            //dataview.AutoResizeColumns(ColumnHeaderAutoResizeStyle.HeaderSize);
            
        }

        private void filter_Click(object sender, EventArgs e)
        {

        }
    }
}
