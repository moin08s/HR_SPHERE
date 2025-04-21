using System;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;
using System.Configuration;

namespace HR_SPHERE
{
    public partial class Attendance1 : Form
    {

        public Attendance1()
        {
            InitializeComponent();
        }
        readonly SqlConnection Con1 = new SqlConnection(@"Data Source=DESKTOP-O4EKNBI\SQLEXPRESS;Initial Catalog=HRS_Data;Integrated Security=True;");
        
        
        
                private void Pre()
        {

            Con1.Open();
            string query6 = "select Empname from EmployeeTb1 where Empid='" + Empid.Text + "'";
            SqlCommand cmd6 = new SqlCommand(query6, Con1);
            object n = cmd6.ExecuteScalar();

            if (n != null)
            {
                Empname.Text = n.ToString();
            }
           
            Con1.Close();

        }
        private void Populate1()
        {
            Con1.Open();
            string query1 = "delete Attendance where exists (select * from Attendance as a1 where  a1.Empid=Attendance.Empid and a1.datea=Attendance.datea and a1.rattendance=Attendance.rattendance and a1.attendance_id < Attendance.attendance_id);\r\n";
            SqlCommand cmd1 = new SqlCommand(query1, Con1);
            cmd1.ExecuteNonQuery();
            string query = "select Empid,Empname,rattendance,eattendance,datea from Attendance where datea='" + this.empdate.Value + "'order by Empid";
            SqlDataAdapter sda = new SqlDataAdapter(query, Con1);
            SqlCommandBuilder builder = new SqlCommandBuilder(sda);
            var ds = new DataSet();
            sda.Fill(ds);
            DVG_a.DataSource = ds.Tables[0];
            Con1.Close();
        }

        private void Attendance_Load(object sender, EventArgs e)
        {
            try
            {
                // TODO: This line of code loads data into the 'hRSDataSet.Attendance' table. You can move, or remove it, as needed.
                this.attendanceTableAdapter.Fill(this.hRSDataSet.Attendance);
                // TODO: This line of code loads data into the 'hRSDataSet.Attendance' table. You can move, or remove it, as needed.
                
                Populate1();
               
            }
            catch (Exception )
            {
               
            }

        }
        
        private void DVG_atttendace_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int a = e.RowIndex;
            if (a >= 0)
            {

                DataGridViewRow row = this.DVG_a.Rows[e.RowIndex];
                Empid.Text = row.Cells[0].Value.ToString();
                Empname.Text = row.Cells[1].Value.ToString();
            }
        }

        private void PictureBox2_Click(object sender, EventArgs e)
        {

            Home home = new Home();
            home.Show();
            this.Hide();
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Con1.Open();
            string query6 = "select Empname from EmployeeTb1 where Empid='" + Empid.Text + "'";
            SqlCommand cmd6 = new SqlCommand(query6, Con1);
            object n7 = cmd6.ExecuteScalar();
            Con1.Close();
            if (n7 == null)
            {
                MessageBox.Show("Employee not registed");
                Con1.Close();
            }
            else
            {
                int a1;
                string n;
                string ea = "No";
                if (rb.Checked == true)
                {
                    ea = "Yes";
                }
                Con1.Open();
                string query61 = "select max(attendance_id) from Attendance";
                SqlCommand cmd61 = new SqlCommand(query61, Con1);
                object n11 = cmd61.ExecuteScalar();

                if (n11 == null)
                {
                    a1 = 1;
                }
                else
                {


                    n = n11.ToString();
                    if (n == "")
                    {
                        a1 = 1;
                    }

                    else
                    {
                        a1 = int.Parse(n);

                    }
                }



                a1++;






                string query003 = "select Empname from EmployeeTb1 where Empid='" + Empid.Text + "'";
                SqlCommand cmd003 = new SqlCommand(query003, Con1);
                object n1 = cmd003.ExecuteScalar();
                if (n1 == null)
                {
                    Con1.Close();
                }
                else
                {



                    if (r1.Checked == true || r2.Checked == true || r3.Checked == true)
                    {
                        string ex;
                        if (r1.Checked == true)
                        {
                            ex = "Present";
                        }
                        else
                        {
                            ex = "Absent";
                        }

                        if (r3.Checked == true)
                        {
                            MessageBox.Show("Please Firstly get presentity of Employee the use Update");
                            Con1.Close();
                        }
                        else
                        {


                            string query03 = "select Empname from Attendance where Empid='" + Empid.Text + "'and datea='" + this.empdate.Value + "'";
                            SqlCommand cmd03 = new SqlCommand(query03, Con1);
                            object n13 = cmd03.ExecuteScalar();
                            string ad;
                            if (n13 != null)
                            {
                                ad = n13.ToString();
                            }
                            else
                            {
                                ad = "";
                            }

                            if (ad == "")
                            {

                                
                                string query = "insert into Attendance values('" + a1 + "','" + Empid.Text + "','" + Empname.Text + "','" + ex + "','" + ea + "','" + this.empdate.Value + "')";
                                SqlCommand cmd1 = new SqlCommand(query, Con1);
                                cmd1.ExecuteNonQuery();
                                Con1.Close();

                            }
                            else
                            {


                                MessageBox.Show("Please Update the Attendance for changes");
                                Con1.Close();
                            }

                        }





                    }
                    else
                    {
                        MessageBox.Show("Select the button");
                        Con1.Close();
                    }
                }
                Populate1();
            }

        }

