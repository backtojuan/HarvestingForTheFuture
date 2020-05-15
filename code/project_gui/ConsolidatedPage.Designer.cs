namespace project_gui
{
    partial class ConsolidatedPage
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsolidatedPage));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.harvestingCmb = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.departmentLabel = new System.Windows.Forms.Label();
            this.descriptionHar = new System.Windows.Forms.Label();
            this.descriptionDep = new System.Windows.Forms.Label();
            this.harvestingLabel = new System.Windows.Forms.Label();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1080, 26);
            this.panel1.TabIndex = 0;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.panel2.Controls.Add(this.harvestingCmb);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(0, 26);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(291, 683);
            this.panel2.TabIndex = 1;
            // 
            // harvestingCmb
            // 
            this.harvestingCmb.AccessibleDescription = "descriptionHar";
            this.harvestingCmb.AccessibleName = "descriptionHar";
            this.harvestingCmb.Font = new System.Drawing.Font("Adobe Gothic Std B", 23.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.harvestingCmb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.harvestingCmb.FormattingEnabled = true;
            this.harvestingCmb.Location = new System.Drawing.Point(32, 167);
            this.harvestingCmb.Name = "harvestingCmb";
            this.harvestingCmb.Size = new System.Drawing.Size(234, 47);
            this.harvestingCmb.TabIndex = 4;
            this.harvestingCmb.Text = "Cultivo";
            this.harvestingCmb.SelectedIndexChanged += new System.EventHandler(this.harvestingCmb_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.ErrorImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.ErrorImage")));
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(279, 143);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(965, 563);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(28, 78);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 2;
            this.pictureBox2.TabStop = false;
            // 
            // departmentLabel
            // 
            this.departmentLabel.AccessibleDescription = "departmentLabel";
            this.departmentLabel.AccessibleName = "departmentLabel";
            this.departmentLabel.AutoSize = true;
            this.departmentLabel.Font = new System.Drawing.Font("Adobe Gothic Std B", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.departmentLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.departmentLabel.Location = new System.Drawing.Point(478, 44);
            this.departmentLabel.Name = "departmentLabel";
            this.departmentLabel.Size = new System.Drawing.Size(348, 60);
            this.departmentLabel.TabIndex = 3;
            this.departmentLabel.Text = "Departamento";
            // 
            // descriptionHar
            // 
            this.descriptionHar.Font = new System.Drawing.Font("Calibri", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionHar.Location = new System.Drawing.Point(658, 183);
            this.descriptionHar.Name = "descriptionHar";
            this.descriptionHar.Size = new System.Drawing.Size(311, 142);
            this.descriptionHar.TabIndex = 4;
            this.descriptionHar.Text = "Descripción del cultivo";
            // 
            // descriptionDep
            // 
            this.descriptionDep.AccessibleDescription = "descriptionDep";
            this.descriptionDep.AccessibleName = "descriptionDep";
            this.descriptionDep.Font = new System.Drawing.Font("Calibri", 15F);
            this.descriptionDep.Location = new System.Drawing.Point(318, 138);
            this.descriptionDep.Name = "descriptionDep";
            this.descriptionDep.Size = new System.Drawing.Size(295, 187);
            this.descriptionDep.TabIndex = 5;
            this.descriptionDep.Text = "Descripción del departamento";
            // 
            // harvestingLabel
            // 
            this.harvestingLabel.AccessibleDescription = "harvestingLabel";
            this.harvestingLabel.AccessibleName = "harvestingLabel";
            this.harvestingLabel.AutoSize = true;
            this.harvestingLabel.Font = new System.Drawing.Font("Adobe Gothic Std B", 27.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(128)));
            this.harvestingLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.harvestingLabel.Location = new System.Drawing.Point(686, 122);
            this.harvestingLabel.Name = "harvestingLabel";
            this.harvestingLabel.Size = new System.Drawing.Size(140, 47);
            this.harvestingLabel.TabIndex = 6;
            this.harvestingLabel.Text = "Cultivo";

            // 
            // ConsolidatedPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1080, 709);
            this.Controls.Add(this.harvestingLabel);
            this.Controls.Add(this.descriptionDep);
            this.Controls.Add(this.descriptionHar);
            this.Controls.Add(this.departmentLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ConsolidatedPage";
            this.Text = "ConsolidatedPage";
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label department_label;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label departmentLabel;
        private System.Windows.Forms.ComboBox harvestingCmb;
        private System.Windows.Forms.Label descriptionHar;
        private System.Windows.Forms.Label descriptionDep;
        private System.Windows.Forms.Label harvestingLabel;
    }
}