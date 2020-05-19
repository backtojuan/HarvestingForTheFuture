namespace project_gui
{
    partial class UserControl1
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series11 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series12 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series13 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series14 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series15 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series16 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series17 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series18 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series19 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.Series series20 = new System.Windows.Forms.DataVisualization.Charting.Series();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.harvestingLabel = new System.Windows.Forms.Label();
            this.HumidChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.TempChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.LiquidChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.WindChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.HumidChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiquidChart)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindChart)).BeginInit();
            this.SuspendLayout();
            // 
            // gMapControl1
            // 
            this.gMapControl1.Bearing = 0F;
            this.gMapControl1.CanDragMap = true;
            this.gMapControl1.EmptyTileColor = System.Drawing.Color.Navy;
            this.gMapControl1.GrayScaleMode = false;
            this.gMapControl1.HelperLineOption = GMap.NET.WindowsForms.HelperLineOptions.DontShow;
            this.gMapControl1.LevelsKeepInMemmory = 5;
            this.gMapControl1.Location = new System.Drawing.Point(23, 17);
            this.gMapControl1.MarkersEnabled = true;
            this.gMapControl1.MaxZoom = 2;
            this.gMapControl1.MinZoom = 2;
            this.gMapControl1.MouseWheelZoomEnabled = true;
            this.gMapControl1.MouseWheelZoomType = GMap.NET.MouseWheelZoomType.MousePositionAndCenter;
            this.gMapControl1.Name = "gMapControl1";
            this.gMapControl1.NegativeMode = false;
            this.gMapControl1.PolygonsEnabled = true;
            this.gMapControl1.RetryLoadTile = 0;
            this.gMapControl1.RoutesEnabled = true;
            this.gMapControl1.ScaleMode = GMap.NET.WindowsForms.ScaleModes.Integer;
            this.gMapControl1.SelectedAreaFillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(65)))), ((int)(((byte)(105)))), ((int)(((byte)(225)))));
            this.gMapControl1.ShowTileGridLines = false;
            this.gMapControl1.Size = new System.Drawing.Size(414, 288);
            this.gMapControl1.TabIndex = 8;
            this.gMapControl1.Zoom = 0D;
            this.gMapControl1.Load += new System.EventHandler(this.gMapControl1_Load);
            // 
            // harvestingLabel
            // 
            this.harvestingLabel.AccessibleDescription = "harvestingLabel";
            this.harvestingLabel.AccessibleName = "harvestingLabel";
            this.harvestingLabel.AutoSize = true;
            this.harvestingLabel.Font = new System.Drawing.Font("Adobe Gothic Std B", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.harvestingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.harvestingLabel.Location = new System.Drawing.Point(486, 17);
            this.harvestingLabel.Name = "harvestingLabel";
            this.harvestingLabel.Size = new System.Drawing.Size(140, 47);
            this.harvestingLabel.TabIndex = 11;
            this.harvestingLabel.Text = "Cultivo";
            // 
            // HumidChart
            // 
            chartArea5.Name = "ChartArea1";
            this.HumidChart.ChartAreas.Add(chartArea5);
            legend5.Name = "Legend1";
            this.HumidChart.Legends.Add(legend5);
            this.HumidChart.Location = new System.Drawing.Point(3, 370);
            this.HumidChart.Name = "HumidChart";
            this.HumidChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Bright;
            series11.ChartArea = "ChartArea1";
            series11.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series11.Legend = "Legend1";
            series11.Name = "Departamento";
            series12.ChartArea = "ChartArea1";
            series12.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series12.Legend = "Legend1";
            series12.Name = "Cultivo Max";
            series13.ChartArea = "ChartArea1";
            series13.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series13.Legend = "Legend1";
            series13.Name = "Cultivo Min";
            this.HumidChart.Series.Add(series11);
            this.HumidChart.Series.Add(series12);
            this.HumidChart.Series.Add(series13);
            this.HumidChart.Size = new System.Drawing.Size(434, 264);
            this.HumidChart.TabIndex = 12;
            this.HumidChart.Text = "Humedad Relativa";
            // 
            // TempChart
            // 
            chartArea6.Name = "ChartArea1";
            this.TempChart.ChartAreas.Add(chartArea6);
            legend6.Name = "Legend1";
            this.TempChart.Legends.Add(legend6);
            this.TempChart.Location = new System.Drawing.Point(443, 370);
            this.TempChart.Name = "TempChart";
            this.TempChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series14.ChartArea = "ChartArea1";
            series14.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series14.LabelBorderWidth = 5;
            series14.Legend = "Legend1";
            series14.MarkerBorderWidth = 2;
            series14.MarkerStep = 5;
            series14.Name = "Departamento";
            series15.ChartArea = "ChartArea1";
            series15.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series15.LabelBorderWidth = 5;
            series15.Legend = "Legend1";
            series15.Name = "Cultivo Max";
            series16.ChartArea = "ChartArea1";
            series16.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series16.Legend = "Legend1";
            series16.Name = "Cultivo Min";
            this.TempChart.Series.Add(series14);
            this.TempChart.Series.Add(series15);
            this.TempChart.Series.Add(series16);
            this.TempChart.Size = new System.Drawing.Size(434, 264);
            this.TempChart.TabIndex = 13;
            this.TempChart.Text = "Temperatura";
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(456, 67);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(393, 238);
            this.dataGridView.TabIndex = 16;
            this.dataGridView.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dataGridView_CellFormatting);
            this.dataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.HarvestingSelect);
            // 
            // LiquidChart
            // 
            chartArea7.Name = "ChartArea1";
            this.LiquidChart.ChartAreas.Add(chartArea7);
            legend7.Name = "Legend1";
            this.LiquidChart.Legends.Add(legend7);
            this.LiquidChart.Location = new System.Drawing.Point(0, 697);
            this.LiquidChart.Name = "LiquidChart";
            this.LiquidChart.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.Fire;
            series17.ChartArea = "ChartArea1";
            series17.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series17.Legend = "Legend1";
            series17.Name = "Departamento";
            series18.ChartArea = "ChartArea1";
            series18.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series18.Legend = "Legend1";
            series18.Name = "Cultivo";
            this.LiquidChart.Series.Add(series17);
            this.LiquidChart.Series.Add(series18);
            this.LiquidChart.Size = new System.Drawing.Size(437, 264);
            this.LiquidChart.TabIndex = 17;
            this.LiquidChart.Text = "Precipitación Liquida";
            // 
            // WindChart
            // 
            chartArea8.Name = "ChartArea1";
            this.WindChart.ChartAreas.Add(chartArea8);
            legend8.Name = "Legend1";
            this.WindChart.Legends.Add(legend8);
            this.WindChart.Location = new System.Drawing.Point(443, 697);
            this.WindChart.Name = "WindChart";
            series19.ChartArea = "ChartArea1";
            series19.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series19.Legend = "Legend1";
            series19.Name = "Departamento";
            series20.ChartArea = "ChartArea1";
            series20.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Line;
            series20.Legend = "Legend1";
            series20.Name = "Cultivo";
            this.WindChart.Series.Add(series19);
            this.WindChart.Series.Add(series20);
            this.WindChart.Size = new System.Drawing.Size(434, 264);
            this.WindChart.TabIndex = 18;
            this.WindChart.Text = "Velocidad del Viento";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Adobe Gothic Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.label1.Location = new System.Drawing.Point(72, 649);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(281, 34);
            this.label1.TabIndex = 19;
            this.label1.Text = "Precipitacion Liquida";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Adobe Gothic Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.label2.Location = new System.Drawing.Point(503, 649);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(275, 34);
            this.label2.TabIndex = 20;
            this.label2.Text = "Velocidad del Viento";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Adobe Gothic Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.label3.Location = new System.Drawing.Point(561, 333);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 34);
            this.label3.TabIndex = 21;
            this.label3.Text = "Temperatura";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Adobe Gothic Std B", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.label4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.label4.Location = new System.Drawing.Point(123, 333);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(247, 34);
            this.label4.TabIndex = 22;
            this.label4.Text = "Humedad Relativa";
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.WindChart);
            this.Controls.Add(this.LiquidChart);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.TempChart);
            this.Controls.Add(this.HumidChart);
            this.Controls.Add(this.gMapControl1);
            this.Controls.Add(this.harvestingLabel);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(883, 1094);
            ((System.ComponentModel.ISupportInitialize)(this.HumidChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TempChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LiquidChart)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.WindChart)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label harvestingLabel;
        private System.Windows.Forms.DataVisualization.Charting.Chart HumidChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart TempChart;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.DataVisualization.Charting.Chart LiquidChart;
        private System.Windows.Forms.DataVisualization.Charting.Chart WindChart;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}
