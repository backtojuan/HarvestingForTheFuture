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
        private double latInitial = 3.4372201;
        private double longInitial = -76.5224991;

        public UserControl1()
        {
            InitializeComponent();
            
        }


        /*
         * Carga la pagina UserControl
         * crea las columnas de la tabla para el dataGridView y
         * carga la lista de los cultivos 
         */
        public void LoadPage(ConsolidatedPage consolidated)
        {
            ConsolidatedPage = consolidated;
            test();

        }

        public void test()
        {
            table = new DataTable();
            table.Columns.Add(new DataColumn("Posicion", typeof(int)));
            table.Columns.Add(new DataColumn("Nombre", typeof(String)));
            table.Columns.Add(new DataColumn("Compatibilidad", typeof(double)));
            AddToDataGridView(1, "Papa", 90);
            AddToDataGridView(2, "Tomate", 85);
            AddToDataGridView(3, "Trigo", 70);

            dataGridView.DataSource = table;
        }

        public void AddToDataGridView(int pos, String name, double Comp)
        {
            table.Rows.Add(pos, name, Comp);
        }

        public void SetHarvestingLabel(String harverting)
        {
            harvestingLabel.Text = harverting;
        }

        private void descriptionDep_Click(object sender, EventArgs e)
        {
            //borrar - error
        }

        private void gMapControl1_Load(object sender, EventArgs e)
        {
            

            gMapControl1.MapProvider = GMapProviders.GoogleMap;
            gMapControl1.Position = new PointLatLng(latInitial, longInitial);
            gMapControl1.MinZoom = 0;
            gMapControl1.MaxZoom = 24;
            gMapControl1.Zoom = 9;
            gMapControl1.AutoScroll = true;

            //Marcador
            markerOverlay = new GMapOverlay("Marcador");
            marker = new GMarkerGoogle(new PointLatLng(latInitial, longInitial), GMarkerGoogleType.green);
            markerOverlay.Markers.Add(marker);//Agregarlo al mapa

            //Agregar un tooltip de texto a los marcadores
            marker.ToolTipMode = MarkerTooltipMode.Always;
            marker.ToolTipText = String.Format("Ubicación: \n Latitud:{0} \n Longitud: {1}", latInitial, longInitial) + "\n Compatibilidad: 90%";

            //Agregar el marcador al map control
            gMapControl1.Overlays.Add(markerOverlay);
        }

        private void dataGridView_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (this.dataGridView.Columns[e.ColumnIndex].Name == "Compatibilidad")
            {
                if (Convert.ToInt32(e.Value) >= 90)
                {
                    e.CellStyle.ForeColor = Color.DarkGreen;
                    e.CellStyle.BackColor = Color.GreenYellow;
                }
            }
        }

        private void HarvestingSelect(object sender, DataGridViewCellMouseEventArgs e)
        {
            int rowSelected = e.RowIndex;
            String Harvesting = dataGridView.Rows[rowSelected].Cells[1].Value.ToString();
            harvestingLabel.Text = Harvesting;
            //metodo para cargar la info
            ConsolidatedPage.ShowInfoHarvesting(Harvesting);

        }
    }
}
