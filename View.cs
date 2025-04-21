using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HR_SPHERE
{
    public partial class View : Form
    {
        public View()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O4EKNBI\SQLEXPRESS;Initial Catalog=HRS_Data;Integrated Security=True;");

        private void reset()
        {


            EmpidTBox.Text = "____________";
            Empadd.Text = "____________";
            Empname.Text = "____________";
            Empnum.Text = "____________";
            Empgen.Text = "____________";
            Empedu.Text = "____________";
            empdate.Text = "____________";
        }
        private void fetchdeta()
        {
            if (EmpidTBox.Text == "")
            {
                MessageBox.Show("Enter the Employee id");
                con.Close();
            }
            else
            {
                string query = "select *from EmployeeTb1 where Empid=" + textBox1.Text;
                SqlCommand cmd = new SqlCommand(query, con);
                DataTable dt = new DataTable();
                SqlDataAdapter sda = new SqlDataAdapter(cmd);
                sda.Fill(dt);
                foreach (DataRow dr in dt.Rows)
                {
                    EmpidTBox.Text = dr["Empid"].ToString();
                    Empadd.Text = dr["Empadd"].ToString();
                    Empname.Text = dr["Empname"].ToString();
                    Empnum.Text = dr["Empnum"].ToString();
                    Empgen.Text = dr["Empgen"].ToString();
                    Empedu.Text = dr["Empedu"].ToString();
                    empdate.Text = dr["Empdob"].ToString();

                    EmpidTBox.Visible = true;
                    Empadd.Visible = true;
                    Empname.Visible = true;
                    Empnum.Visible = true;
                    Empgen.Visible = true;
                    Empedu.Visible = true;
                    empdate.Visible = true;
                }
                con.Close();
            }
           
        }

        private void Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void View_Load(object sender, EventArgs e)
        {
            
        }

        private void Refreshr_Click(object sender, EventArgs e)
        {

            reset();
           
        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void Edit_Click(object sender, EventArgs e)
        {
            
            try
            {
                con.Open();
                string query6 = "select Empname from EmployeeTb1 where Empid='" + textBox1.Text + "'";
                SqlCommand cmd6 = new SqlCommand(query6, con);
                object n = cmd6.ExecuteScalar();
            
            if (n == null)
            {
                    reset();
                    MessageBox.Show("Employee not registed");
                con.Close();
                reset();
            }
            else
            {
                fetchdeta();
            }
            }
            catch 
            {
                reset();
                MessageBox.Show($"Error:Enter Valid Number..!");
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Empnum_Click(object sender, EventArgs e)
        {

        }

        private void Empadd_Click(object sender, EventArgs e)
        {

        }

        private void empdate_Click(object sender, EventArgs e)
        {

        }

        private void Empid_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox5_Click(object sender, EventArgs e)
        {
            Login l=new Login();
            l.Show();
            this.Hide();
        }
    }
}
