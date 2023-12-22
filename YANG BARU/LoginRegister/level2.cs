using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.StartPanel;

namespace LoginRegister
{
    public partial class level2 : UserControl
    {
        public string username{ get; set; }
        public int userLevel { get; set; }

        public level2()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=pboapps.database.windows.net;Initial Catalog=User;User ID=arden;Password=2Matasaya_;Connect Timeout=30;Encrypt=True");

        private void Clue_button_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Find rare object in that text");
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            string path = @"D:\Kuliah\Semester 3\PBO\App\ProjekPBO\YANG BARU\LoginRegister\level2.txt";

            if (File.Exists(path)) 
            {
                try 
                {
                    string text = File.ReadAllText(path);
                    Clipboard.SetText(text);
                    MessageBox.Show("Text copied to clipboard");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error");
                }
            }
            else
            {
                MessageBox.Show("File not found");
            }
        }

        private void lvl1_soal_Click(object sender, EventArgs e)
        {

        }
        public void getUserData(string username, int level) 
        {
            this.username = username;
            this.userLevel = level;
            //MessageBox.Show($"LEVEL2\nUsername: {this.username}\n UserLevel: {this.userLevel}");
        }
        private void submit_buttonn_Click(object sender, EventArgs e)
        {
            string username = this.username;
            int userLevel = this.userLevel;
            //MessageBox.Show(username);
            //MessageBox.Show(userLevel.ToString())

            if (box_answer.Text == "equality") 
            {
                MessageBox.Show("Correct");
                MessageBox.Show($"ur Level: {this.userLevel}");
                string query = "UPDATE UserData SET userLevel = 3 WHERE username = '" + username + "'";
                conn.Open();
                if (userLevel <= 2)
                {
                    using (SqlCommand command = new SqlCommand(query, conn))
                    {
                        command.Parameters.AddWithValue("@userLevel", (int)3);

                        int rowsAffected = command.ExecuteNonQuery();
                        if (rowsAffected > 0)
                        {
                            MessageBox.Show("Level 3 Unlocked!");
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
                MessageBox.Show("Wrong");
                box_answer.Clear();
            }
        }

        private void back_Click(object sender, EventArgs e)
        {
            if(!Dashboard.Instance.PanelUtama.Controls.ContainsKey("level1"))
            {
                level1 lv = new level1();
                lv.Username = username;
                lv.userLevel = userLevel;
                lv.getUserData(this.username, this.userLevel);
                lv.Dock = DockStyle.Fill;
                Dashboard.Instance.PanelUtama.Controls.Add(lv);
            }
            Dashboard.Instance.PanelUtama.Controls["level1"].BringToFront();
        }
    }
}
