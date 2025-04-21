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
    public partial class AttendanceView : Form
    {
        public AttendanceView()
        {
            InitializeComponent();
        }
        readonly SqlConnection Con1 = new SqlConnection(@"Data Source=DESKTOP-O4EKNBI\SQLEXPRESS;Initial Catalog=HRS_Data;Integrated Security=True;");

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void AttendanceView_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'hRSDataSet.Attendance' table. You can move, or remove it, as needed.
            //attendanceTableAdapter.Fill(this.hRSDataSet.Attendance);

        }

        private void button2_Click(object sender, EventArgs e)
        {
            
  
                Con1.Open();
            string query66 = "select Empname from EmployeeTb1 where Empid='" + Empid.Text + "'";
                SqlCommand cmd66 = new SqlCommand(query66, Con1);
                object n = cmd66.ExecuteScalar();
                Con1.Close();
            

                if (n==null)
                {
                    MessageBox.Show("Employee not registed");
                    Con1.Close();
                }
                else
                {
                    try
                    {
                        Con1.Open();
                        string query6 = "select  Empid,Empname,rattendance,eattendance,datea from Attendance where Empid= '" + Empid.Text + "' and datea between '" + this.d1.Value + "' and '" + this.d2.Value + "'";
                        SqlDataAdapter sda = new SqlDataAdapter(query6, Con1);
                        SqlCommandBuilder b = new SqlCommandBuilder(sda);
                        var ds = new DataSet();
                        sda.Fill(ds);
                        DVG_a.DataSource = ds.Tables[0];
                        Con1.Close();
                    }
                    catch
                    {
                        MessageBox.Show($"Error in Data ");
                        Con1.Close();
                    }
                }
            
        }

        private void DVG_a_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Home_Click(object sender, EventArgs e)
        {
            Home v = new Home();
            v.Show();
            this.Hide();
        }
    }
}
