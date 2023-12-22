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
        public event EventHandler<ColorChangedEventArgs> LightModeClicked;
        public event EventHandler<ColorChangedEventArgs> DarkModeClicked;
        public event EventHandler<EventArgs> GlobalSettingsAppearanceChanged;
        public string username { get; set; }
        public string email { get; set; }
        public string password { get; set; }
        public userProfile()
        {
            InitializeComponent();
            Settings.Instance.LightModeClicked += HandleLightModeClicked;
            Settings.Instance.DarkModeClicked += HandleDarkModeClicked;
        }
        SqlConnection conn = new SqlConnection(@"Data Source=pboapps.database.windows.net;Initial Catalog=User;User ID=arden;Password=2Matasaya_;Connect Timeout=30;Encrypt=True");

        private void HandleLightModeClicked(object sender, ColorChangedEventArgs e)
        {
            pnUProfile.BackColor = Color.White;
            Profile_Info.BackColor = Color.White;
            pnLearning.BackColor = Color.White;
            pnLearning.FillColor = Color.FromArgb(241, 244, 254);
            check_show.BackColor = Color.FromArgb(236, 238, 245);

            submit_buttonn.BackColor = Color.FromArgb(241, 244, 254);
            Delete.BackColor = Color.FromArgb(241, 244, 254);
            Delete.FillColor = Color.FromArgb(241, 244, 254);
            Delete.FillColor2 = Color.FromArgb(241, 244, 254);
            Delete.BorderColor = Color.Black;
            Delete.ForeColor = Color.Black;

            Username.ForeColor = Color.Black;
            Username.BackColor = Color.FromArgb(241, 244, 254);

            Nama.ForeColor = Color.Black;
            Nama.BackColor = Color.White;

            Email.BackColor = Color.White;

            Password.BackColor = Color.White;

            Username_box.FillColor = Color.FromArgb(241, 244, 254);
            Username_box.BackColor = Color.White;
            Username_box.BorderColor = Color.FromArgb(213, 218, 223);

            Email_box.FillColor = Color.FromArgb(236, 238, 245);
            Email_box.BackColor = Color.White;
            Email_box.BorderColor = Color.FromArgb(213, 218, 223);

            Password_box.FillColor = Color.FromArgb(236, 238, 245);
            Password_box.BackColor = Color.White;
            Password_box.BorderColor = Color.FromArgb(213, 218, 223);

            ChangeEmail.BackColor = Color.White;
            ChangeEmail.ForeColor = Color.Black;
            ChangeEmail.FillColor = Color.FromArgb(241, 244, 254);
            ChangeEmail.FillColor2 = Color.FromArgb(241, 244, 254);

            ChangePassword.BackColor = Color.White;
            ChangePassword.ForeColor = Color.Black;
            ChangePassword.FillColor = Color.FromArgb(241, 244, 254);
            ChangePassword.FillColor2 = Color.FromArgb(241, 244, 254);

        }
        private void HandleDarkModeClicked(object sender, ColorChangedEventArgs e)
        {
            pnUProfile.BackColor = Color.FromArgb(35, 36, 41);
            Profile_Info.BackColor = Color.FromArgb(35, 36, 41);
            check_show.BackColor = Color.FromArgb(28, 28, 36);

            Username.ForeColor = Color.White;
            Username.BackColor = Color.FromArgb(35, 36, 41);

            Username_box.FillColor = Color.FromArgb(28, 28, 36);
            Username_box.BackColor = Color.FromArgb(35, 36, 41);
            Username_box.BorderColor = Color.FromArgb(28, 28, 36);

            Email_box.FillColor = Color.FromArgb(28, 28, 36);
            Email_box.BackColor = Color.FromArgb(35, 36, 41);
            Email_box.BorderColor = Color.FromArgb(28, 28, 36);

            Password_box.FillColor = Color.FromArgb(28, 28, 36);
            Password_box.BackColor = Color.FromArgb(35, 36, 41);
            Password_box.BorderColor = Color.FromArgb(28, 28, 36);

            ChangeEmail.BackColor = Color.FromArgb(35, 36, 41);
            ChangeEmail.ForeColor = Color.White;
            ChangeEmail.FillColor = Color.FromArgb(28, 28, 36);
            ChangeEmail.FillColor2 = Color.FromArgb(28, 28, 36);
            ChangeEmail.BorderColor = Color.FromArgb(28, 28, 36);

            ChangePassword.BackColor = Color.FromArgb(35, 36, 41);
            ChangePassword.ForeColor = Color.White;
            ChangePassword.FillColor = Color.FromArgb(28, 28, 36);
            ChangePassword.FillColor2 = Color.FromArgb(28, 28, 36);
            ChangePassword.BorderColor = Color.FromArgb(28, 28, 36);


            Email_box.BackColor = Color.FromArgb(35, 36, 41);
            Password_box.BackColor = Color.FromArgb(35, 36, 41);
            Email.BackColor = Color.FromArgb(35, 36, 41);
            Password.BackColor = Color.FromArgb(35, 36, 41);

            pnLearning.FillColor = Color.FromArgb(28, 28, 36); 
            pnLearning.BackColor = Color.FromArgb(35, 36, 41);

            submit_buttonn.BackColor = Color.FromArgb(28, 28, 36);
            
            Delete.BackColor = Color.FromArgb(28, 28, 36); 
            Delete.FillColor = Color.FromArgb(35, 36, 41);
            Delete.FillColor2 = Color.FromArgb(35, 36, 41);
            Delete.BorderColor = Color.FromArgb(35, 36, 41);
            Delete.ForeColor = Color.White;

            Nama.ForeColor = Color.White;
            Nama.BackColor= Color.FromArgb(28, 28, 36);

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        public void getUserData(string username, string email) 
        {
            //MessageBox.Show("userProfile Username: " + username);
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
            
        }
        private void Email_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Username_box_TextChanged(object sender, EventArgs e)
        {

        }

        private void Delete_Click(object sender, EventArgs e)
        {

        }

        private void check_show_CheckedChanged_1(object sender, EventArgs e)
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

        private void Nama_Click(object sender, EventArgs e)
        {

        }

        private void userProfile_Load_1(object sender, EventArgs e)
        {
            Nama.Text = this.username;
            Username_box.Text = this.username;
            Email_box.Text = this.email;
            Password_box.Text = this.password;
        }

        private void pnUProfile_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Profile_Info_Click(object sender, EventArgs e)
        {

        }

        private void pnLearning_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ChangePassword_Click(object sender, EventArgs e)
        {

        }
    }
}
