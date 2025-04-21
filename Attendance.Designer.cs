namespace HR_SPHERE
{
    partial class Attendance1
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Attendance1));
            this.label2 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.Empname = new System.Windows.Forms.TextBox();
            this.Empid = new System.Windows.Forms.TextBox();
            this.DVG_a = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.attendanceBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.hRSDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.hRSDataSet = new HR_SPHERE.HRSDataSet();
            this.attendanceBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.attendanceBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.empdate = new System.Windows.Forms.DateTimePicker();
            this.button4 = new System.Windows.Forms.Button();
            this.r3 = new System.Windows.Forms.RadioButton();
            this.r2 = new System.Windows.Forms.RadioButton();
            this.r1 = new System.Windows.Forms.RadioButton();
            this.button2 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.rb = new System.Windows.Forms.CheckBox();
            this.label1 = new System.Windows.Forms.Label();
            this.Home = new System.Windows.Forms.Button();
            this.update_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label6 = new System.Windows.Forms.Label();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.attendanceTableAdapter = new HR_SPHERE.HRSDataSetTableAdapters.AttendanceTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.DVG_a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRSDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRSDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.DodgerBlue;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(76, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(514, 55);
            this.label2.TabIndex = 15;
            this.label2.Text = "Employee Attendance";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(310, 104);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(193, 29);
            this.label4.TabIndex = 19;
            this.label4.Text = "Employee Name";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(24, 104);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(148, 29);
            this.label5.TabIndex = 18;
            this.label5.Text = "Employee id";
            // 
            // Empname
            // 
            this.Empname.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empname.Location = new System.Drawing.Point(316, 150);
            this.Empname.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Empname.Name = "Empname";
            this.Empname.Size = new System.Drawing.Size(149, 35);
            this.Empname.TabIndex = 13;
            // 
            // Empid
            // 
            this.Empid.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Empid.Location = new System.Drawing.Point(29, 150);
            this.Empid.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Empid.Name = "Empid";
            this.Empid.Size = new System.Drawing.Size(149, 35);
            this.Empid.TabIndex = 12;
            this.Empid.FontChanged += new System.EventHandler(this.Empid_FontChanged);
            this.Empid.TextChanged += new System.EventHandler(this.Empid_TextChanged);
            this.Empid.VisibleChanged += new System.EventHandler(this.Empid_VisibleChanged);
            this.Empid.Enter += new System.EventHandler(this.Empid_Enter);
            // 
            // DVG_a
            // 
            this.DVG_a.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.DVG_a.AllowUserToAddRows = false;
            this.DVG_a.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.NullValue = "Blank";
            this.DVG_a.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DVG_a.AutoGenerateColumns = false;
            this.DVG_a.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DVG_a.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedHeaders;
            this.DVG_a.BackgroundColor = System.Drawing.Color.DeepSkyBlue;
            this.DVG_a.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DVG_a.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DVG_a.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DVG_a.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5});
            this.DVG_a.DataSource = this.attendanceBindingSource2;
            this.DVG_a.GridColor = System.Drawing.Color.DodgerBlue;
            this.DVG_a.Location = new System.Drawing.Point(582, 58);
            this.DVG_a.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DVG_a.Name = "DVG_a";
            this.DVG_a.ReadOnly = true;
            this.DVG_a.RowHeadersWidth = 62;
            this.DVG_a.RowTemplate.Height = 28;
            this.DVG_a.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.DVG_a.Size = new System.Drawing.Size(728, 595);
            this.DVG_a.TabIndex = 9;
            this.DVG_a.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DVG_atttendace_CellContentClick);
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Empid";
            this.dataGridViewTextBoxColumn1.HeaderText = "Employee Id";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Empname";
            this.dataGridViewTextBoxColumn2.HeaderText = "Employee Name";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "rattendance";
            this.dataGridViewTextBoxColumn3.HeaderText = "Regular Attendance";
            this.dataGridViewTextBoxColumn3.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "eattendance";
            this.dataGridViewTextBoxColumn4.HeaderText = "Extra Attendance";
            this.dataGridViewTextBoxColumn4.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "datea";
            this.dataGridViewTextBoxColumn5.HeaderText = "Date";
            this.dataGridViewTextBoxColumn5.MinimumWidth = 6;
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // attendanceBindingSource2
            // 
            this.attendanceBindingSource2.DataMember = "Attendance";
            this.attendanceBindingSource2.DataSource = this.hRSDataSetBindingSource;
            // 
            // hRSDataSetBindingSource
            // 
            this.hRSDataSetBindingSource.DataSource = this.hRSDataSet;
            this.hRSDataSetBindingSource.Position = 0;
            // 
            // hRSDataSet
            // 
            this.hRSDataSet.DataSetName = "HRSDataSet";
            this.hRSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // attendanceBindingSource1
            // 
            this.attendanceBindingSource1.DataMember = "Attendance";
            this.attendanceBindingSource1.DataSource = this.hRSDataSetBindingSource;
            // 
            // attendanceBindingSource
            // 
            this.attendanceBindingSource.DataMember = "Attendance";
            this.attendanceBindingSource.CurrentChanged += new System.EventHandler(this.AttendanceBindingSource_CurrentChanged);
            // 
            // empdate
            // 
            this.empdate.CustomFormat = "dd-MM-yyyy";
            this.empdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.empdate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.empdate.Location = new System.Drawing.Point(1144, 15);
            this.empdate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.empdate.Name = "empdate";
            this.empdate.Size = new System.Drawing.Size(165, 35);
            this.empdate.TabIndex = 8;
            this.empdate.ValueChanged += new System.EventHandler(this.Empdate_ValueChanged);
            // 
            // button4
            // 
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.Location = new System.Drawing.Point(186, 152);
            this.button4.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(35, 35);
            this.button4.TabIndex = 7;
            this.button4.Text = "X";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // r3
            // 
            this.r3.AutoSize = true;
            this.r3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r3.Location = new System.Drawing.Point(29, 319);
            this.r3.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.r3.Name = "r3";
            this.r3.Size = new System.Drawing.Size(103, 33);
            this.r3.TabIndex = 6;
            this.r3.TabStop = true;
            this.r3.Text = "Leave";
            this.r3.UseVisualStyleBackColor = true;
            // 
            // r2
            // 
            this.r2.AutoSize = true;
            this.r2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r2.Location = new System.Drawing.Point(29, 278);
            this.r2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.r2.Name = "r2";
            this.r2.Size = new System.Drawing.Size(112, 33);
            this.r2.TabIndex = 5;
            this.r2.TabStop = true;
            this.r2.Text = "Absent";
            this.r2.UseVisualStyleBackColor = true;
            // 
            // r1
            // 
            this.r1.AutoSize = true;
            this.r1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.r1.Location = new System.Drawing.Point(29, 234);
            this.r1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.r1.Name = "r1";
            this.r1.Size = new System.Drawing.Size(121, 33);
            this.r1.TabIndex = 4;
            this.r1.TabStop = true;
            this.r1.Text = "Present";
            this.r1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.LimeGreen;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(14, 416);
            this.button2.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(107, 50);
            this.button2.TabIndex = 2;
            this.button2.Text = "Submit";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(56, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 16;
            this.pictureBox1.TabStop = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.panel1.Controls.Add(this.rb);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.Home);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Empname);
            this.panel1.Controls.Add(this.Empid);
            this.panel1.Controls.Add(this.DVG_a);
            this.panel1.Controls.Add(this.empdate);
            this.panel1.Controls.Add(this.button4);
            this.panel1.Controls.Add(this.r3);
            this.panel1.Controls.Add(this.r2);
            this.panel1.Controls.Add(this.r1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Controls.Add(this.update_button);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 131);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1328, 728);
            this.panel1.TabIndex = 14;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // rb
            // 
            this.rb.AutoSize = true;
            this.rb.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.rb.Location = new System.Drawing.Point(316, 255);
            this.rb.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.rb.Name = "rb";
            this.rb.Size = new System.Drawing.Size(81, 33);
            this.rb.TabIndex = 29;
            this.rb.Text = "Yes";
            this.rb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(310, 220);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 29);
            this.label1.TabIndex = 27;
            this.label1.Text = "Overtime";
            // 
            // Home
            // 
            this.Home.BackColor = System.Drawing.Color.Gold;
            this.Home.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Home.ForeColor = System.Drawing.Color.White;
            this.Home.Location = new System.Drawing.Point(286, 418);
            this.Home.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Home.Name = "Home";
            this.Home.Size = new System.Drawing.Size(111, 48);
            this.Home.TabIndex = 24;
            this.Home.Text = "Home";
            this.Home.UseVisualStyleBackColor = false;
            this.Home.Click += new System.EventHandler(this.Home_Click);
            // 
            // update_button
            // 
            this.update_button.BackColor = System.Drawing.Color.LimeGreen;
            this.update_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.update_button.Location = new System.Drawing.Point(146, 416);
            this.update_button.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.update_button.Name = "update_button";
            this.update_button.Size = new System.Drawing.Size(107, 50);
            this.update_button.TabIndex = 1;
            this.update_button.Text = "Update";
            this.update_button.UseVisualStyleBackColor = false;
            this.update_button.Click += new System.EventHandler(this.Update_button_Click);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(0, 0);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1328, 131);
            this.panel2.TabIndex = 18;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.DodgerBlue;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(1204, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(84, 25);
            this.label6.TabIndex = 19;
            this.label6.Text = "Logout";
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(1234, 0);
            this.pictureBox5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(45, 50);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 18;
            this.pictureBox5.TabStop = false;
            this.pictureBox5.Click += new System.EventHandler(this.pictureBox5_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.DodgerBlue;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 811);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(1328, 48);
            this.panel3.TabIndex = 21;
            // 
            // attendanceTableAdapter
            // 
            this.attendanceTableAdapter.ClearBeforeFill = true;
            // 
            // Attendance1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1328, 859);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Attendance1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Attendance";
            this.Load += new System.EventHandler(this.Attendance_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DVG_a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRSDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hRSDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.attendanceBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox Empname;
        private System.Windows.Forms.TextBox Empid;
        private System.Windows.Forms.DataGridView DVG_a;
        private System.Windows.Forms.DateTimePicker empdate;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.RadioButton r3;
        private System.Windows.Forms.RadioButton r2;
        private System.Windows.Forms.RadioButton r1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button update_button;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.BindingSource attendanceBindingSource;
      // private System.Windows.Forms.DataGridViewTextBoxColumn empidDataGridViewTextBoxColumn;
       // private System.Windows.Forms.DataGridViewTextBoxColumn //empnameDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn rattendanceDataGridViewTextBoxColumn;
      //  private System.Windows.Forms.DataGridViewTextBoxColumn eattendanceDataGridViewTextBoxColumn;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dateaDataGridViewTextBoxColumn;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.BindingSource hRSDataSetBindingSource;
        private HRSDataSet hRSDataSet;
        private System.Windows.Forms.BindingSource attendanceBindingSource1;
        private HRSDataSetTableAdapters.AttendanceTableAdapter attendanceTableAdapter;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.Button Home;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource attendanceBindingSource2;
        private System.Windows.Forms.CheckBox rb;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
    }
}