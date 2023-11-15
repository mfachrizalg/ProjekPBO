using Microsoft.Win32;
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
    public partial class sign_form : Form
    {
        public sign_form()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\acer\Documents\UserDB.mdf;Integrated Security=True;Connect Timeout=30");


        private void sign_form_Load(object sender, EventArgs e)
        {

        }
        private void button_create_Click(object sender, EventArgs e)
        {
            String username, password, con_password;
            username = text_username.Text;
            password = text_password.Text;
            con_password = text_confirm.Text;

            SqlDataReader dr;
            SqlCommand cmd;


            conn.Open();

            try
            {
                if (text_username.Text != string.Empty && text_password.Text != string.Empty && text_confirm.Text != string.Empty)
                {
                    if (text_password.Text == text_confirm.Text)
                    {
                        cmd = new SqlCommand("SELECT * FROM Login WHERE username = '" + text_username.Text + "'", conn);
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
                            text_confirm.Clear();
                            text_password.Clear();
                            text_username.Clear();
                            MessageBox.Show("Account created successfully", "SUCCESS", MessageBoxButtons.OK, MessageBoxIcon.Information);

                            this.Hide();
                            Form_login f1 = new Form_login();
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
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                conn.Close();
            }

        }

        private void button_login_Click(object sender, EventArgs e)
        {
            this.Hide();
            Form_login f1 = new Form_login();
            f1.Show();
        }

        private void text_username_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
