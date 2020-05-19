namespace project_gui
{
    partial class FirstPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstPage));
            this.actualice = new System.Windows.Forms.Button();
            this.ir = new System.Windows.Forms.Button();
            this.departmentsCmb = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.desciptionLabel = new System.Windows.Forms.Label();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // actualice
            // 
            this.actualice.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.actualice.BackColor = System.Drawing.Color.White;
            this.actualice.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.actualice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.actualice.Font = new System.Drawing.Font("Constantia", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.actualice.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.actualice.Location = new System.Drawing.Point(41, 379);
            this.actualice.Name = "actualice";
            this.actualice.Size = new System.Drawing.Size(160, 61);
            this.actualice.TabIndex = 4;
            this.actualice.Text = "Actualizar base de datos";
            this.actualice.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.actualice.UseVisualStyleBackColor = false;
            this.actualice.Click += new System.EventHandler(this.actualice_Click);
            // 
            // ir
            // 
            this.ir.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ir.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ir.BackColor = System.Drawing.Color.White;
            this.ir.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ir.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ir.Font = new System.Drawing.Font("Constantia", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ir.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.ir.Location = new System.Drawing.Point(637, 385);
            this.ir.Margin = new System.Windows.Forms.Padding(10, 20, 3, 3);
            this.ir.Name = "ir";
            this.ir.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ir.Size = new System.Drawing.Size(89, 51);
            this.ir.TabIndex = 5;
            this.ir.Text = "Ver";
            this.ir.UseVisualStyleBackColor = false;
            this.ir.Click += new System.EventHandler(this.ir_Click);
            // 
            // departmentsCmb
            // 
            this.departmentsCmb.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departmentsCmb.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.departmentsCmb.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.departmentsCmb.BackColor = System.Drawing.Color.White;
            this.departmentsCmb.CausesValidation = false;
            this.departmentsCmb.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departmentsCmb.Font = new System.Drawing.Font("Constantia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departmentsCmb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.departmentsCmb.FormattingEnabled = true;
            this.departmentsCmb.Location = new System.Drawing.Point(389, 93);
            this.departmentsCmb.Margin = new System.Windows.Forms.Padding(30, 45, 6, 3);
            this.departmentsCmb.MaxDropDownItems = 4;
            this.departmentsCmb.Name = "departmentsCmb";
            this.departmentsCmb.Size = new System.Drawing.Size(362, 50);
            this.departmentsCmb.TabIndex = 0;
            this.departmentsCmb.Text = "Departamento";
            this.departmentsCmb.SelectedIndexChanged += new System.EventHandler(this.departments_SelectedIndexChanged);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(59, -1);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(75, 4, 4, 4);
            this.pictureBox1.MaximumSize = new System.Drawing.Size(300, 200);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(255, 144);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(754, 379);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(34, 61);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // desciptionLabel
            // 
            this.desciptionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.desciptionLabel.Location = new System.Drawing.Point(377, 172);
            this.desciptionLabel.Name = "desciptionLabel";
            this.desciptionLabel.Size = new System.Drawing.Size(389, 193);
            this.desciptionLabel.TabIndex = 8;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Location = new System.Drawing.Point(41, 172);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(273, 175);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 9;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.desciptionLabel);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.departmentsCmb);
            this.Controls.Add(this.ir);
            this.Controls.Add(this.actualice);
            this.Name = "FirstPage";
            this.Text = "FirstPage";
            this.Load += new System.EventHandler(this.FirstPage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button actualice;
        private System.Windows.Forms.Button ir;
        private System.Windows.Forms.ComboBox departmentsCmb;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label desciptionLabel;
        private System.Windows.Forms.PictureBox pictureBox3;
    }
}