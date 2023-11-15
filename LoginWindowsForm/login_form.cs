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

namespace LoginWindowsForm
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\Kuliah\Semester 3\PBO\Implementasi\UserDataDB.mdf;Integrated Security=True;Connect Timeout=30");


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void text_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void text_password_TextChanged(object sender, EventArgs e)
        {

        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            text_username.Clear();
            text_password.Clear();

            text_username.Focus();

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            String username, password;

            username = text_username.Text;
            password = text_password.Text;

            String querry = "SELECT COUNT(*) FROM Users WHERE Username='" + username + "' AND Password='" + password + "'";

            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            DataTable dt = new DataTable();
            sda.Fill(dt);

            try
            {
                if (dt.Rows[0][0].ToString() == "1")
                {
                    MessageBox.Show("Login Success");
                }
                else
                {
                    MessageBox.Show("Username or Password is incorrect");
                }

            }
            catch
            {
                MessageBox.Show("Error");

            }
            finally
            {
                conn.Close();

            }

        }

        private void login_form_Load(object sender, EventArgs e)
        {

        }
    }
}
