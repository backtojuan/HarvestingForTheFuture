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
            this.image = new System.Windows.Forms.FlowLayoutPanel();
            this.splitContainer1 = new System.Windows.Forms.SplitContainer();
            this.description = new System.Windows.Forms.FlowLayoutPanel();
            this.actualice = new System.Windows.Forms.Button();
            this.ir = new System.Windows.Forms.Button();
            this.departamentos = new System.Windows.Forms.ComboBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.image.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).BeginInit();
            this.splitContainer1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // image
            // 
            this.image.BackColor = System.Drawing.Color.White;
            this.image.Controls.Add(this.splitContainer1);
            this.image.Location = new System.Drawing.Point(41, 166);
            this.image.Name = "image";
            this.image.Size = new System.Drawing.Size(288, 200);
            this.image.TabIndex = 2;
            this.image.Paint += new System.Windows.Forms.PaintEventHandler(this.image_Paint);
            // 
            // splitContainer1
            // 
            this.splitContainer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer1.Location = new System.Drawing.Point(3, 3);
            this.splitContainer1.Name = "splitContainer1";
            this.splitContainer1.Size = new System.Drawing.Size(150, 0);
            this.splitContainer1.TabIndex = 0;
            // 
            // description
            // 
            this.description.BackColor = System.Drawing.Color.White;
            this.description.Location = new System.Drawing.Point(389, 166);
            this.description.Name = "description";
            this.description.Size = new System.Drawing.Size(362, 200);
            this.description.TabIndex = 3;
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
            // departamentos
            // 
            this.departamentos.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.departamentos.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.departamentos.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.RecentlyUsedList;
            this.departamentos.BackColor = System.Drawing.Color.White;
            this.departamentos.CausesValidation = false;
            this.departamentos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.departamentos.Font = new System.Drawing.Font("Constantia", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.departamentos.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(21)))), ((int)(((byte)(72)))), ((int)(((byte)(84)))));
            this.departamentos.FormattingEnabled = true;
            this.departamentos.Items.AddRange(new object[] {
            "Antioquia",
            "Boyaca",
            "Cesar",
            "Choco",
            "Cundinamarca",
            "La Guagira",
            "Magdalena",
            "Meta",
            "Santander",
            "Tolima",
            "Valle del Cauca"});
            this.departamentos.Location = new System.Drawing.Point(389, 93);
            this.departamentos.Margin = new System.Windows.Forms.Padding(30, 45, 6, 3);
            this.departamentos.MaxDropDownItems = 4;
            this.departamentos.Name = "departamentos";
            this.departamentos.Size = new System.Drawing.Size(362, 50);
            this.departamentos.TabIndex = 0;
            this.departamentos.Text = "Departamento";
            this.departamentos.SelectedIndexChanged += new System.EventHandler(this.departamentos_SelectedIndexChanged);
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
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.departamentos);
            this.Controls.Add(this.ir);
            this.Controls.Add(this.actualice);
            this.Controls.Add(this.description);
            this.Controls.Add(this.image);
            this.Name = "FirstPage";
            this.Text = "FirstPage";
            this.image.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer1)).EndInit();
            this.splitContainer1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.FlowLayoutPanel image;
        private System.Windows.Forms.FlowLayoutPanel description;
        private System.Windows.Forms.Button actualice;
        private System.Windows.Forms.Button ir;
        private System.Windows.Forms.SplitContainer splitContainer1;
        private System.Windows.Forms.ComboBox departamentos;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}