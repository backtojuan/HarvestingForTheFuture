using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using GMap.NET;
using GMap.NET.MapProviders;
using GMap.NET.WindowsForms;
using GMap.NET.WindowsForms.Markers;


namespace project_gui
{
    public partial class ConsolidatedPage : Form
    {
        private GMarkerGoogle marker;
        private GMapOverlay mapOverlay;
        private double latInitial = 3.4372201;
        private double longInitial = -76.5224991;

        public ConsolidatedPage()
        {
            InitializeComponent();
        }

        public void loadPage()
        {

        }

        private void harvestingCmb_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(latInitial, longInitial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;
        }

    }
}
