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
            this.columnsfilter = new System.Windows.Forms.ComboBox();
            this.selectcolumn = new System.Windows.Forms.Label();
            this.limit = new System.Windows.Forms.TextBox();
            this.amount = new System.Windows.Forms.TextBox();
            this.selectlimit = new System.Windows.Forms.Label();
            this.selectamount = new System.Windows.Forms.Label();
            this.withcondition = new System.Windows.Forms.Label();
            this.latitudecondition = new System.Windows.Forms.ComboBox();
            this.val = new System.Windows.Forms.Label();
            this.enviromentalauthorityvalue = new System.Windows.Forms.TextBox();
            this.Filter = new System.Windows.Forms.Button();
            this.title = new System.Windows.Forms.Label();
            this.specifiedvaluefordate = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datevalue = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.specifiedvalueforenviromentalauthority = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.specifiedvalueforstationname = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.stationnamevalue = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.specifiedvalueforlatitude = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.latitudevalue = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.specifiedvalueforlongitude = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.longitudevalue = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.specifiedvaluefordepname = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.depnamevalue = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.specifiedvaluefortechnology = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.longitudecondition = new System.Windows.Forms.ComboBox();
            this.label14 = new System.Windows.Forms.Label();
            this.technologyvalue = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.specifiedvaluefordepcode = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.specifiedvalueformunname = new System.Windows.Forms.ComboBox();
            this.label18 = new System.Windows.Forms.Label();
            this.munnamevalue = new System.Windows.Forms.TextBox();
            this.label19 = new System.Windows.Forms.Label();
            this.specifiedvalueformuncode = new System.Windows.Forms.ComboBox();
            this.label20 = new System.Windows.Forms.Label();
            this.muncodevalue = new System.Windows.Forms.TextBox();
            this.label21 = new System.Windows.Forms.Label();
            this.specifiedvaluefortypeofstation = new System.Windows.Forms.ComboBox();
            this.label22 = new System.Windows.Forms.Label();
            this.typeofstationvalue = new System.Windows.Forms.TextBox();
            this.label23 = new System.Windows.Forms.Label();
            this.specifiedvalueforexhibitiontime = new System.Windows.Forms.ComboBox();
            this.label24 = new System.Windows.Forms.Label();
            this.exhibitiontimevalue = new System.Windows.Forms.TextBox();
            this.label25 = new System.Windows.Forms.Label();
            this.exhibitiontimecondition = new System.Windows.Forms.ComboBox();
            this.label26 = new System.Windows.Forms.Label();
            this.label27 = new System.Windows.Forms.Label();
            this.label28 = new System.Windows.Forms.Label();
            this.label29 = new System.Windows.Forms.Label();
            this.specifiedvalueforvariable = new System.Windows.Forms.ComboBox();
            this.specifiedvalueforunits = new System.Windows.Forms.ComboBox();
            this.specifiedvalueforconcentration = new System.Windows.Forms.ComboBox();
            this.depcodevalue = new System.Windows.Forms.TextBox();
            this.label30 = new System.Windows.Forms.Label();
            this.variablevalue = new System.Windows.Forms.TextBox();
            this.unitsvalue = new System.Windows.Forms.TextBox();
            this.concentrationvalue = new System.Windows.Forms.TextBox();
            this.label31 = new System.Windows.Forms.Label();
            this.label32 = new System.Windows.Forms.Label();
            this.label33 = new System.Windows.Forms.Label();
            this.concentrationcondition = new System.Windows.Forms.ComboBox();
            this.LoadandSave = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // columnsfilter
            // 
            this.columnsfilter.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.columnsfilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.columnsfilter.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.columnsfilter.ForeColor = System.Drawing.SystemColors.ControlText;
            this.columnsfilter.FormattingEnabled = true;
            this.columnsfilter.Items.AddRange(new object[] {
            "",
            "Date",
            "Enviromental authority",
            "Station name",
            "Technology",
            "Latitude",
            "Longitude",
            "Department code",
            "Department name",
            "Municipality code",
            "Municipality name",
            "Type of station",
            "Exhibition time",
            "Variable",
            "Units",
            "Concentration"});
            this.columnsfilter.Location = new System.Drawing.Point(770, 60);
            this.columnsfilter.Name = "columnsfilter";
            this.columnsfilter.Size = new System.Drawing.Size(121, 22);
            this.columnsfilter.TabIndex = 1;
            // 
            // selectcolumn
            // 
            this.selectcolumn.AutoSize = true;
            this.selectcolumn.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectcolumn.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectcolumn.Location = new System.Drawing.Point(530, 65);
            this.selectcolumn.Name = "selectcolumn";
            this.selectcolumn.Size = new System.Drawing.Size(219, 18);
            this.selectcolumn.TabIndex = 2;
            this.selectcolumn.Text = "Select just one column to show";
            // 
            // limit
            // 
            this.limit.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.limit.Enabled = false;
            this.limit.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.limit.ForeColor = System.Drawing.SystemColors.ControlText;
            this.limit.Location = new System.Drawing.Point(391, 62);
            this.limit.Name = "limit";
            this.limit.Size = new System.Drawing.Size(100, 20);
            this.limit.TabIndex = 3;
            // 
            // amount
            // 
            this.amount.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.amount.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.amount.ForeColor = System.Drawing.SystemColors.ControlText;
            this.amount.Location = new System.Drawing.Point(138, 62);
            this.amount.Name = "amount";
            this.amount.Size = new System.Drawing.Size(121, 20);
            this.amount.TabIndex = 4;
            // 
            // selectlimit
            // 
            this.selectlimit.AutoSize = true;
            this.selectlimit.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectlimit.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectlimit.Location = new System.Drawing.Point(292, 65);
            this.selectlimit.Name = "selectlimit";
            this.selectlimit.Size = new System.Drawing.Size(83, 18);
            this.selectlimit.TabIndex = 5;
            this.selectlimit.Text = "Enter Limit";
            // 
            // selectamount
            // 
            this.selectamount.AutoSize = true;
            this.selectamount.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.selectamount.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.selectamount.Location = new System.Drawing.Point(12, 65);
            this.selectamount.Name = "selectamount";
            this.selectamount.Size = new System.Drawing.Size(101, 18);
            this.selectamount.TabIndex = 6;
            this.selectamount.Text = "Enter Amount";
            // 
            // withcondition
            // 
            this.withcondition.AutoSize = true;
            this.withcondition.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.withcondition.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.withcondition.Location = new System.Drawing.Point(292, 201);
            this.withcondition.Name = "withcondition";
            this.withcondition.Size = new System.Drawing.Size(106, 18);
            this.withcondition.TabIndex = 7;
            this.withcondition.Text = "With condition";
            // 
            // latitudecondition
            // 
            this.latitudecondition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.latitudecondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.latitudecondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.latitudecondition.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudecondition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.latitudecondition.FormattingEnabled = true;
            this.latitudecondition.Items.AddRange(new object[] {
            "",
            "Less than",
            "Bigger than"});
            this.latitudecondition.Location = new System.Drawing.Point(418, 197);
            this.latitudecondition.Name = "latitudecondition";
            this.latitudecondition.Size = new System.Drawing.Size(121, 22);
            this.latitudecondition.TabIndex = 8;
            // 
            // val
            // 
            this.val.AutoSize = true;
            this.val.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.val.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.val.Location = new System.Drawing.Point(782, 113);
            this.val.Name = "val";
            this.val.Size = new System.Drawing.Size(47, 18);
            this.val.TabIndex = 9;
            this.val.Text = "Value";
            // 
            // enviromentalauthorityvalue
            // 
            this.enviromentalauthorityvalue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.enviromentalauthorityvalue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enviromentalauthorityvalue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.enviromentalauthorityvalue.Location = new System.Drawing.Point(849, 111);
            this.enviromentalauthorityvalue.Name = "enviromentalauthorityvalue";
            this.enviromentalauthorityvalue.Size = new System.Drawing.Size(100, 20);
            this.enviromentalauthorityvalue.TabIndex = 10;
            // 
            // Filter
            // 
            this.Filter.BackColor = System.Drawing.Color.Transparent;
            this.Filter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Filter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Filter.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Filter.Location = new System.Drawing.Point(295, 590);
            this.Filter.Name = "Filter";
            this.Filter.Size = new System.Drawing.Size(141, 43);
            this.Filter.TabIndex = 11;
            this.Filter.Text = "FILTER-SAVE";
            this.Filter.UseVisualStyleBackColor = false;
            this.Filter.Click += new System.EventHandler(this.Filter_Click);
            // 
            // title
            // 
            this.title.AutoSize = true;
            this.title.Font = new System.Drawing.Font("Arial", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.title.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.title.Location = new System.Drawing.Point(151, 10);
            this.title.Name = "title";
            this.title.Size = new System.Drawing.Size(618, 24);
            this.title.TabIndex = 12;
            this.title.Text = "Data Requestment : Datos de la calidad del aire en Colombia";
            // 
            // specifiedvaluefordate
            // 
            this.specifiedvaluefordate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specifiedvaluefordate.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specifiedvaluefordate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specifiedvaluefordate.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specifiedvaluefordate.ForeColor = System.Drawing.SystemColors.ControlText;
            this.specifiedvaluefordate.FormattingEnabled = true;
            this.specifiedvaluefordate.Items.AddRange(new object[] {
            "",
            "date"});
            this.specifiedvaluefordate.Location = new System.Drawing.Point(155, 109);
            this.specifiedvaluefordate.Name = "specifiedvaluefordate";
            this.specifiedvaluefordate.Size = new System.Drawing.Size(121, 22);
            this.specifiedvaluefordate.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(12, 113);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(137, 18);
            this.label1.TabIndex = 14;
            this.label1.Text = "Specified value for";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(292, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 15;
            this.label2.Text = "Value";
            // 
            // datevalue
            // 
            this.datevalue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.datevalue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.datevalue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.datevalue.Location = new System.Drawing.Point(356, 111);
            this.datevalue.Name = "datevalue";
            this.datevalue.Size = new System.Drawing.Size(100, 20);
            this.datevalue.TabIndex = 16;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Location = new System.Drawing.Point(486, 113);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(137, 18);
            this.label3.TabIndex = 17;
            this.label3.Text = "Specified value for";
            // 
            // specifiedvalueforenviromentalauthority
            // 
            this.specifiedvalueforenviromentalauthority.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specifiedvalueforenviromentalauthority.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specifiedvalueforenviromentalauthority.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specifiedvalueforenviromentalauthority.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specifiedvalueforenviromentalauthority.ForeColor = System.Drawing.SystemColors.ControlText;
            this.specifiedvalueforenviromentalauthority.FormattingEnabled = true;
            this.specifiedvalueforenviromentalauthority.Items.AddRange(new object[] {
            "",
            "enviromental authority"});
            this.specifiedvalueforenviromentalauthority.Location = new System.Drawing.Point(644, 111);
            this.specifiedvalueforenviromentalauthority.Name = "specifiedvalueforenviromentalauthority";
            this.specifiedvalueforenviromentalauthority.Size = new System.Drawing.Size(121, 22);
            this.specifiedvalueforenviromentalauthority.TabIndex = 18;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(12, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 18);
            this.label4.TabIndex = 19;
            this.label4.Text = "Specified value for";
            // 
            // specifiedvalueforstationname
            // 
            this.specifiedvalueforstationname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specifiedvalueforstationname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specifiedvalueforstationname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specifiedvalueforstationname.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specifiedvalueforstationname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.specifiedvalueforstationname.FormattingEnabled = true;
            this.specifiedvalueforstationname.Items.AddRange(new object[] {
            "",
            "station name"});
            this.specifiedvalueforstationname.Location = new System.Drawing.Point(155, 153);
            this.specifiedvalueforstationname.Name = "specifiedvalueforstationname";
            this.specifiedvalueforstationname.Size = new System.Drawing.Size(121, 22);
            this.specifiedvalueforstationname.TabIndex = 20;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Location = new System.Drawing.Point(292, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(47, 18);
            this.label5.TabIndex = 21;
            this.label5.Text = "Value";
            // 
            // stationnamevalue
            // 
            this.stationnamevalue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.stationnamevalue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stationnamevalue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.stationnamevalue.Location = new System.Drawing.Point(356, 157);
            this.stationnamevalue.Name = "stationnamevalue";
            this.stationnamevalue.Size = new System.Drawing.Size(100, 20);
            this.stationnamevalue.TabIndex = 22;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(12, 201);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(137, 18);
            this.label6.TabIndex = 23;
            this.label6.Text = "Specified value for";
            // 
            // specifiedvalueforlatitude
            // 
            this.specifiedvalueforlatitude.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specifiedvalueforlatitude.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specifiedvalueforlatitude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specifiedvalueforlatitude.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specifiedvalueforlatitude.ForeColor = System.Drawing.SystemColors.ControlText;
            this.specifiedvalueforlatitude.FormattingEnabled = true;
            this.specifiedvalueforlatitude.Items.AddRange(new object[] {
            "",
            "latitude"});
            this.specifiedvalueforlatitude.Location = new System.Drawing.Point(155, 197);
            this.specifiedvalueforlatitude.Name = "specifiedvalueforlatitude";
            this.specifiedvalueforlatitude.Size = new System.Drawing.Size(121, 22);
            this.specifiedvalueforlatitude.TabIndex = 24;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(292, 292);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 18);
            this.label7.TabIndex = 25;
            this.label7.Text = "Value";
            // 
            // latitudevalue
            // 
            this.latitudevalue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.latitudevalue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.latitudevalue.Location = new System.Drawing.Point(644, 197);
            this.latitudevalue.Name = "latitudevalue";
            this.latitudevalue.Size = new System.Drawing.Size(100, 20);
            this.latitudevalue.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Location = new System.Drawing.Point(12, 243);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(137, 18);
            this.label8.TabIndex = 27;
            this.label8.Text = "Specified value for";
            // 
            // specifiedvalueforlongitude
            // 
            this.specifiedvalueforlongitude.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specifiedvalueforlongitude.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specifiedvalueforlongitude.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specifiedvalueforlongitude.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specifiedvalueforlongitude.ForeColor = System.Drawing.SystemColors.ControlText;
            this.specifiedvalueforlongitude.FormattingEnabled = true;
            this.specifiedvalueforlongitude.Items.AddRange(new object[] {
            "",
            "longitude"});
            this.specifiedvalueforlongitude.Location = new System.Drawing.Point(155, 239);
            this.specifiedvalueforlongitude.Name = "specifiedvalueforlongitude";
            this.specifiedvalueforlongitude.Size = new System.Drawing.Size(121, 22);
            this.specifiedvalueforlongitude.TabIndex = 28;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(576, 201);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 18);
            this.label9.TabIndex = 29;
            this.label9.Text = "Value";
            // 
            // longitudevalue
            // 
            this.longitudevalue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudevalue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.longitudevalue.Location = new System.Drawing.Point(644, 241);
            this.longitudevalue.Name = "longitudevalue";
            this.longitudevalue.Size = new System.Drawing.Size(100, 20);
            this.longitudevalue.TabIndex = 30;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(12, 292);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(137, 18);
            this.label10.TabIndex = 31;
            this.label10.Text = "Specified value for";
            // 
            // specifiedvaluefordepname
            // 
            this.specifiedvaluefordepname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specifiedvaluefordepname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specifiedvaluefordepname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specifiedvaluefordepname.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specifiedvaluefordepname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.specifiedvaluefordepname.FormattingEnabled = true;
            this.specifiedvaluefordepname.Items.AddRange(new object[] {
            "",
            "department name"});
            this.specifiedvaluefordepname.Location = new System.Drawing.Point(155, 288);
            this.specifiedvaluefordepname.Name = "specifiedvaluefordepname";
            this.specifiedvaluefordepname.Size = new System.Drawing.Size(121, 22);
            this.specifiedvaluefordepname.TabIndex = 32;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(576, 242);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(47, 18);
            this.label11.TabIndex = 33;
            this.label11.Text = "Value";
            // 
            // depnamevalue
            // 
            this.depnamevalue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.depnamevalue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depnamevalue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.depnamevalue.Location = new System.Drawing.Point(356, 290);
            this.depnamevalue.Name = "depnamevalue";
            this.depnamevalue.Size = new System.Drawing.Size(100, 20);
            this.depnamevalue.TabIndex = 34;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label12.Location = new System.Drawing.Point(486, 159);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(137, 18);
            this.label12.TabIndex = 35;
            this.label12.Text = "Specified value for";
            // 
            // specifiedvaluefortechnology
            // 
            this.specifiedvaluefortechnology.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specifiedvaluefortechnology.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specifiedvaluefortechnology.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specifiedvaluefortechnology.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specifiedvaluefortechnology.ForeColor = System.Drawing.SystemColors.ControlText;
            this.specifiedvaluefortechnology.FormattingEnabled = true;
            this.specifiedvaluefortechnology.Items.AddRange(new object[] {
            "",
            "technology"});
            this.specifiedvaluefortechnology.Location = new System.Drawing.Point(644, 158);
            this.specifiedvaluefortechnology.Name = "specifiedvaluefortechnology";
            this.specifiedvaluefortechnology.Size = new System.Drawing.Size(121, 22);
            this.specifiedvaluefortechnology.TabIndex = 36;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label13.Location = new System.Drawing.Point(292, 243);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(106, 18);
            this.label13.TabIndex = 37;
            this.label13.Text = "With condition";
            // 
            // longitudecondition
            // 
            this.longitudecondition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.longitudecondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.longitudecondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.longitudecondition.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.longitudecondition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.longitudecondition.FormattingEnabled = true;
            this.longitudecondition.Items.AddRange(new object[] {
            "",
            "Less than",
            "Bigger than"});
            this.longitudecondition.Location = new System.Drawing.Point(418, 243);
            this.longitudecondition.Name = "longitudecondition";
            this.longitudecondition.Size = new System.Drawing.Size(121, 22);
            this.longitudecondition.TabIndex = 38;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(782, 163);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(47, 18);
            this.label14.TabIndex = 39;
            this.label14.Text = "Value";
            // 
            // technologyvalue
            // 
            this.technologyvalue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.technologyvalue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.technologyvalue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.technologyvalue.Location = new System.Drawing.Point(849, 160);
            this.technologyvalue.Name = "technologyvalue";
            this.technologyvalue.Size = new System.Drawing.Size(100, 20);
            this.technologyvalue.TabIndex = 40;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label15.Location = new System.Drawing.Point(486, 292);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(137, 18);
            this.label15.TabIndex = 41;
            this.label15.Text = "Specified value for";
            // 
            // specifiedvaluefordepcode
            // 
            this.specifiedvaluefordepcode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specifiedvaluefordepcode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specifiedvaluefordepcode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specifiedvaluefordepcode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specifiedvaluefordepcode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.specifiedvaluefordepcode.FormattingEnabled = true;
            this.specifiedvaluefordepcode.Items.AddRange(new object[] {
            "",
            "department code"});
            this.specifiedvaluefordepcode.Location = new System.Drawing.Point(644, 290);
            this.specifiedvaluefordepcode.Name = "specifiedvaluefordepcode";
            this.specifiedvaluefordepcode.Size = new System.Drawing.Size(121, 22);
            this.specifiedvaluefordepcode.TabIndex = 42;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label16.Location = new System.Drawing.Point(782, 292);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 18);
            this.label16.TabIndex = 43;
            this.label16.Text = "Value";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label17.Location = new System.Drawing.Point(12, 339);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(137, 18);
            this.label17.TabIndex = 45;
            this.label17.Text = "Specified value for";
            // 
            // specifiedvalueformunname
            // 
            this.specifiedvalueformunname.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specifiedvalueformunname.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specifiedvalueformunname.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specifiedvalueformunname.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specifiedvalueformunname.ForeColor = System.Drawing.SystemColors.ControlText;
            this.specifiedvalueformunname.FormattingEnabled = true;
            this.specifiedvalueformunname.Items.AddRange(new object[] {
            "",
            "municipality name"});
            this.specifiedvalueformunname.Location = new System.Drawing.Point(155, 335);
            this.specifiedvalueformunname.Name = "specifiedvalueformunname";
            this.specifiedvalueformunname.Size = new System.Drawing.Size(121, 22);
            this.specifiedvalueformunname.TabIndex = 46;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label18.Location = new System.Drawing.Point(292, 339);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(47, 18);
            this.label18.TabIndex = 47;
            this.label18.Text = "Value";
            // 
            // munnamevalue
            // 
            this.munnamevalue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.munnamevalue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.munnamevalue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.munnamevalue.Location = new System.Drawing.Point(356, 337);
            this.munnamevalue.Name = "munnamevalue";
            this.munnamevalue.Size = new System.Drawing.Size(100, 20);
            this.munnamevalue.TabIndex = 48;
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label19.Location = new System.Drawing.Point(486, 339);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(137, 18);
            this.label19.TabIndex = 49;
            this.label19.Text = "Specified value for";
            // 
            // specifiedvalueformuncode
            // 
            this.specifiedvalueformuncode.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specifiedvalueformuncode.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specifiedvalueformuncode.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specifiedvalueformuncode.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specifiedvalueformuncode.ForeColor = System.Drawing.SystemColors.ControlText;
            this.specifiedvalueformuncode.FormattingEnabled = true;
            this.specifiedvalueformuncode.Items.AddRange(new object[] {
            "",
            "municipality code"});
            this.specifiedvalueformuncode.Location = new System.Drawing.Point(644, 340);
            this.specifiedvalueformuncode.Name = "specifiedvalueformuncode";
            this.specifiedvalueformuncode.Size = new System.Drawing.Size(121, 22);
            this.specifiedvalueformuncode.TabIndex = 50;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label20.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label20.Location = new System.Drawing.Point(782, 345);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(47, 18);
            this.label20.TabIndex = 51;
            this.label20.Text = "Value";
            // 
            // muncodevalue
            // 
            this.muncodevalue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.muncodevalue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.muncodevalue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.muncodevalue.Location = new System.Drawing.Point(849, 346);
            this.muncodevalue.Name = "muncodevalue";
            this.muncodevalue.Size = new System.Drawing.Size(100, 20);
            this.muncodevalue.TabIndex = 52;
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label21.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label21.Location = new System.Drawing.Point(12, 391);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(137, 18);
            this.label21.TabIndex = 53;
            this.label21.Text = "Specified value for";
            // 
            // specifiedvaluefortypeofstation
            // 
            this.specifiedvaluefortypeofstation.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specifiedvaluefortypeofstation.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specifiedvaluefortypeofstation.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specifiedvaluefortypeofstation.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specifiedvaluefortypeofstation.ForeColor = System.Drawing.SystemColors.ControlText;
            this.specifiedvaluefortypeofstation.FormattingEnabled = true;
            this.specifiedvaluefortypeofstation.Items.AddRange(new object[] {
            "",
            "type of station"});
            this.specifiedvaluefortypeofstation.Location = new System.Drawing.Point(155, 387);
            this.specifiedvaluefortypeofstation.Name = "specifiedvaluefortypeofstation";
            this.specifiedvaluefortypeofstation.Size = new System.Drawing.Size(121, 22);
            this.specifiedvaluefortypeofstation.TabIndex = 54;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label22.Location = new System.Drawing.Point(292, 391);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(47, 18);
            this.label22.TabIndex = 55;
            this.label22.Text = "Value";
            // 
            // typeofstationvalue
            // 
            this.typeofstationvalue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.typeofstationvalue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeofstationvalue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.typeofstationvalue.Location = new System.Drawing.Point(356, 389);
            this.typeofstationvalue.Name = "typeofstationvalue";
            this.typeofstationvalue.Size = new System.Drawing.Size(100, 20);
            this.typeofstationvalue.TabIndex = 56;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label23.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label23.Location = new System.Drawing.Point(12, 444);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(137, 18);
            this.label23.TabIndex = 57;
            this.label23.Text = "Specified value for";
            // 
            // specifiedvalueforexhibitiontime
            // 
            this.specifiedvalueforexhibitiontime.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specifiedvalueforexhibitiontime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specifiedvalueforexhibitiontime.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specifiedvalueforexhibitiontime.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specifiedvalueforexhibitiontime.ForeColor = System.Drawing.SystemColors.ControlText;
            this.specifiedvalueforexhibitiontime.FormattingEnabled = true;
            this.specifiedvalueforexhibitiontime.Items.AddRange(new object[] {
            "",
            "exhibition time"});
            this.specifiedvalueforexhibitiontime.Location = new System.Drawing.Point(155, 439);
            this.specifiedvalueforexhibitiontime.Name = "specifiedvalueforexhibitiontime";
            this.specifiedvalueforexhibitiontime.Size = new System.Drawing.Size(121, 22);
            this.specifiedvalueforexhibitiontime.TabIndex = 58;
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label24.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label24.Location = new System.Drawing.Point(576, 444);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(47, 18);
            this.label24.TabIndex = 59;
            this.label24.Text = "Value";
            // 
            // exhibitiontimevalue
            // 
            this.exhibitiontimevalue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.exhibitiontimevalue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exhibitiontimevalue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exhibitiontimevalue.Location = new System.Drawing.Point(644, 442);
            this.exhibitiontimevalue.Name = "exhibitiontimevalue";
            this.exhibitiontimevalue.Size = new System.Drawing.Size(100, 20);
            this.exhibitiontimevalue.TabIndex = 60;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label25.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label25.Location = new System.Drawing.Point(292, 444);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(106, 18);
            this.label25.TabIndex = 61;
            this.label25.Text = "With condition";
            // 
            // exhibitiontimecondition
            // 
            this.exhibitiontimecondition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.exhibitiontimecondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.exhibitiontimecondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exhibitiontimecondition.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exhibitiontimecondition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.exhibitiontimecondition.FormattingEnabled = true;
            this.exhibitiontimecondition.Items.AddRange(new object[] {
            "",
            "Less than",
            "Bigger than"});
            this.exhibitiontimecondition.Location = new System.Drawing.Point(418, 439);
            this.exhibitiontimecondition.Name = "exhibitiontimecondition";
            this.exhibitiontimecondition.Size = new System.Drawing.Size(121, 22);
            this.exhibitiontimecondition.TabIndex = 62;
            // 
            // label26
            // 
            this.label26.AutoSize = true;
            this.label26.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label26.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label26.Location = new System.Drawing.Point(12, 494);
            this.label26.Name = "label26";
            this.label26.Size = new System.Drawing.Size(137, 18);
            this.label26.TabIndex = 63;
            this.label26.Text = "Specified value for";
            // 
            // label27
            // 
            this.label27.AutoSize = true;
            this.label27.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label27.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label27.Location = new System.Drawing.Point(486, 494);
            this.label27.Name = "label27";
            this.label27.Size = new System.Drawing.Size(137, 18);
            this.label27.TabIndex = 64;
            this.label27.Text = "Specified value for";
            // 
            // label28
            // 
            this.label28.AutoSize = true;
            this.label28.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label28.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label28.Location = new System.Drawing.Point(12, 551);
            this.label28.Name = "label28";
            this.label28.Size = new System.Drawing.Size(137, 18);
            this.label28.TabIndex = 65;
            this.label28.Text = "Specified value for";
            // 
            // label29
            // 
            this.label29.AutoSize = true;
            this.label29.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label29.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label29.Location = new System.Drawing.Point(12, 760);
            this.label29.Name = "label29";
            this.label29.Size = new System.Drawing.Size(0, 18);
            this.label29.TabIndex = 66;
            // 
            // specifiedvalueforvariable
            // 
            this.specifiedvalueforvariable.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specifiedvalueforvariable.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specifiedvalueforvariable.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specifiedvalueforvariable.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specifiedvalueforvariable.ForeColor = System.Drawing.SystemColors.ControlText;
            this.specifiedvalueforvariable.FormattingEnabled = true;
            this.specifiedvalueforvariable.Items.AddRange(new object[] {
            "",
            "variable"});
            this.specifiedvalueforvariable.Location = new System.Drawing.Point(155, 490);
            this.specifiedvalueforvariable.Name = "specifiedvalueforvariable";
            this.specifiedvalueforvariable.Size = new System.Drawing.Size(121, 22);
            this.specifiedvalueforvariable.TabIndex = 67;
            // 
            // specifiedvalueforunits
            // 
            this.specifiedvalueforunits.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specifiedvalueforunits.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specifiedvalueforunits.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specifiedvalueforunits.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specifiedvalueforunits.ForeColor = System.Drawing.SystemColors.ControlText;
            this.specifiedvalueforunits.FormattingEnabled = true;
            this.specifiedvalueforunits.Items.AddRange(new object[] {
            "",
            "units"});
            this.specifiedvalueforunits.Location = new System.Drawing.Point(644, 492);
            this.specifiedvalueforunits.Name = "specifiedvalueforunits";
            this.specifiedvalueforunits.Size = new System.Drawing.Size(121, 22);
            this.specifiedvalueforunits.TabIndex = 68;
            // 
            // specifiedvalueforconcentration
            // 
            this.specifiedvalueforconcentration.Cursor = System.Windows.Forms.Cursors.Hand;
            this.specifiedvalueforconcentration.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.specifiedvalueforconcentration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.specifiedvalueforconcentration.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.specifiedvalueforconcentration.ForeColor = System.Drawing.SystemColors.ControlText;
            this.specifiedvalueforconcentration.FormattingEnabled = true;
            this.specifiedvalueforconcentration.Items.AddRange(new object[] {
            "",
            "concentration"});
            this.specifiedvalueforconcentration.Location = new System.Drawing.Point(155, 547);
            this.specifiedvalueforconcentration.Name = "specifiedvalueforconcentration";
            this.specifiedvalueforconcentration.Size = new System.Drawing.Size(121, 22);
            this.specifiedvalueforconcentration.TabIndex = 69;
            // 
            // depcodevalue
            // 
            this.depcodevalue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.depcodevalue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.depcodevalue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.depcodevalue.Location = new System.Drawing.Point(849, 290);
            this.depcodevalue.Name = "depcodevalue";
            this.depcodevalue.Size = new System.Drawing.Size(100, 20);
            this.depcodevalue.TabIndex = 71;
            // 
            // label30
            // 
            this.label30.AutoSize = true;
            this.label30.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label30.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label30.Location = new System.Drawing.Point(292, 494);
            this.label30.Name = "label30";
            this.label30.Size = new System.Drawing.Size(47, 18);
            this.label30.TabIndex = 72;
            this.label30.Text = "Value";
            // 
            // variablevalue
            // 
            this.variablevalue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.variablevalue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.variablevalue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.variablevalue.Location = new System.Drawing.Point(356, 492);
            this.variablevalue.Name = "variablevalue";
            this.variablevalue.Size = new System.Drawing.Size(100, 20);
            this.variablevalue.TabIndex = 73;
            // 
            // unitsvalue
            // 
            this.unitsvalue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.unitsvalue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unitsvalue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.unitsvalue.Location = new System.Drawing.Point(849, 494);
            this.unitsvalue.Name = "unitsvalue";
            this.unitsvalue.Size = new System.Drawing.Size(100, 20);
            this.unitsvalue.TabIndex = 74;
            // 
            // concentrationvalue
            // 
            this.concentrationvalue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.concentrationvalue.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concentrationvalue.ForeColor = System.Drawing.SystemColors.ControlText;
            this.concentrationvalue.Location = new System.Drawing.Point(644, 547);
            this.concentrationvalue.Name = "concentrationvalue";
            this.concentrationvalue.Size = new System.Drawing.Size(100, 20);
            this.concentrationvalue.TabIndex = 75;
            // 
            // label31
            // 
            this.label31.AutoSize = true;
            this.label31.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label31.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label31.Location = new System.Drawing.Point(782, 496);
            this.label31.Name = "label31";
            this.label31.Size = new System.Drawing.Size(47, 18);
            this.label31.TabIndex = 76;
            this.label31.Text = "Value";
            // 
            // label32
            // 
            this.label32.AutoSize = true;
            this.label32.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label32.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label32.Location = new System.Drawing.Point(576, 551);
            this.label32.Name = "label32";
            this.label32.Size = new System.Drawing.Size(47, 18);
            this.label32.TabIndex = 77;
            this.label32.Text = "Value";
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label33.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label33.Location = new System.Drawing.Point(292, 551);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(106, 18);
            this.label33.TabIndex = 78;
            this.label33.Text = "With condition";
            // 
            // concentrationcondition
            // 
            this.concentrationcondition.Cursor = System.Windows.Forms.Cursors.Hand;
            this.concentrationcondition.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.concentrationcondition.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.concentrationcondition.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.concentrationcondition.ForeColor = System.Drawing.SystemColors.ControlText;
            this.concentrationcondition.FormattingEnabled = true;
            this.concentrationcondition.Items.AddRange(new object[] {
            "Less than",
            "Bigger than"});
            this.concentrationcondition.Location = new System.Drawing.Point(418, 547);
            this.concentrationcondition.Name = "concentrationcondition";
            this.concentrationcondition.Size = new System.Drawing.Size(121, 22);
            this.concentrationcondition.TabIndex = 79;
            // 
            // LoadandSave
            // 
            this.LoadandSave.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LoadandSave.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.LoadandSave.Location = new System.Drawing.Point(480, 590);
            this.LoadandSave.Name = "LoadandSave";
            this.LoadandSave.Size = new System.Drawing.Size(131, 43);
            this.LoadandSave.TabIndex = 80;
            this.LoadandSave.Text = "LOAD-SAVE";
            this.LoadandSave.UseVisualStyleBackColor = true;
            this.LoadandSave.Click += new System.EventHandler(this.Load_Click);
            // 
            // DataReader
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(979, 645);
            this.Controls.Add(this.LoadandSave);
            this.Controls.Add(this.concentrationcondition);
            this.Controls.Add(this.label33);
            this.Controls.Add(this.label32);
            this.Controls.Add(this.label31);
            this.Controls.Add(this.concentrationvalue);
            this.Controls.Add(this.unitsvalue);
            this.Controls.Add(this.variablevalue);
            this.Controls.Add(this.label30);
            this.Controls.Add(this.depcodevalue);
            this.Controls.Add(this.specifiedvalueforconcentration);
            this.Controls.Add(this.specifiedvalueforunits);
            this.Controls.Add(this.specifiedvalueforvariable);
            this.Controls.Add(this.label29);
            this.Controls.Add(this.label28);
            this.Controls.Add(this.label27);
            this.Controls.Add(this.label26);
            this.Controls.Add(this.exhibitiontimecondition);
            this.Controls.Add(this.label25);
            this.Controls.Add(this.exhibitiontimevalue);
            this.Controls.Add(this.label24);
            this.Controls.Add(this.specifiedvalueforexhibitiontime);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.typeofstationvalue);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.specifiedvaluefortypeofstation);
            this.Controls.Add(this.label21);
            this.Controls.Add(this.muncodevalue);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.specifiedvalueformuncode);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.munnamevalue);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.specifiedvalueformunname);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.specifiedvaluefordepcode);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.technologyvalue);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.longitudecondition);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.specifiedvaluefortechnology);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.depnamevalue);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.specifiedvaluefordepname);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.longitudevalue);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.specifiedvalueforlongitude);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.latitudevalue);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.specifiedvalueforlatitude);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.stationnamevalue);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.specifiedvalueforstationname);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.specifiedvalueforenviromentalauthority);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datevalue);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.specifiedvaluefordate);
            this.Controls.Add(this.title);
            this.Controls.Add(this.Filter);
            this.Controls.Add(this.enviromentalauthorityvalue);
            this.Controls.Add(this.val);
            this.Controls.Add(this.latitudecondition);
            this.Controls.Add(this.withcondition);
            this.Controls.Add(this.selectamount);
            this.Controls.Add(this.selectlimit);
            this.Controls.Add(this.amount);
            this.Controls.Add(this.limit);
            this.Controls.Add(this.selectcolumn);
            this.Controls.Add(this.columnsfilter);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "DataReader";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DataReader";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox columnsfilter;
        private System.Windows.Forms.Label selectcolumn;
        private System.Windows.Forms.TextBox limit;
        private System.Windows.Forms.TextBox amount;
        private System.Windows.Forms.Label selectlimit;
        private System.Windows.Forms.Label selectamount;
        private System.Windows.Forms.Label withcondition;
        private System.Windows.Forms.ComboBox latitudecondition;
        private System.Windows.Forms.Label val;
        private System.Windows.Forms.TextBox enviromentalauthorityvalue;
        private System.Windows.Forms.Button Filter;
        private System.Windows.Forms.Label title;
        private System.Windows.Forms.ComboBox specifiedvaluefordate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox datevalue;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox specifiedvalueforenviromentalauthority;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox specifiedvalueforstationname;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox stationnamevalue;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox specifiedvalueforlatitude;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox latitudevalue;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox specifiedvalueforlongitude;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox longitudevalue;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ComboBox specifiedvaluefordepname;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox depnamevalue;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.ComboBox specifiedvaluefortechnology;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox longitudecondition;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox technologyvalue;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.ComboBox specifiedvaluefordepcode;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.ComboBox specifiedvalueformunname;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.TextBox munnamevalue;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.ComboBox specifiedvalueformuncode;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.TextBox muncodevalue;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.ComboBox specifiedvaluefortypeofstation;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.TextBox typeofstationvalue;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.ComboBox specifiedvalueforexhibitiontime;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.TextBox exhibitiontimevalue;
        private System.Windows.Forms.Label label25;
        private System.Windows.Forms.ComboBox exhibitiontimecondition;
        private System.Windows.Forms.Label label26;
        private System.Windows.Forms.Label label27;
        private System.Windows.Forms.Label label28;
        private System.Windows.Forms.Label label29;
        private System.Windows.Forms.ComboBox specifiedvalueforvariable;
        private System.Windows.Forms.ComboBox specifiedvalueforunits;
        private System.Windows.Forms.ComboBox specifiedvalueforconcentration;
        private System.Windows.Forms.TextBox depcodevalue;
        private System.Windows.Forms.Label label30;
        private System.Windows.Forms.TextBox variablevalue;
        private System.Windows.Forms.TextBox unitsvalue;
        private System.Windows.Forms.TextBox concentrationvalue;
        private System.Windows.Forms.Label label31;
        private System.Windows.Forms.Label label32;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.ComboBox concentrationcondition;
        private System.Windows.Forms.Button LoadandSave;
    }
}