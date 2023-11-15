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

namespace WinFormsApp1
{
    public partial class Form_login : Form
    {
        public Form_login()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\UserDB.mdf;Integrated Security=True;Connect Timeout=30");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            String username, password;
            username = text_username.Text;
            password = text_password.Text;

            conn.Open();

            try
            {
                String querry = "SELECT * FROM Login WHERE username = '" + text_username.Text + "' AND password = '" + text_password.Text + "'";

                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                if (dt.Rows.Count > 0)
                {
                    username = text_username.Text;
                    password = text_password.Text;

                    MessageBox.Show("Login Successful");

                    text_username.Clear();
                    text_password.Clear();

                }
                else
                {
                    MessageBox.Show("Invalid username or password");
                }

            }
            catch { MessageBox.Show("ERROR"); }
            finally { conn.Close(); }
        }

        private void button_clear_Click(object sender, EventArgs e)
        {
            text_username.Clear();
            text_password.Clear();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button_sign_Click(object sender, EventArgs e)
        {
            this.Hide();
            sign_form sf = new sign_form();
            sf.Show();
        }
    }
}