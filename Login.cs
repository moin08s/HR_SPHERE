using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace HR_SPHERE
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-O4EKNBI\SQLEXPRESS;Initial Catalog=HRS_Data;Integrated Security=True;");


        private void pictureBox2_Click(object sender, EventArgs e)
        {
            
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {
            if (UserTextBox.Text == "User" && PasswordTextBox.Text == "Password")
            {
                Home h = new Home();
                h.Show();
                this.Hide();

            }
            else
            {
                MessageBox.Show("Invalid Username or Password");
            }
        }

        private void Clearbutton_Click(object sender, EventArgs e)
        {
            UserTextBox.Clear();
            PasswordTextBox.Clear();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void PasswordTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void UserTextBox_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
