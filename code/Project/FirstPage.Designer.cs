namespace Project
{
    partial class Form1
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
            this.ActualizeDB = new System.Windows.Forms.Button();
            this.departamentCmb = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Association = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ActualizeDB
            // 
            this.ActualizeDB.Location = new System.Drawing.Point(33, 396);
            this.ActualizeDB.Name = "ActualizeDB";
            this.ActualizeDB.Size = new System.Drawing.Size(158, 23);
            this.ActualizeDB.TabIndex = 0;
            this.ActualizeDB.Text = "Actualizar Base de Datos";
            this.ActualizeDB.UseVisualStyleBackColor = true;
            this.ActualizeDB.Click += new System.EventHandler(this.ActualizeDB_Click);
            // 
            // departamentCmb
            // 
            this.departamentCmb.FormattingEnabled = true;
            this.departamentCmb.Location = new System.Drawing.Point(33, 90);
            this.departamentCmb.Name = "departamentCmb";
            this.departamentCmb.Size = new System.Drawing.Size(236, 21);
            this.departamentCmb.TabIndex = 1;
            this.departamentCmb.SelectedIndexChanged += new System.EventHandler(this.departamentCmb_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(96, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(74, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Departamento";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Association);
            this.panel1.Location = new System.Drawing.Point(372, 45);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(371, 349);
            this.panel1.TabIndex = 3;
            // 
            // Association
            // 
            this.Association.Location = new System.Drawing.Point(226, 276);
            this.Association.Name = "Association";
            this.Association.Size = new System.Drawing.Size(75, 23);
            this.Association.TabIndex = 0;
            this.Association.Text = "Ir";
            this.Association.UseVisualStyleBackColor = true;
            this.Association.Click += new System.EventHandler(this.Association_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.departamentCmb);
            this.Controls.Add(this.ActualizeDB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ActualizeDB;
        private System.Windows.Forms.ComboBox departamentCmb;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button Association;
    }
}

