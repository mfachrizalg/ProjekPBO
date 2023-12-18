using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace LoginRegister
{
    public partial class lvl1 : Form
    {
        public string Username { get; set; }
        public int userLevel { get; set; }
        public lvl1()
        {
            InitializeComponent();
        }   
        SqlConnection conn = new SqlConnection(@"Data Source=pboapps.database.windows.net;Initial Catalog=User;User ID=arden;Password=2Matasaya_;Connect Timeout=30;Encrypt=True");
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void copy_button_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lvl1_soal.Text);
            MessageBox.Show("Copied!");
        }

        private void submit_button_Click(object sender, EventArgs e)
        {
            string username = Username;
            MessageBox.Show(username);
            string answer = box_answer.Text;
            if (answer == "selamat, kamu telah menyelesaikan latihan python pertamamu!") 
            {
                MessageBox.Show("Benar!");
                conn.Open();
                MessageBox.Show(userLevel.ToString());
                string query = "UPDATE Login SET userLevel = 2 WHERE username = '" + username  + "'";
                if (userLevel < 2)
                {

                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@userLevel", (int)2);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Level 2 Unlocked!");
                        }
                        else
                        {
                            MessageBox.Show("Ga ke update bro");
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Kamu pernah menyelesaikan level ini");
                }
                conn.Close();
            }
            else 
            {
                MessageBox.Show("Salah!");
                box_answer.Clear();
            }
        }
    }
}