        private void Update_button_Click(object sender, EventArgs e)
        {
            Con1.Open();
            string query6 = "select Empname from EmployeeTb1 where Empid='" + Empid.Text + "'";
            SqlCommand cmd6 = new SqlCommand(query6,Con1);
            object n = cmd6.ExecuteScalar();
            Con1.Close ();

            if (n == null)
            {
                Empid.Clear();
                MessageBox.Show("Employee not registed");
                Con1.Close();
            }
            else
            {

                string ea = "No";
                if (rb.Checked == true)
                {
                    ea = "Yes";
                }
                if (r3.Checked == true)
                {
                    Con1.Open();
                    string l = "Leave";
                    string query2 = "update Attendance set rattendance='" + l + "' where Empid='" + Empid.Text + "' and datea ='" + this.empdate.Value + "'";
                    SqlCommand cmd2 = new SqlCommand(query2, Con1);
                    cmd2.ExecuteNonQuery();
                    Con1.Close();
                    Populate1();
                }
                if (r1.Checked == true)
                {
                    string p = "Present";
                    Con1.Open();
                    string query2 = "update Attendance set rattendance='" + p + "' where Empid='" + Empid.Text + "' and datea ='" + this.empdate.Value + "' ";
                    SqlCommand cmd2 = new SqlCommand(query2, Con1);
                    cmd2.ExecuteNonQuery();
                    Con1.Close();
                    Populate1();
                }
                if (r2.Checked == true)
                {
                    Con1.Open();
                    string a = "Absent";
                    string query2 = "update Attendance set rattendance='" + a + "' where Empid='" + Empid.Text + "' and datea ='" + this.empdate.Value + "'";
                    SqlCommand cmd2 = new SqlCommand(query2, Con1);

                    cmd2.ExecuteNonQuery();
                    Con1.Close();
                    Populate1();
                }
                Con1.Open();

                string query24 = "update Attendance set eattendance='" + ea + "' where Empid='" + Empid.Text + "' and datea ='" + this.empdate.Value + "'";
                SqlCommand cmd24 = new SqlCommand(query24, Con1);
                cmd24.ExecuteNonQuery();

                cmd24.ExecuteNonQuery();
                Con1.Close();
                Populate1();
            }


        }

        private void Button4_Click(object sender, EventArgs e)
        {
            Empid.Clear();
        }

        private void Empid_TextChanged(object sender, EventArgs e)
        {
            Empname.Clear();
            Pre();
            

        }

        private void Empdate_ValueChanged(object sender, EventArgs e)
        {
            Populate1();
        }

        private void AttendanceBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home h = new Home();
            h.Show();
            this.Hide();
        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {
            Login l=new Login();
            l.Show();
            this.Hide();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void extrahours_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void extrahours_MouseClick(object sender, MouseEventArgs e)
        {
            
        }

        private void Empid_Enter(object sender, EventArgs e)
        {
            
        }

        private void Empid_FontChanged(object sender, EventArgs e)
        {
            
        }

        private void Empid_VisibleChanged(object sender, EventArgs e)
        {
            
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
