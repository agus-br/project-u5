namespace project_u5.view
{
    partial class Transactions
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
            this.components = new System.ComponentModel.Container();
            this.gbReport = new System.Windows.Forms.GroupBox();
            this.btnReportCategory = new System.Windows.Forms.Button();
            this.btnReportMonth = new System.Windows.Forms.Button();
            this.cboCategoriesReport = new System.Windows.Forms.ComboBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtYearReport = new System.Windows.Forms.TextBox();
            this.cboMonthReport = new System.Windows.Forms.ComboBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.gbInsertTransaction = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtDay = new System.Windows.Forms.TextBox();
            this.cboType = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboMonth = new System.Windows.Forms.ComboBox();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.cboCategories = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtConcept = new System.Windows.Forms.TextBox();
            this.cboPlaces = new System.Windows.Forms.ComboBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNotes = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnInsert = new System.Windows.Forms.Button();
            this.btnClose = new System.Windows.Forms.Button();
            this.error = new System.Windows.Forms.ErrorProvider(this.components);
            this.gbReport.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbInsertTransaction.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).BeginInit();
            this.SuspendLayout();
            // 
            // gbReport
            // 
            this.gbReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gbReport.Controls.Add(this.btnReportCategory);
            this.gbReport.Controls.Add(this.btnReportMonth);
            this.gbReport.Controls.Add(this.cboCategoriesReport);
            this.gbReport.Controls.Add(this.label10);
            this.gbReport.Controls.Add(this.txtYearReport);
            this.gbReport.Controls.Add(this.cboMonthReport);
            this.gbReport.Controls.Add(this.label13);
            this.gbReport.Controls.Add(this.label9);
            this.gbReport.Controls.Add(this.textBox1);
            this.gbReport.Controls.Add(this.label14);
            this.gbReport.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbReport.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbReport.ForeColor = System.Drawing.Color.White;
            this.gbReport.Location = new System.Drawing.Point(367, 69);
            this.gbReport.Margin = new System.Windows.Forms.Padding(0);
            this.gbReport.Name = "gbReport";
            this.gbReport.Size = new System.Drawing.Size(241, 240);
            this.gbReport.TabIndex = 80;
            this.gbReport.TabStop = false;
            this.gbReport.Text = "Generar reporte";
            // 
            // btnReportCategory
            // 
            this.btnReportCategory.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportCategory.BackColor = System.Drawing.Color.Gray;
            this.btnReportCategory.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportCategory.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportCategory.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReportCategory.Location = new System.Drawing.Point(8, 196);
            this.btnReportCategory.Name = "btnReportCategory";
            this.btnReportCategory.Size = new System.Drawing.Size(227, 34);
            this.btnReportCategory.TabIndex = 83;
            this.btnReportCategory.Text = "Reporte por categoría";
            this.btnReportCategory.UseVisualStyleBackColor = false;
            this.btnReportCategory.Click += new System.EventHandler(this.btnReportCategory_Click);
            // 
            // btnReportMonth
            // 
            this.btnReportMonth.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnReportMonth.BackColor = System.Drawing.Color.Gray;
            this.btnReportMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnReportMonth.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReportMonth.ForeColor = System.Drawing.SystemColors.Window;
            this.btnReportMonth.Location = new System.Drawing.Point(8, 156);
            this.btnReportMonth.Name = "btnReportMonth";
            this.btnReportMonth.Size = new System.Drawing.Size(227, 34);
            this.btnReportMonth.TabIndex = 81;
            this.btnReportMonth.Text = "Reporte por mes";
            this.btnReportMonth.UseVisualStyleBackColor = false;
            this.btnReportMonth.Click += new System.EventHandler(this.btnReportMonth_Click);
            // 
            // cboCategoriesReport
            // 
            this.cboCategoriesReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cboCategoriesReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboCategoriesReport.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoriesReport.ForeColor = System.Drawing.SystemColors.Menu;
            this.cboCategoriesReport.FormattingEnabled = true;
            this.cboCategoriesReport.Location = new System.Drawing.Point(14, 116);
            this.cboCategoriesReport.MaxDropDownItems = 6;
            this.cboCategoriesReport.Name = "cboCategoriesReport";
            this.cboCategoriesReport.Size = new System.Drawing.Size(221, 25);
            this.cboCategoriesReport.TabIndex = 82;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label10.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.Window;
            this.label10.Location = new System.Drawing.Point(10, 82);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(91, 21);
            this.label10.TabIndex = 81;
            this.label10.Text = "Categoría";
            // 
            // txtYearReport
            // 
            this.txtYearReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYearReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtYearReport.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYearReport.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYearReport.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtYearReport.Location = new System.Drawing.Point(49, 49);
            this.txtYearReport.MaxLength = 4;
            this.txtYearReport.Name = "txtYearReport";
            this.txtYearReport.Size = new System.Drawing.Size(46, 26);
            this.txtYearReport.TabIndex = 74;
            this.txtYearReport.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYearReport.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYearReport_KeyPress);
            // 
            // cboMonthReport
            // 
            this.cboMonthReport.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cboMonthReport.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboMonthReport.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonthReport.ForeColor = System.Drawing.SystemColors.Menu;
            this.cboMonthReport.FormattingEnabled = true;
            this.cboMonthReport.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cboMonthReport.Location = new System.Drawing.Point(147, 49);
            this.cboMonthReport.MaxDropDownItems = 6;
            this.cboMonthReport.Name = "cboMonthReport";
            this.cboMonthReport.Size = new System.Drawing.Size(60, 25);
            this.cboMonthReport.TabIndex = 8;
            // 
            // label13
            // 
            this.label13.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label13.Location = new System.Drawing.Point(109, 53);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 17);
            this.label13.TabIndex = 7;
            this.label13.Text = "Mes";
            // 
            // label9
            // 
            this.label9.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label9.Location = new System.Drawing.Point(5, 53);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(32, 17);
            this.label9.TabIndex = 7;
            this.label9.Text = "Año";
            // 
            // textBox1
            // 
            this.textBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Location = new System.Drawing.Point(43, 48);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(0, 26);
            this.textBox1.TabIndex = 6;
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label14.Location = new System.Drawing.Point(20, 24);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(55, 21);
            this.label14.TabIndex = 7;
            this.label14.Text = "Fecha";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Gray;
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(-1, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(618, 52);
            this.panel1.TabIndex = 62;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gray;
            this.label1.Font = new System.Drawing.Font("Cascadia Code", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Window;
            this.label1.Location = new System.Drawing.Point(10, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(155, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Transacciones";
            // 
            // gbInsertTransaction
            // 
            this.gbInsertTransaction.Controls.Add(this.label2);
            this.gbInsertTransaction.Controls.Add(this.label15);
            this.gbInsertTransaction.Controls.Add(this.label7);
            this.gbInsertTransaction.Controls.Add(this.label6);
            this.gbInsertTransaction.Controls.Add(this.txtDay);
            this.gbInsertTransaction.Controls.Add(this.cboType);
            this.gbInsertTransaction.Controls.Add(this.label5);
            this.gbInsertTransaction.Controls.Add(this.txtYear);
            this.gbInsertTransaction.Controls.Add(this.label8);
            this.gbInsertTransaction.Controls.Add(this.cboMonth);
            this.gbInsertTransaction.Controls.Add(this.txtAmount);
            this.gbInsertTransaction.Controls.Add(this.cboCategories);
            this.gbInsertTransaction.Controls.Add(this.label11);
            this.gbInsertTransaction.Controls.Add(this.label4);
            this.gbInsertTransaction.Controls.Add(this.txtConcept);
            this.gbInsertTransaction.Controls.Add(this.cboPlaces);
            this.gbInsertTransaction.Controls.Add(this.label12);
            this.gbInsertTransaction.Controls.Add(this.txtNotes);
            this.gbInsertTransaction.Controls.Add(this.label3);
            this.gbInsertTransaction.Controls.Add(this.btnInsert);
            this.gbInsertTransaction.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.gbInsertTransaction.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbInsertTransaction.ForeColor = System.Drawing.Color.White;
            this.gbInsertTransaction.Location = new System.Drawing.Point(14, 65);
            this.gbInsertTransaction.Margin = new System.Windows.Forms.Padding(0);
            this.gbInsertTransaction.Name = "gbInsertTransaction";
            this.gbInsertTransaction.Size = new System.Drawing.Size(343, 384);
            this.gbInsertTransaction.TabIndex = 106;
            this.gbInsertTransaction.TabStop = false;
            this.gbInsertTransaction.Text = "Insertar Transacción";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label2.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Window;
            this.label2.Location = new System.Drawing.Point(9, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 21);
            this.label2.TabIndex = 106;
            this.label2.Text = "Concepto";
            // 
            // label15
            // 
            this.label15.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label15.Location = new System.Drawing.Point(234, 83);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(32, 17);
            this.label15.TabIndex = 125;
            this.label15.Text = "Día";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label7.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Window;
            this.label7.Location = new System.Drawing.Point(9, 54);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(55, 21);
            this.label7.TabIndex = 114;
            this.label7.Text = "Fecha";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label6.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(11, 208);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 21);
            this.label6.TabIndex = 113;
            this.label6.Text = "Notas";
            // 
            // txtDay
            // 
            this.txtDay.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtDay.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtDay.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtDay.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDay.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtDay.Location = new System.Drawing.Point(273, 78);
            this.txtDay.MaxLength = 2;
            this.txtDay.Name = "txtDay";
            this.txtDay.Size = new System.Drawing.Size(45, 26);
            this.txtDay.TabIndex = 124;
            this.txtDay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDay.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDay_KeyPress);
            // 
            // cboType
            // 
            this.cboType.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cboType.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboType.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboType.ForeColor = System.Drawing.SystemColors.Menu;
            this.cboType.FormattingEnabled = true;
            this.cboType.Items.AddRange(new object[] {
            "Gasto",
            "Ingreso"});
            this.cboType.Location = new System.Drawing.Point(113, 163);
            this.cboType.MaxDropDownItems = 6;
            this.cboType.Name = "cboType";
            this.cboType.Size = new System.Drawing.Size(221, 25);
            this.cboType.TabIndex = 115;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label5.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.Window;
            this.label5.Location = new System.Drawing.Point(9, 118);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(82, 21);
            this.label5.TabIndex = 112;
            this.label5.Text = "Cantidad";
            // 
            // txtYear
            // 
            this.txtYear.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtYear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtYear.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtYear.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtYear.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtYear.Location = new System.Drawing.Point(64, 78);
            this.txtYear.MaxLength = 4;
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(45, 26);
            this.txtYear.TabIndex = 123;
            this.txtYear.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtYear.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtYear_KeyPress);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label8.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.SystemColors.Window;
            this.label8.Location = new System.Drawing.Point(11, 301);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(55, 21);
            this.label8.TabIndex = 116;
            this.label8.Text = "Lugar";
            // 
            // cboMonth
            // 
            this.cboMonth.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cboMonth.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboMonth.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboMonth.ForeColor = System.Drawing.SystemColors.Menu;
            this.cboMonth.FormattingEnabled = true;
            this.cboMonth.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cboMonth.Location = new System.Drawing.Point(162, 78);
            this.cboMonth.MaxDropDownItems = 6;
            this.cboMonth.Name = "cboMonth";
            this.cboMonth.Size = new System.Drawing.Size(60, 25);
            this.cboMonth.TabIndex = 122;
            // 
            // txtAmount
            // 
            this.txtAmount.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtAmount.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtAmount.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtAmount.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtAmount.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtAmount.Location = new System.Drawing.Point(113, 118);
            this.txtAmount.MaxLength = 13;
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(220, 26);
            this.txtAmount.TabIndex = 111;
            this.txtAmount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtAmount.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAmount_KeyPress);
            // 
            // cboCategories
            // 
            this.cboCategories.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cboCategories.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboCategories.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategories.ForeColor = System.Drawing.SystemColors.Menu;
            this.cboCategories.FormattingEnabled = true;
            this.cboCategories.Location = new System.Drawing.Point(113, 257);
            this.cboCategories.MaxDropDownItems = 6;
            this.cboCategories.Name = "cboCategories";
            this.cboCategories.Size = new System.Drawing.Size(221, 25);
            this.cboCategories.TabIndex = 117;
            // 
            // label11
            // 
            this.label11.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label11.Location = new System.Drawing.Point(124, 82);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(32, 17);
            this.label11.TabIndex = 120;
            this.label11.Text = "Mes";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label4.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(11, 163);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 21);
            this.label4.TabIndex = 110;
            this.label4.Text = "Tipo";
            // 
            // txtConcept
            // 
            this.txtConcept.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtConcept.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtConcept.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtConcept.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtConcept.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtConcept.Location = new System.Drawing.Point(113, 18);
            this.txtConcept.MaxLength = 50;
            this.txtConcept.Name = "txtConcept";
            this.txtConcept.Size = new System.Drawing.Size(220, 26);
            this.txtConcept.TabIndex = 107;
            this.txtConcept.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtConcept.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtConcept_KeyPress);
            // 
            // cboPlaces
            // 
            this.cboPlaces.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.cboPlaces.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cboPlaces.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboPlaces.ForeColor = System.Drawing.SystemColors.Menu;
            this.cboPlaces.FormattingEnabled = true;
            this.cboPlaces.Location = new System.Drawing.Point(113, 301);
            this.cboPlaces.MaxDropDownItems = 6;
            this.cboPlaces.Name = "cboPlaces";
            this.cboPlaces.Size = new System.Drawing.Size(221, 25);
            this.cboPlaces.TabIndex = 118;
            // 
            // label12
            // 
            this.label12.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Cascadia Code", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label12.Location = new System.Drawing.Point(20, 82);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(32, 17);
            this.label12.TabIndex = 121;
            this.label12.Text = "Año";
            // 
            // txtNotes
            // 
            this.txtNotes.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtNotes.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(30)))));
            this.txtNotes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtNotes.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNotes.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.txtNotes.Location = new System.Drawing.Point(113, 208);
            this.txtNotes.MaxLength = 255;
            this.txtNotes.Name = "txtNotes";
            this.txtNotes.Size = new System.Drawing.Size(220, 26);
            this.txtNotes.TabIndex = 109;
            this.txtNotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtNotes.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtNotes_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.label3.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.Window;
            this.label3.Location = new System.Drawing.Point(11, 257);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(91, 21);
            this.label3.TabIndex = 108;
            this.label3.Text = "Categoría";
            // 
            // btnInsert
            // 
            this.btnInsert.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnInsert.BackColor = System.Drawing.Color.Gray;
            this.btnInsert.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnInsert.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInsert.ForeColor = System.Drawing.SystemColors.Window;
            this.btnInsert.Location = new System.Drawing.Point(64, 332);
            this.btnInsert.Name = "btnInsert";
            this.btnInsert.Size = new System.Drawing.Size(115, 34);
            this.btnInsert.TabIndex = 119;
            this.btnInsert.Text = "Insertar";
            this.btnInsert.UseVisualStyleBackColor = false;
            this.btnInsert.Click += new System.EventHandler(this.btnInsert_Click);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.BackColor = System.Drawing.Color.Gray;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnClose.Font = new System.Drawing.Font("Cascadia Code", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.ForeColor = System.Drawing.SystemColors.Window;
            this.btnClose.Location = new System.Drawing.Point(576, 6);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 34);
            this.btnClose.TabIndex = 126;
            this.btnClose.Text = "X";
            this.btnClose.UseVisualStyleBackColor = false;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // error
            // 
            this.error.ContainerControl = this;
            // 
            // Transactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(33)))), ((int)(((byte)(33)))));
            this.ClientSize = new System.Drawing.Size(617, 458);
            this.Controls.Add(this.gbInsertTransaction);
            this.Controls.Add(this.gbReport);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Transactions";
            this.Text = "Transactions";
            this.gbReport.ResumeLayout(false);
            this.gbReport.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbInsertTransaction.ResumeLayout(false);
            this.gbInsertTransaction.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.error)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbReport;
        private System.Windows.Forms.ComboBox cboMonthReport;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtYearReport;
        private System.Windows.Forms.ComboBox cboCategoriesReport;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnReportCategory;
        private System.Windows.Forms.Button btnReportMonth;
        private System.Windows.Forms.GroupBox gbInsertTransaction;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtDay;
        private System.Windows.Forms.ComboBox cboType;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox cboMonth;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.ComboBox cboCategories;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtConcept;
        private System.Windows.Forms.ComboBox cboPlaces;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtNotes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnInsert;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.ErrorProvider error;
    }
}