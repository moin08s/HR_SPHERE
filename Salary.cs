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
    public partial class Salary : Form
    {
        public Salary()
        {
            InitializeComponent();
        }
        SqlConnection con1 = new SqlConnection(@"Data Source=DESKTOP-O4EKNBI\SQLEXPRESS;Initial Catalog=HRS_Data;Integrated Security=True;");

        private void pre()
        {

            try
            {
                con1.Open();
                string query6 = "select Empname from EmployeeTb1 where Empid='" + Empid.Text + "'";
                SqlCommand cmd6 = new SqlCommand(query6, con1);
                object n = cmd6.ExecuteScalar();

                if (n != null)
                {
                    Empnamet.Text = n.ToString();
                }
                con1.Close();
            }
            catch {
                MessageBox.Show("Enter Number :");
                con1.Close() ;
            }

        }
        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void pel_TextChanged(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void ewt_TextChanged(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void adc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void lvc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void pdc_TextChanged(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void Ed_TextChanged(object sender, EventArgs e)
        {

        }

        private void print_Click(object sender, EventArgs e)
        {
            con1.Open();
            string query66 = "select Empname from EmployeeTb1 where Empid='" + Empid.Text + "'";
            SqlCommand cmd66 = new SqlCommand(query66, con1);
            object nf = cmd66.ExecuteScalar();
            con1.Close();


            if (nf == null)
            {
                MessageBox.Show("Employee not registed");
                con1.Close();
            }
            else
            {
                con1.Open();
                int r;
                string query003 = "select Empname from EmployeeTb1 where Empid='" + Empid.Text + "'";
                SqlCommand cmd003 = new SqlCommand(query003, con1);
                object n1 = cmd003.ExecuteScalar();
                if (n1 == null)
                {
                    MessageBox.Show("Employee not registed");
                    con1.Close();
                }
                else
                {

                    if (Ed.Text == "")
                    {
                        MessageBox.Show("Enter Daily Salary ");
                        con1.Close();
                    }
                    else
                    {
                        String v = Ed.Text;
                        r = int.Parse(v);




                        string query1 = "select Count(*) As Total From Attendance where Attendance.rattendance='Present' and Empid='" + Empid.Text + "' AND datea BETWEEN '" + this.d1.Value + "'AND'" + this.d2.Value + "'";
                        SqlCommand cmd1 = new SqlCommand(query1, con1);
                        object n = cmd1.ExecuteScalar();
                        string b = n.ToString();
                        int a = int.Parse(b);
                        int rt = a * r;
                        
                        pdc.Text = b;


                        string query2 = "select Count(*) As Total From Attendance where Attendance.rattendance='Leave' and Empid='" + Empid.Text + "' AND datea BETWEEN '" + this.d1.Value + "'AND'" + this.d2.Value + "'";
                        SqlCommand cmd2 = new SqlCommand(query2, con1);
                        object n2 = cmd2.ExecuteScalar();
                        string b2 = n2.ToString();
                        int a2 = int.Parse(b2);
                        int lt = a2 * (r / 2);
                        string m1 = (lt).ToString();
                        lvc.Text = b2;


                        string query3 = "select Count(*) As Total From Attendance where Attendance.eattendance='Yes' and Empid='" + Empid.Text + "' AND datea BETWEEN '" + this.d1.Value + "'AND'" + this.d2.Value + "'";
                        SqlCommand cmd3 = new SqlCommand(query3, con1);
                        object n3 = cmd3.ExecuteScalar();
                        string b3 = n3.ToString();
                        int a3 = int.Parse(b2);
                        int et = a2 * (r / 2);
                        string m2 = (lt).ToString();


                        ewt.Text = b3;

                        string query4 = "select Count(*) As Total From Attendance where Attendance.rattendance='Absent' and Empid='" + Empid.Text + "' AND datea BETWEEN '" + this.d1.Text + "'AND'" + this.d2.Text + "'";
                        SqlCommand cmd4 = new SqlCommand(query4, con1);
                        object n4 = cmd2.ExecuteScalar();
                        string b4 = n4.ToString();
                        adc.Text = b4;

                        string mt = (lt + rt).ToString();
                        ;




                        rsalt.Text = mt;
                        Ersalt.Text = m2;

                        int pnum;


                        String l = pel.Text;
                        if (l == "")
                        {

                            pnum = 0;
                        }
                        else
                        {
                            pnum = int.Parse(l);
                        }





                        string tt = (lt + rt + et - pnum).ToString();
                        tsalt.Text = tt;
                        pel.Text = (pnum).ToString();

                        con1.Close();
                    }
                }

            }
        }

        private void tsalt_TextChanged(object sender, EventArgs e)
        {

        }

        private void rsalt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Ersalt_TextChanged(object sender, EventArgs e)
        {

        }

        private void Empnamet_TextChanged(object sender, EventArgs e)
        {

        }

        private void Empid_TextChanged(object sender, EventArgs e)
        {
            Empnamet.Clear();
            pre();
        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void d2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void d1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Add_Click(object sender, EventArgs e)
        {
            Empid.Clear();
            rsalt.Clear();
            tsalt.Clear();
            Ersalt.Clear();
            Empnamet.Clear();
            adc.Clear();
            ewt.Clear();
            pdc.Clear();
            lvc.Clear();
            this.d1.Text = DateTime.Now.ToString();
            this.d1.Text = DateTime.Now.ToString();
            pel.Clear();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {

            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Salary_Load(object sender, EventArgs e)
        {

        }

        private void Home_Click_1(object sender, EventArgs e)
        {
            Home Home = new Home();
            Home.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login l=new Login();
            l.Show();
            this.Hide();
        }
    }
}
