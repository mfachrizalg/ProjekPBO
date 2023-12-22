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

namespace LoginRegister
{
    public partial class userProfile : UserControl
    {
        public string username { get; set; }
        public string password { get; set; }
        public string email { get; set; }

        public userProfile()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=pboapps.database.windows.net;Initial Catalog=User;User ID=arden;Password=2Matasaya_;Connect Timeout=30;Encrypt=True");

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void getUserData(string username, string email) 
        {
            this.username = username;
            this.email = email;

            String querry = "SELECT * FROM UserData WHERE username = '" + username + "'";

            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            string searchColumn = "username";
            string searchVal = username;
            string resultColumn = "password";

            DataRow[] selectedRows = dt.Select($"{searchColumn} = '{searchVal}'");

            string password = (string)selectedRows[0][resultColumn];

            this.password = password;
        }

        private void Password_box_TextChanged_1(object sender, EventArgs e)
        {
            Password_box.UseSystemPasswordChar = true;
        }
        private void check_show_CheckedChanged(object sender, EventArgs e)
        {
            if (check_show.Checked == true)
            {
                Password_box.UseSystemPasswordChar = false;
            }
            else
            {
                Password_box.UseSystemPasswordChar = true;
            }
        }
        private void Email_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {

        }

        private void check_show_CheckedChanged_1(object sender, EventArgs e)
        {

        }

        private void Nama_Click(object sender, EventArgs e)
        {

        }

        private void userProfile_Load(object sender, EventArgs e)
        {
            Nama.Text = this.username;
            Username_box.Text = this.username;
            Email_box.Text = this.email;
            
        }
    }
}
