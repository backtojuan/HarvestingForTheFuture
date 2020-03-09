namespace gui
{
    partial class DataReader
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

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.Consulta = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Consulta
            // 
            this.Consulta.AutoSize = true;
            this.Consulta.BackColor = System.Drawing.SystemColors.Control;
            this.Consulta.Location = new System.Drawing.Point(58, 36);
            this.Consulta.Name = "Consulta";
            this.Consulta.Size = new System.Drawing.Size(47, 13);
            this.Consulta.TabIndex = 0;
            this.Consulta.Text = "consulta";
            // 
            // DataReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Consulta);
            this.Name = "DataReader";
            this.Text = "DataReader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Consulta;
    }
}

