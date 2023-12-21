using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegister
{
    public partial class Settings : UserControl
    {
        public Settings()
        {
            InitializeComponent();
        }

        private void Exercise_Click(object sender, EventArgs e)
        {

        }

        private void pnExercise_Paint(object sender, PaintEventArgs e)
        {

        }

        private void UserProfile_btn_Click(object sender, EventArgs e)
        {
            if (!Settings.Instance.pnSettings.Controls.ContainsKey("userProfile"))
            {
                userProfile Profile = new userProfile();
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
