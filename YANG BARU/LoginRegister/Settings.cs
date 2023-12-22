using Guna.UI2.WinForms;
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
    public partial class Settings : UserControl
    {
        public string username { get; set; }
        public string email { get; set; }
        public Settings()
        {
            InitializeComponent();
        }
        SqlConnection conn = new SqlConnection(@"Data Source=pboapps.database.windows.net;Initial Catalog=User;User ID=arden;Password=2Matasaya_;Connect Timeout=30;Encrypt=True");

        private void Exercise_Click(object sender, EventArgs e)
        {

        }

        private void pnExercise_Paint(object sender, PaintEventArgs e)
        {

        }

        public void getUserData(string username)
        {
            this.username = username;
            String querry = "SELECT * FROM UserData WHERE username = '" + username + "'";

            SqlDataAdapter sda = new SqlDataAdapter(querry, conn);

            DataTable dt = new DataTable();

            sda.Fill(dt);

            string searchColumn = "username";
            string searchVal = username;
            string resultColumn = "email";

            DataRow[] selectedRows = dt.Select($"{searchColumn} = '{searchVal}'");

            string email = (string)selectedRows[0][resultColumn];
            this.email = email;
            //MessageBox.Show($"DASHBOARD\nUsername: {this.username}\n UserLevel: {this.userLVL}");
            //MessageBox.Show($"SETTINGS\nUsername: {this.username}\n Email: {this.email}");
        }

        private void UserProfile_btn_Click(object sender, EventArgs e)
        {
            if (!Settings.Instance.pnSettings.Controls.ContainsKey("userProfile"))
            {
                userProfile Profile = new userProfile();
                Profile.getUserData(this.username, this.email);
                Profile.Dock = DockStyle.Fill;
                Settings.Instance.pnSettings.Controls.Add(Profile);
            }
            Settings.Instance.pnSettings.Controls["userProfile"].BringToFront();
        }

        static Settings _obj;
        public static Settings Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Settings();
                }
                return _obj;
            }
        }
        public Guna2Panel PanelSettings
        {
            get { return pnSettings; }
            set { pnSettings = value; }
        }
        private void Settings_Load(object sender, EventArgs e)
        {
            _obj = this;

            userProfile profile = new userProfile();
            profile.getUserData(this.username, this.email);
            profile.Dock = DockStyle.Fill;
            pnSettings.Controls.Add(profile);
        }

        private void Display_btn_Click(object sender, EventArgs e)
        {
            if (!Settings.Instance.pnSettings.Controls.ContainsKey("Display_Settings"))
            {
                Display_Settings display = new Display_Settings();
                display.Dock = DockStyle.Fill;
                Settings.Instance.pnSettings.Controls.Add(display);
            }
            Settings.Instance.pnSettings.Controls["Display_Settings"].BringToFront();
        }

        private void pnSettings_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GlobalSettings_Click(object sender, EventArgs e)
        {

        }

        public void pnKata_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Notifications_btn_Click(object sender, EventArgs e)
        {

        }
    }
}
