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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DataReader));
            this.dataview = new System.Windows.Forms.ListView();
            this.columnsfilter = new System.Windows.Forms.ComboBox();
            this.selectcolumn = new System.Windows.Forms.Label();
            this.limit = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.selectlimit = new System.Windows.Forms.Label();
            this.selectamount = new System.Windows.Forms.Label();
            this.withcondition = new System.Windows.Forms.Label();
            this.condition = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.value = new System.Windows.Forms.TextBox();
            this.filter = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // dataview
            // 
            this.dataview.HideSelection = false;
            this.dataview.Location = new System.Drawing.Point(12, 167);
            this.dataview.Name = "dataview";
            this.dataview.Size = new System.Drawing.Size(1102, 372);
            this.dataview.TabIndex = 0;
            this.dataview.UseCompatibleStateImageBehavior = false;
            // 
            // columnsfilter
            // 
            this.columnsfilter.FormattingEnabled = true;
            this.columnsfilter.Items.AddRange(new object[] {
            "Fecha",
            "Autoridad ambiental",
            "Nombre de la estacion",
            "Tecnologia",
            "Latitud",
            "Longitud",
            "Codigo de departamento",
            "Nombre de departamento",
            "Codigo de municipio",
            "Nombre de municipio",
            "Tipo de estacion",
            "Tiempo de exhibicion",
            "Variable",
            "Unidades",
            "Concentracion"});
            this.columnsfilter.Location = new System.Drawing.Point(897, 68);
            this.columnsfilter.Name = "columnsfilter";
            this.columnsfilter.Size = new System.Drawing.Size(121, 21);
            this.columnsfilter.TabIndex = 1;
            // 
            // selectcolumn
            // 
            this.selectcolumn.AutoSize = true;
            this.selectcolumn.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectcolumn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectcolumn.Location = new System.Drawing.Point(772, 67);
            this.selectcolumn.Name = "selectcolumn";
            this.selectcolumn.Size = new System.Drawing.Size(110, 23);
            this.selectcolumn.TabIndex = 2;
            this.selectcolumn.Text = "Select Column";
            // 
            // limit
            // 
            this.limit.Location = new System.Drawing.Point(349, 69);
            this.limit.Name = "limit";
            this.limit.Size = new System.Drawing.Size(100, 20);
            this.limit.TabIndex = 3;
            // 
            // amount
            // 
            this.amount.Location = new System.Drawing.Point(121, 69);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(100, 20);
            this.amount.TabIndex = 4;
            // 
            // selectlimit
            // 
            this.selectlimit.AutoSize = true;
            this.selectlimit.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectlimit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectlimit.Location = new System.Drawing.Point(262, 66);
            this.selectlimit.Name = "selectlimit";
            this.selectlimit.Size = new System.Drawing.Size(81, 23);
            this.selectlimit.TabIndex = 5;
            this.selectlimit.Text = "Enter Limit";
            // 
            // selectamount
            // 
            this.selectamount.AutoSize = true;
            this.selectamount.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectamount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectamount.Location = new System.Drawing.Point(12, 66);
            this.selectamount.Name = "selectamount";
            this.selectamount.Size = new System.Drawing.Size(103, 23);
            this.selectamount.TabIndex = 6;
            this.selectamount.Text = "Enter Amount";
            // 
            // withcondition
            // 
            this.withcondition.AutoSize = true;
            this.withcondition.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withcondition.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.withcondition.Location = new System.Drawing.Point(507, 67);
            this.withcondition.Name = "withcondition";
            this.withcondition.Size = new System.Drawing.Size(106, 23);
            this.withcondition.TabIndex = 7;
            this.withcondition.Text = "With condition";
            // 
            // condition
            // 
            this.condition.FormattingEnabled = true;
            this.condition.Items.AddRange(new object[] {
            "Less than",
            "Equals",
            "Bigger than"});
            this.condition.Location = new System.Drawing.Point(619, 68);
            this.condition.Name = "condition";
            this.condition.Size = new System.Drawing.Size(121, 21);
            this.condition.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Narrow", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(562, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 23);
            this.label1.TabIndex = 9;
            this.label1.Text = "Value";
            // 
            // value
            // 
            this.value.Location = new System.Drawing.Point(619, 108);
            this.value.Name = "value";
            this.value.Size = new System.Drawing.Size(100, 20);
            this.value.TabIndex = 10;
            // 
            // filter
            // 
            this.filter.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.filter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.filter.Location = new System.Drawing.Point(840, 105);
            this.filter.Name = "filter";
            this.filter.Size = new System.Drawing.Size(128, 40);
            this.filter.TabIndex = 11;
            this.filter.Text = "FILTER";
            this.filter.UseVisualStyleBackColor = true;
            this.filter.Click += new System.EventHandler(this.filter_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial Rounded MT Bold", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.title.Location = new System.Drawing.Point(434, 9);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(196, 24);
            this.title.TabIndex = 12;
            this.title.Text = "Data Requestment";
            // 
            // DataReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.ClientSize = new System.Drawing.Size(1126, 551);
            this.Controls.Add(this.title);
            this.Controls.Add(this.filter);
            this.Controls.Add(this.value);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.condition);
            this.Controls.Add(this.withcondition);
            this.Controls.Add(this.selectamount);
            this.Controls.Add(this.selectlimit);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.limit);
            this.Controls.Add(this.selectcolumn);
            this.Controls.Add(this.columnsfilter);
            this.Controls.Add(this.dataview);
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataReader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListView dataview;
        private System.Windows.Forms.ComboBox columnsfilter;
        private System.Windows.Forms.Label selectcolumn;
        private System.Windows.Forms.TextBox limit;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label selectlimit;
        private System.Windows.Forms.Label selectamount;
        private System.Windows.Forms.Label withcondition;
        private System.Windows.Forms.ComboBox condition;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox value;
        private System.Windows.Forms.Button filter;
        private System.Windows.Forms.Label title;
    }
}

