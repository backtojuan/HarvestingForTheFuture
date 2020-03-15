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
            user.Load(0, 0, "");
            
            List<Data> data = user.GetData();

            foreach (Data row in data)
            {
                ListViewItem List = new ListViewItem(row.GetDate);
                List.SubItems.Add(row.GetEnvironmentalAuthority);
                List.SubItems.Add(row.GetStationName);
                List.SubItems.Add(row.GetTechnology);
                List.SubItems.Add(row.GetLatitude);
                List.SubItems.Add(row.GetLongitude);
                List.SubItems.Add(row.GetDepartmentCode);
                List.SubItems.Add(row.GetDepartmentName);
                List.SubItems.Add(row.GetMunicipalityCode);
                List.SubItems.Add(row.GetMunicipalityName);
                List.SubItems.Add(row.GetTypeofStation);
                List.SubItems.Add(row.GetExhibitionTime);
                List.SubItems.Add(row.GetVariable);
                List.SubItems.Add(row.GetUnits);
                List.SubItems.Add(row.GetConcentration);

                dataview.Items.Add(List);
            }
        }
    }
}
