namespace HR_SPHERE
{
    partial class Employee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Employee));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Empdvg = new System.Windows.Forms.DataGridView();
            this.empidDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empaddDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empnumDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empdobDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empgenDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.empeduDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRSDataSet1 = new HR_SPHERE.HRSDataSet1();
            this.Home = new System.Windows.Forms.Button();
            this.Delete = new System.Windows.Forms.Button();
            this.Edit = new System.Windows.Forms.Button();
            this.Add = new System.Windows.Forms.Button();
            this.Empedut = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.Empgent = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Empnumt = new System.Windows.Forms.MaskedTextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Empaddt = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.Empnamet = new System.Windows.Forms.MaskedTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.Empidt = new System.Windows.Forms.MaskedTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Empdobt = new System.Windows.Forms.DateTimePicker();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.employeeTableAdapter = new HR_SPHERE.HRSDataSet1TableAdapters.EmployeeTableAdapter();
            this.panel3 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Empdvg)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRSDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // Empdvg
            // 
            this.Empdvg.AutoGenerateColumns = false;
            this.Empdvg.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Empdvg.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.Empdvg.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Empdvg.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.empidDataGridViewTextBoxColumn,
            this.empnameDataGridViewTextBoxColumn,
            this.empaddDataGridViewTextBoxColumn,
            this.empnumDataGridViewTextBoxColumn,
            this.empdobDataGridViewTextBoxColumn,
            this.empgenDataGridViewTextBoxColumn,
            this.empeduDataGridViewTextBoxColumn});
            this.Empdvg.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Empdvg.DataSource = this.employeeBindingSource;
            this.Empdvg.GridColor = System.Drawing.Color.DodgerBlue;
            this.Empdvg.Location = new System.Drawing.Point(572, 25);
            this.Empdvg.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Empdvg.Name = "Empdvg";
            this.Empdvg.ReadOnly = true;
            this.Empdvg.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            this.Empdvg.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.Empdvg.RowTemplate.Height = 28;
            this.Empdvg.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Empdvg.Size = new System.Drawing.Size(735, 635);
            this.Empdvg.TabIndex = 24;
            this.Empdvg.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Empdvg_CellContentClick);
            // 
            // empidDataGridViewTextBoxColumn
            // 
            this.empidDataGridViewTextBoxColumn.DataPropertyName = "Empid";
            this.empidDataGridViewTextBoxColumn.HeaderText = "ID";
            this.empidDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empidDataGridViewTextBoxColumn.Name = "empidDataGridViewTextBoxColumn";
            this.empidDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empnameDataGridViewTextBoxColumn
            // 
            this.empnameDataGridViewTextBoxColumn.DataPropertyName = "Empname";
            this.empnameDataGridViewTextBoxColumn.HeaderText = "Name";
            this.empnameDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empnameDataGridViewTextBoxColumn.Name = "empnameDataGridViewTextBoxColumn";
            this.empnameDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empaddDataGridViewTextBoxColumn
            // 
            this.empaddDataGridViewTextBoxColumn.DataPropertyName = "Empadd";
            this.empaddDataGridViewTextBoxColumn.HeaderText = "Address";
            this.empaddDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empaddDataGridViewTextBoxColumn.Name = "empaddDataGridViewTextBoxColumn";
            this.empaddDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empnumDataGridViewTextBoxColumn
            // 
            this.empnumDataGridViewTextBoxColumn.DataPropertyName = "Empnum";
            this.empnumDataGridViewTextBoxColumn.HeaderText = "Phone No.";
            this.empnumDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empnumDataGridViewTextBoxColumn.Name = "empnumDataGridViewTextBoxColumn";
            this.empnumDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empdobDataGridViewTextBoxColumn
            // 
            this.empdobDataGridViewTextBoxColumn.DataPropertyName = "Empdob";
            this.empdobDataGridViewTextBoxColumn.HeaderText = "Birth Date";
            this.empdobDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empdobDataGridViewTextBoxColumn.Name = "empdobDataGridViewTextBoxColumn";
            this.empdobDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empgenDataGridViewTextBoxColumn
            // 
            this.empgenDataGridViewTextBoxColumn.DataPropertyName = "Empgen";
            this.empgenDataGridViewTextBoxColumn.HeaderText = "Gender";
            this.empgenDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empgenDataGridViewTextBoxColumn.Name = "empgenDataGridViewTextBoxColumn";
            this.empgenDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // empeduDataGridViewTextBoxColumn
            // 
            this.empeduDataGridViewTextBoxColumn.DataPropertyName = "Empedu";
            this.empeduDataGridViewTextBoxColumn.HeaderText = "Education";
            this.empeduDataGridViewTextBoxColumn.MinimumWidth = 6;
            this.empeduDataGridViewTextBoxColumn.Name = "empeduDataGridViewTextBoxColumn";
            this.empeduDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // employeeBindingSource
            // 
            this.employeeBindingSource.DataMember = "Employee";
            this.employeeBindingSource.DataSource = this.hRSDataSet1;
            // 
            // hRSDataSet1
            // 
            this.hRSDataSet1.DataSetName = "HRSDataSet1";
            this.hRSDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Gold;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Location = new System.Drawing.Point(427, 494);
            this.Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(129, 48);
            this.Home.TabIndex = 23;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // Delete
            // 
            this.Delete.BackColor = System.Drawing.Color.Red;
            this.Delete.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Delete.ForeColor = System.Drawing.Color.White;
            this.Delete.Location = new System.Drawing.Point(289, 494);
            this.Delete.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Delete.Name = "Delete";
            this.Delete.Size = new System.Drawing.Size(132, 48);
            this.Delete.TabIndex = 22;
            this.Delete.Text = "Delete";
            this.Delete.UseVisualStyleBackColor = false;
            this.Delete.Click += new System.EventHandler(this.Delete_Click);
            // 
            // Edit
            // 
            this.Edit.BackColor = System.Drawing.Color.LimeGreen;
            this.Edit.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Edit.ForeColor = System.Drawing.Color.White;
            this.Edit.Location = new System.Drawing.Point(156, 494);
            this.Edit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(127, 48);
            this.Edit.TabIndex = 21;
            this.Edit.Text = "Edit";
            this.Edit.UseVisualStyleBackColor = false;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Add
            // 
            this.Add.BackColor = System.Drawing.Color.LimeGreen;
            this.Add.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Add.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Add.ForeColor = System.Drawing.Color.White;
            this.Add.Location = new System.Drawing.Point(14, 494);
            this.Add.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Add.Name = "Add";
            this.Add.Size = new System.Drawing.Size(136, 48);
            this.Add.TabIndex = 20;
            this.Add.Text = "Add";
            this.Add.UseVisualStyleBackColor = false;
            this.Add.Click += new System.EventHandler(this.Add_Click);
            // 
            // Empedut
            // 
            this.Empedut.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empedut.FormattingEnabled = true;
            this.Empedut.Items.AddRange(new object[] {
            "10th",
            "12th"});
            this.Empedut.Location = new System.Drawing.Point(348, 314);
            this.Empedut.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Empedut.Name = "Empedut";
            this.Empedut.Size = new System.Drawing.Size(188, 37);
            this.Empedut.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(333, 272);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(241, 29);
            this.label8.TabIndex = 18;
            this.label8.Text = "Employee  Education";
            // 
            // Empgent
            // 
            this.Empgent.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empgent.FormattingEnabled = true;
            this.Empgent.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.Empgent.Location = new System.Drawing.Point(339, 204);
            this.Empgent.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Empgent.Name = "Empgent";
            this.Empgent.Size = new System.Drawing.Size(188, 37);
            this.Empgent.TabIndex = 17;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(333, 169);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(215, 29);
            this.label7.TabIndex = 16;
            this.label7.Text = "Employee  Gender";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.DodgerBlue;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(76, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(441, 55);
            this.label1.TabIndex = 7;
            this.label1.Text = "Manage Employee";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(30, 394);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(259, 29);
            this.label6.TabIndex = 14;
            this.label6.Text = "Employee Date of Birth";
            // 
            // Empnumt
            // 
            this.Empnumt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empnumt.Location = new System.Drawing.Point(37, 316);
            this.Empnumt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Empnumt.Name = "Empnumt";
            this.Empnumt.Size = new System.Drawing.Size(188, 35);
            this.Empnumt.TabIndex = 13;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(30, 272);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(221, 29);
            this.label5.TabIndex = 12;
            this.label5.Text = "Employee  Number";
            // 
            // Empaddt
            // 
            this.Empaddt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empaddt.Location = new System.Drawing.Point(37, 204);
            this.Empaddt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Empaddt.Name = "Empaddt";
            this.Empaddt.Size = new System.Drawing.Size(188, 35);
            this.Empaddt.TabIndex = 11;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 169);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(217, 29);
            this.label4.TabIndex = 10;
            this.label4.Text = "Empolyee Address";
            // 
            // Empnamet
            // 
            this.Empnamet.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empnamet.Location = new System.Drawing.Point(339, 101);
            this.Empnamet.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Empnamet.Name = "Empnamet";
            this.Empnamet.Size = new System.Drawing.Size(188, 35);
            this.Empnamet.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(333, 66);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(193, 29);
            this.label3.TabIndex = 8;
            this.label3.Text = "Employee Name";
            // 
            // Empidt
            // 
            this.Empidt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empidt.Location = new System.Drawing.Point(37, 101);
            this.Empidt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Empidt.Name = "Empidt";
            this.Empidt.Size = new System.Drawing.Size(188, 35);
            this.Empidt.TabIndex = 7;
            this.Empidt.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.Empidt_MaskInputRejected);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(58, 66);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 29);
            this.label2.TabIndex = 6;
            this.label2.Text = "Employee id";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.Empdvg);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Controls.Add(this.Delete);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Controls.Add(this.Add);
            this.panel1.Controls.Add(this.Empedut);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Controls.Add(this.Empgent);
            this.panel1.Controls.Add(this.label7);
            this.panel1.Controls.Add(this.Empdobt);
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.Empnumt);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Empaddt);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.Empnamet);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.Empidt);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 131);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1350, 744);
            this.panel1.TabIndex = 8;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // Empdobt
            // 
            this.Empdobt.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Empdobt.CustomFormat = "dd/MM/yyyy";
            this.Empdobt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empdobt.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.Empdobt.Location = new System.Drawing.Point(37, 428);
            this.Empdobt.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Empdobt.Name = "Empdobt";
            this.Empdobt.Size = new System.Drawing.Size(188, 35);
            this.Empdobt.TabIndex = 15;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.label9);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1350, 131);
            this.panel2.TabIndex = 19;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.DodgerBlue;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.SystemColors.Control;
            this.label9.Location = new System.Drawing.Point(1183, 72);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 25);
            this.label9.TabIndex = 11;
            this.label9.Text = "Logout";
            this.label9.Click += new System.EventHandler(this.label9_Click);
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1203, 11);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 10;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // employeeTableAdapter
            // 
            this.employeeTableAdapter.ClearBeforeFill = true;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 827);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1350, 48);
            this.panel3.TabIndex = 20;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // Employee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1350, 875);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Employee";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Employee";
            this.Load += new System.EventHandler(this.Employee_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Empdvg)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRSDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.DataGridView Empdvg;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Button Delete;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Button Add;
        private System.Windows.Forms.ComboBox Empedut;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.ComboBox Empgent;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.MaskedTextBox Empnumt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.MaskedTextBox Empaddt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.MaskedTextBox Empnamet;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox Empidt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DateTimePicker Empdobt;
        private System.Windows.Forms.Panel panel2;
        private HRSDataSet1 hRSDataSet1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private HRSDataSet1TableAdapters.EmployeeTableAdapter employeeTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empaddDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empnumDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empdobDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empgenDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn empeduDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.PictureBox pictureBox5;
    }
}