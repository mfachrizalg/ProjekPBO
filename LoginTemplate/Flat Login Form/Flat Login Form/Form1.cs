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

namespace Flat_Login_Form
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\ProjekPBO\UserDB.mdf;Integrated Security=True;Connect Timeout=30");


        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {


        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
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

        private void guna2CheckBox1_CheckedChanged(object sender, EventArgs e)
        {
                
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel7_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void guna2GradientPanel1_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void guna2TextBox3_TextChanged(object sender, EventArgs e)
        {
            guna2TextBox3.UseSystemPasswordChar = true;

        }

        private void guna2HtmlLabel4_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel3_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            guna2TextBox2.UseSystemPasswordChar = true;
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox1.Checked == true) 
            {
                guna2TextBox2.UseSystemPasswordChar = false;
                guna2TextBox3.UseSystemPasswordChar = false;
            }
            else 
            {
                guna2TextBox2.UseSystemPasswordChar = true;
                guna2TextBox3.UseSystemPasswordChar = true;
            }
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            this.Hide();
            login_form f1 = new login_form();
            f1.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            String username, password, confirm;
            username = guna2TextBox1.Text;
            password = guna2TextBox2.Text;
            confirm = guna2TextBox3.Text;

            SqlDataReader dr;
            SqlCommand cmd;

            conn.Open();

            try 
            {
                if (username != string.Empty && password != string.Empty && confirm != string.Empty) 
                {
                    if (password == confirm) 
                    {
                        cmd = new SqlCommand("SELECT * FROM Login WHERE username = '" + username + "'", conn);
                        dr = cmd.ExecuteReader();

                        if (dr.Read()) 
                        {
                            dr.Close();
                            MessageBox.Show("Username already exists", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else 
                        {
                            dr.Close();
                            cmd = new SqlCommand("INSERT INTO Login values(@username,@password)", conn);
                            cmd.Parameters.AddWithValue("@username", username);
                            cmd.Parameters.AddWithValue("@password", password);
                            cmd.ExecuteNonQuery();
                            guna2TextBox1.Clear();
                            guna2TextBox2.Clear();
                            guna2TextBox3.Clear();
                            MessageBox.Show("Account created successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                            login_form f1 = new login_form();
                            f1.Show();

                        }

                    }
                    else 
                    {
                        MessageBox.Show("Password does not match", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                else 
                {
                    MessageBox.Show("Please fill all the fields", "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch(Exception ex) { MessageBox.Show(ex.Message);  }
            finally { conn.Close();}
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}