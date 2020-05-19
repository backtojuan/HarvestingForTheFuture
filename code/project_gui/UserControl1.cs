using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
    public partial class UserControl1 : UserControl
    {
        private DataTable table;

        private ConsolidatedPage ConsolidatedPage;

        private GMarkerGoogle marker;
        private GMapOverlay markerOverlay;
        private double latitude;
        private double longitude;

        public UserControl1()
        {
            InitializeComponent();
            
        }


        /*
         * Carga la pagina UserControl
         * crea las columnas de la tabla para el dataGridView y
         * carga la lista de los cultivos 
         */
        public void LoadPage(ConsolidatedPage consolidated, double lat, double lon)
        {
            ConsolidatedPage = consolidated;
            latitude = lat;
            longitude = lon;
            table = new DataTable();
            table.Columns.Add(new DataColumn("Posicion", typeof(int)));
            table.Columns.Add(new DataColumn("Nombre", typeof(String)));
            table.Columns.Add(new DataColumn("Compatibilidad", typeof(double)));
        }


        //Data Grid view
        public void AddToDataGridView(int pos, String name, double Comp)
        {
            table.Rows.Add(pos, name, 100*Comp);
            dataGridView.DataSource = table;
        }

        //Humidity Relative
        public void AddPointInHumidityDep(double x, double y)
        {
            HumidChart.Series["Departamento"].Points.AddXY(x, y);
        }
        public void AddPointInHumidityMinHarv(double x, double y)
        {
            HumidChart.Series["Cultivo Min"].Points.AddXY(x, y);
        }

        public void AddPointInHumidityMaxHarv(double x, double y)
        {
            HumidChart.Series["Cultivo Max"].Points.AddXY(x, y);
        }

        //Temperature 
        public void AddPointInTemperatureDep(double x, double y)
        {
            TempChart.Series["Departamento"].Points.AddXY(x, y);
        }

        public void AddPointInTemperatureMaxHar(double x, double y)
        {
            TempChart.Series["Cultivo Max"].Points.AddXY(x, y);
        }

        public void AddPointInTemperatureMinHar(double x, double y)
        {
            TempChart.Series["Cultivo Min"].Points.AddXY(x, y);
        }

        //Liquid precipitation
        public void AddPointInLiquidPrecDep(double x, double y)
        {
            LiquidChart.Series["Departamento"].Points.AddXY(x, y);
        }

        public void AddPointInLiquidPrecHar(double x, double y)
        {
            LiquidChart.Series["Cultivo"].Points.AddXY(x, y);
        }

        //Wind Speed
        public void AddPointInWindSpeedDep(double x, double y)
        {
            WindChart.Series["Departamento"].Points.AddXY(x, y);
        }

        public void AddPointInWindSpeedcHar(double x, double y)
        {
            WindChart.Series["Cultivo"].Points.AddXY(x, y);
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {

            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(latitude, longitude);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            //Marcador
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(latitude, longitude), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);//Agregarlo al mapa

            //Agregar un tooltip de texto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = String.Format("Ubicación: \n Latitud:{0} \n Longitud: {1}", latitude, longitude);

            //Agregar el marcador al map control
            gMapControl1.Overlays.Add(markerOverlay);
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView.Columns[e.ColumnIndex].Name == "Compatibilidad")
            {
                if (Convert.ToDouble(e.Value) >= 0)
                {
                    //e.CellStyle.ForeColor = Color.DarkGreen;
                    e.CellStyle.BackColor = Color.Red;
                }
                if (Convert.ToDouble(e.Value) >= 10)
                {
                    //e.CellStyle.ForeColor = Color.DarkGreen;
                    e.CellStyle.BackColor = Color.OrangeRed;
                }
                if (Convert.ToDouble(e.Value) >= 20)
                {
                    //e.CellStyle.ForeColor = Color.DarkGreen;
                    e.CellStyle.BackColor = Color.Orange;
                }
                if (Convert.ToDouble(e.Value) >= 35)
                {
                    //e.CellStyle.ForeColor = Color.DarkGreen;
                    e.CellStyle.BackColor = Color.Yellow;
                }
                if (Convert.ToDouble(e.Value) >= 60)
                {
                    //e.CellStyle.ForeColor = Color.DarkGreen;
                    e.CellStyle.BackColor = Color.YellowGreen;
                }

                if (Convert.ToDouble(e.Value) >= 70)
                {
                    //e.CellStyle.ForeColor = Color.DarkGreen;
                    e.CellStyle.BackColor = Color.GreenYellow;
                }

                if (Convert.ToDouble(e.Value) >= 85)
                {
                    //e.CellStyle.ForeColor = Color.DarkGreen;
                    e.CellStyle.BackColor = Color.Green;
                }
            }
        }

        private void HarvestingSelect(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowSelected = Convert.ToInt32(dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString());
            String Harvesting = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
            harvestingLabel.Text = Harvesting;

            HumidChart.Series["Departamento"].Points.Clear();
            HumidChart.Series["Cultivo Min"].Points.Clear();
            HumidChart.Series["Cultivo Max"].Points.Clear();

            TempChart.Series["Departamento"].Points.Clear();
            TempChart.Series["Cultivo Max"].Points.Clear();
            TempChart.Series["Cultivo Min"].Points.Clear();

            LiquidChart.Series["Departamento"].Points.Clear();
            LiquidChart.Series["Cultivo"].Points.Clear();


            WindChart.Series["Departamento"].Points.Clear();
            WindChart.Series["Cultivo"].Points.Clear();

            ConsolidatedPage.ShowInfoHarvesting(Harvesting, rowSelected-1);

        }
    }
}
