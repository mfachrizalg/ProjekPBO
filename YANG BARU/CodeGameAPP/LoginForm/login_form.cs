﻿using System;
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

namespace LoginForm
{
    public partial class login_form : Form
    {
        public login_form()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\UserDB.mdf;Integrated Security=True;Connect Timeout=30");

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
            String username, password;
            username = guna2TextBox1.Text;
            password = guna2TextBox2.Text;

            conn.Open();

            try
            {
                String querry = "SELECT * FROM Login WHERE username = '" + guna2TextBox1.Text + "' AND password = '" + guna2TextBox2.Text + "'";

                SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

                DataTable dt = new DataTable();

                sda.Fill(dt);

                if (guna2TextBox1.Text != string.Empty || guna2TextBox2.Text != string.Empty)
                {
                    if (guna2CheckBox1.Checked == true)
                    {
                        if (dt.Rows.Count > 0)
                        {
                            username = guna2TextBox1.Text;
                            password = guna2TextBox2.Text;

                            MessageBox.Show("Login Successful");

                            guna2TextBox1.Clear();
                            guna2TextBox2.Clear();

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

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TextBox2_TextChanged(object sender, EventArgs e)
        {
            guna2TextBox2.UseSystemPasswordChar = true;
        }

        private void guna2PictureBox3_Click(object sender, EventArgs e)
        {

        }

        private void check_show_CheckedChanged(object sender, EventArgs e)
        {
            if (check_show.Checked == true)
            {
                guna2TextBox2.UseSystemPasswordChar = false;
            }
            else
            {
                guna2TextBox2.UseSystemPasswordChar = true;
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            register_form f1 = new register_form();
            f1.Show();
        }
    }
}