using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_SPHERE
{
    public partial class Employee : Form
    {
        public Employee()
        {
            InitializeComponent();
        }
        readonly SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O4EKNBI\SQLEXPRESS;Initial Catalog=HRS_Data;Integrated Security=True;");

        private void Employee_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRSDataSet1.Employee' table. You can move, or remove it, as needed.
            //this.employeeTableAdapter.Fill(this.hRSDataSet1.Employee);
            // TODO: This line of code loads data into the 'hRSDataSet3.Employee' table. You can move, or remove it, as needed.
            // TODO: This line of code loads data into the 'hRSDataSet2.Employee' table. You can move, or remove it, as needed.
            Populate();
        }

        private void Add_Click(object sender, EventArgs e)
        {
            if (Empidt.Text == "" || Empnamet.Text == "" || Empaddt.Text == "" || Empnumt.Text == ""|| Empgent.Text==""||Empedut.Text=="")
            {
                MessageBox.Show("Missing Information");

            }
            else
            {
                try
                {

                    con.Open();


                    string query6 = "select Empname from EmployeeTb1 where Empid='" + Empidt.Text + "'";
                    SqlCommand cmd6 = new SqlCommand(query6, con);
                    object n = cmd6.ExecuteScalar();
                    Regex p = new Regex(@"^[0-9]{10}$");
                    if (p.IsMatch(Empnumt.Text))
                    {

                        if (n == null)
                        {
                            string query = "insert into EmployeeTb1 values('" + Empidt.Text + "','" + Empnamet.Text + "','" + Empaddt.Text + "','" + Empnumt.Text + "','" + this.Empdobt.Value + "','" + Empgent.SelectedItem.ToString() + "','" + Empedut.SelectedItem.ToString() + "')";
                            SqlCommand cmd1 = new SqlCommand(query, con);
                            cmd1.ExecuteNonQuery();
                            MessageBox.Show("Employee Successfully Added");
                            con.Close();
                            Populate();

                        }
                        else
                        {
                            MessageBox.Show("Employee id is already used");
                            con.Close();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Contact number is invalid");
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }

            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();






        }
        private void Populate()
        {
            con.Open();
            string query = "select * from EmployeeTb1";
            SqlDataAdapter sda = new SqlDataAdapter(query, con);
            //SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            Empdvg.DataSource = ds.Tables[0];
            con.Close();
        }

        private void Delete_Click(object sender, EventArgs e)
        {
            if (Empidt.Text == "")
            {
                MessageBox.Show("Enter the employee id");
            }
            else
            {

                try
                {
                    con.Open();
                    string query = "delete from Attendance where Empid='" + Empidt.Text + "';";
                    string query1 = "delete from EmployeeTb1 where Empid='" + Empidt.Text + "';";

                    SqlCommand cmd = new SqlCommand(query, con);
                    SqlCommand cmd2 = new SqlCommand(query1, con);

                    cmd.ExecuteNonQuery();
                    cmd2.ExecuteNonQuery();


                    MessageBox.Show("Employee Deleted Successfully");
                    con.Close();
                    Populate();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }
            }
        }

       
        
        
        
        
        
    private void Empdvg_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.RowIndex;
            if (a >= 0)
            {
                DataGridViewRow row = this.Empdvg.Rows[e.RowIndex];
                Empidt.Text = row.Cells[0].Value.ToString();
                Empnamet.Text = row.Cells[1].Value.ToString();
                Empaddt.Text = row.Cells[2].Value.ToString();
                Empgent.SelectedItem = row.Cells[5].Value.ToString();
                Empnumt.Text = row.Cells[3].Value.ToString();
                Empedut.SelectedItem = row.Cells[6].Value.ToString();
            }
        }

        private void Edit_Click(object sender, EventArgs e)
        {

            if (Empidt.Text == "" || Empnamet.Text == "" || Empaddt.Text == "" || Empnumt.Text == "")
            {
                MessageBox.Show("Missing Information");
            }
            else
            {
                try
                {
                    Regex p = new Regex(@"^[0-9]{10}$");
                    if (p.IsMatch(Empnumt.Text))
                    {
                        con.Open();
                        string query = "update EmployeeTb1 set Empname='" + Empnamet.Text + "',Empadd='" + Empaddt.Text + "',Empdob='" + this.Empdobt.Value + "',Empnum='" + Empnumt.Text + "',Empedu='" + Empedut.SelectedItem.ToString() + "',Empgen='" + Empgent.SelectedItem.ToString() + "'where Empid='" + Empidt.Text + "';";
                        SqlCommand cmd = new SqlCommand(query, con);
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Employee Update Successfully");
                        Empidt.Clear();
                        Empnamet.Clear();
                        Empaddt.Clear();
                        Empnumt.Clear();




                        con.Close();
                        Populate();
                    }
                    else
                    {
                        MessageBox.Show("Contact number is invalid");
                        con.Close();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    con.Close();
                }

            }

        }

        private void Home_Click(object sender, EventArgs e)
        {

            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login l=new Login();
            l.Show();
            this.Hide();
        }

        private void label9_Click(object sender, EventArgs e)
        {
            Login l = new Login();
            l.Show();
            this.Hide();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Empidt_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
