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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.gMapControl1 = new GMap.NET.WindowsForms.GMapControl();
            this.harvestingLabel = new System.Windows.Forms.Label();
            this.descriptionDep = new System.Windows.Forms.Label();
            this.descriptionHar = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
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
            this.gMapControl1.Location = new System.Drawing.Point(87, 268);
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
            this.gMapControl1.Size = new System.Drawing.Size(717, 344);
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
            this.harvestingLabel.Location = new System.Drawing.Point(429, 19);
            this.harvestingLabel.Name = "harvestingLabel";
            this.harvestingLabel.Size = new System.Drawing.Size(140, 47);
            this.harvestingLabel.TabIndex = 11;
            this.harvestingLabel.Text = "Cultivo";
            // 
            // descriptionDep
            // 
            this.descriptionDep.AccessibleDescription = "descriptionDep";
            this.descriptionDep.AccessibleName = "descriptionDep";
            this.descriptionDep.Font = new System.Drawing.Font("Calibri", 15F);
            this.descriptionDep.Location = new System.Drawing.Point(18, 19);
            this.descriptionDep.Name = "descriptionDep";
            this.descriptionDep.Size = new System.Drawing.Size(405, 187);
            this.descriptionDep.TabIndex = 10;
            this.descriptionDep.Text = "Descripción del departamento";
            this.descriptionDep.Click += new System.EventHandler(this.descriptionDep_Click);
            // 
            // descriptionHar
            // 
            this.descriptionHar.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionHar.Location = new System.Drawing.Point(433, 66);
            this.descriptionHar.Name = "descriptionHar";
            this.descriptionHar.Size = new System.Drawing.Size(427, 171);
            this.descriptionHar.TabIndex = 9;
            this.descriptionHar.Text = "Descripción del cultivo";
            // 
            // dataGridView
            // 
            this.dataGridView.BackgroundColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(87, 636);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.Size = new System.Drawing.Size(717, 337);
            this.dataGridView.TabIndex = 12;
            // 
            // UserControl1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.harvestingLabel);
            this.Controls.Add(this.descriptionDep);
            this.Controls.Add(this.descriptionHar);
            this.Controls.Add(this.gMapControl1);
            this.Name = "UserControl1";
            this.Size = new System.Drawing.Size(898, 1000);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private GMap.NET.WindowsForms.GMapControl gMapControl1;
        private System.Windows.Forms.Label harvestingLabel;
        private System.Windows.Forms.Label descriptionDep;
        private System.Windows.Forms.Label descriptionHar;
        private System.Windows.Forms.DataGridView dataGridView;
    }
}
