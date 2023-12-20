using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegister
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=pboapps.database.windows.net;Initial Catalog=User;User ID=arden;Password=2Matasaya_;Connect Timeout=30;Encrypt=True");

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void pctBerdua_Click(object sender, EventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel4_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel6_Click(object sender, EventArgs e)
        {

        }

        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Terms_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void Login_Click(object sender, EventArgs e)
        {
            String username, password;
            username = boxUsername.Text;
            password = boxPassword.Text;
            conn.Open();

            try
            {
                String querry = "SELECT * FROM UserData WHERE username = '" + boxUsername.Text + "' AND password = '" + boxPassword.Text + "'";

                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                if (boxUsername.Text != string.Empty || boxPassword.Text != string.Empty)
                {
                    if (CheckBox.Checked == true)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            username = boxUsername.Text;
                            password = boxPassword.Text;

                            MessageBox.Show("Login Successful");
 /*                           var level1 = new lvl1();
                            var row = dt.Rows[0];
                            level1.Username = row["username"].ToString();
                            level1.userLevel = (int)row["userLevel"];
                            boxUsername.Clear();
                            boxPassword.Clear();
                            this.Hide();
                            level1.Show();*/
                            Dashboard dash = new Dashboard();
                            this.Hide();
                            dash.Show();
                        
                        }
                        else
                        {
                            MessageBox.Show("Invalid username or password");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Please check the agreement terms");
                    }


                }
                else
                {
                    MessageBox.Show("Please enter all the field");
                }



            }
            catch { MessageBox.Show("ERROR"); }
            finally { conn.Close(); }
        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void Privacy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void boxPassword_TextChanged(object sender, EventArgs e)
        {
            boxPassword.UseSystemPasswordChar = true;
        }

        private void check_show_CheckedChanged(object sender, EventArgs e)
        {
            if (check_show.Checked == true)
            {
                boxPassword.UseSystemPasswordChar = false;
            }
            else
            {
                boxPassword.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            register_form f1 = new register_form();
            f1.Show();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void or_Click(object sender, EventArgs e)
        {

        }

        private void Google_Click(object sender, EventArgs e)
        {

        }

        private void and_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void course_Click(object sender, EventArgs e)
        {

        }

        private void pnKiri_Paint(object sender, PaintEventArgs e)
        {

        }

        private void backgroundWorker1_DoWork(object sender, DoWorkEventArgs e)
        {

        }
    }
}