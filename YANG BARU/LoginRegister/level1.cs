﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginRegister
{
    public partial class level1 : UserControl
    {
        public string Username { get; set; }
        public int userLevel { get; set; }
        public level1()
        {
            InitializeComponent();
        }

        SqlConnection conn = new SqlConnection(@"Data Source=pboapps.database.windows.net;Initial Catalog=User;User ID=arden;Password=2Matasaya_;Connect Timeout=30;Encrypt=True");
        private void Clue_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("A = D");
        }

        private void box_answer_TextChanged(object sender, EventArgs e)
        {
        }


        private int getLevel()
        {
            User user = new User();
            user.username = Username;

            MessageBox.Show("ur username: " + user.username);
            string querry = "SELECT * FROM UserData WHERE username = '" + user.username + "'";

            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            string searchColumn = "username";
            string searchVal = user.username;
            string resultColumn = "userLevel";

            DataRow[] selectedRows = dt.Select($"{searchColumn} = '{searchVal}'");

            MessageBox.Show(selectedRows[0].ToString());

            int level = (int)selectedRows[0][resultColumn];

            return level;
        }

        public void getUserData(string username, int userLvl)
        {
            this.Username = username;
            this.userLevel = userLvl;
            //MessageBox.Show($"LEVEL1\nUsername: {this.Username}\n UserLevel: {this.userLevel}");
        }
        private void submit_buttonn_Click(object sender, EventArgs e)
        {
            string username = this.Username;
            int userLevel = this.userLevel;
            //MessageBox.Show(username);
            //MessageBox.Show(userLevel.ToString());

            /*String querry = "SELECT * FROM UserData WHERE username = '" + username + "'";

            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            string searchColumn = "username";
            string searchVal = username;
            string resultColumn = "userLevel";

            DataRow[] selectedRows = dt.Select($"{searchColumn} = '{searchVal}'");

            int level = (int)selectedRows[0][resultColumn];
            userLevel = level;
            this.userLevel = (int)level;*/

            string answer = box_answer.Text;
            if (answer == "selamat, kamu telah menyelesaikan latihan python pertamamu!")
            {
                MessageBox.Show("Benar!");
                //MessageBox.Show(userLevel.ToString());
                string query = "UPDATE UserData SET userLevel = 2 WHERE username = '" + username + "'";
                conn.Open();
                if (userLevel <= 1)
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
                            MessageBox.Show("Error to access database");
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

        private void back_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            home.Dock = DockStyle.Fill;
            Dashboard.Instance.PanelUtama.Controls.Add(home);
            Dashboard.Instance.PanelUtama.Controls["Home"].BringToFront();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string soal = lvl1_soal.Text + label1.Text;
            Clipboard.SetText(soal);
            MessageBox.Show("Copied");
        }

        private void guna2GradientButton2_Click(object sender, EventArgs e)
        {
            //MessageBox.Show(this.userLevel.ToString());
            if (this.userLevel >= 2) 
            {
                if (!Dashboard.Instance.PanelUtama.Controls.ContainsKey("level2"))
                {
                    level2 lv = new level2();
                    lv.username = Username;
                    lv.userLevel = this.userLevel;
                    lv.Dock = DockStyle.Fill;
                    Dashboard.Instance.PanelUtama.Controls.Add(lv);
                }
                Dashboard.Instance.PanelUtama.Controls["level2"].BringToFront();
            }
            else 
            {
                MessageBox.Show("Kamu belum menyelesaikan level ini");
            }
            
        }
    }
}
