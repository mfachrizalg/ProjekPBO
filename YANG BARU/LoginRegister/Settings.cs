using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegister
{
    public partial class Settings : UserControl
    {
        public event EventHandler<ColorChangedEventArgs> LightModeClicked;
        public event EventHandler<ColorChangedEventArgs> DarkModeClicked;
        public event EventHandler<EventArgs> GlobalSettingsAppearanceChanged;
        public Settings()
        {
            InitializeComponent();
            Display_Settings display = new Display_Settings();
            display.LightModeClicked += Display_LightModeClicked;
            display.DarkModeClicked += Display_DarkModeClicked;
        }

        private void UserProfile_btn_Click(object sender, EventArgs e)
        {
            if (!Settings.Instance.pnSettings.Controls.ContainsKey("userProfile"))
            {
                userProfile Profile = new userProfile();

                Profile.LightModeClicked += Display_LightModeClicked;
                Profile.DarkModeClicked += Display_DarkModeClicked;

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

                display.LightModeClicked += Display_LightModeClicked;
                display.DarkModeClicked += Display_DarkModeClicked;

                display.Dock = DockStyle.Fill;
                Settings.Instance.pnSettings.Controls.Add(display);
            }
            Settings.Instance.pnSettings.Controls["Display_Settings"].BringToFront();
        }
        private void Display_Settings_ColorModeChanged(object sender, ColorChangedEventArgs e)
        {
            // Forward the event to userProfile
            LightModeClicked?.Invoke(this, e);
        }
        private void Display_LightModeClicked(object sender, ColorChangedEventArgs e)
        {
            ChangePnKataColor(e.NewColor);
            ChangePnMainColor(Color.FromArgb(241, 244, 254));
            ChangePnSettingsColor(Color.FromArgb(241, 244, 254));

            UpdateGlobalSettingsLabel(Color.White, Color.FromArgb(35, 36, 41));
            UpdateUserProfileButton(Color.White, Color.FromArgb(5, 38, 129));
            UpdateNotificationsButton(Color.White, Color.FromArgb(5, 38, 129));
            UpdateDisplayButton(Color.White, Color.FromArgb(5, 38, 129));
            LightModeClicked?.Invoke(this, e);
        }
        private void Display_DarkModeClicked(object sender, ColorChangedEventArgs e)
        {
            ChangePnKataColor(Color.FromArgb(28, 28, 36));
            ChangesPnKataColorBackDark(e.NewColor);
            ChangePnMainColor(Color.FromArgb(21, 22, 27));
            ChangePnSettingsColor(Color.FromArgb(21, 22, 27));

            UpdateGlobalSettingsLabel(Color.FromArgb(28, 28, 36), Color.White);
            UpdateUserProfileButton(Color.FromArgb(28, 28, 36), Color.White);
            UpdateNotificationsButton(Color.FromArgb(28, 28, 36), Color.White);
            UpdateDisplayButton(Color.FromArgb(28, 28, 36), Color.White);
            DarkModeClicked?.Invoke(this, e);
        }
        private void UpdateGlobalSettingsLabel(Color backColor, Color foreColor)
        {
            GlobalSettings.BackColor = backColor;
            GlobalSettings.ForeColor = foreColor;
        }
        private void UpdateUserProfileButton(Color fillColor, Color forecolor)
        {
            UserProfile_btn.FillColor = fillColor;
            UserProfile_btn.CheckedState.FillColor = fillColor;
            UserProfile_btn.DisabledState.FillColor = fillColor;
            UserProfile_btn.CheckedState.ForeColor = forecolor;
        }
        private void UpdateNotificationsButton(Color fillColor, Color forecolor)
        {
            Notifications_btn.FillColor = fillColor;
            Notifications_btn.CheckedState.FillColor = fillColor;
            Notifications_btn.DisabledState.FillColor = fillColor;
            Notifications_btn.CheckedState.ForeColor = forecolor;
        }
        private void UpdateDisplayButton(Color fillColor, Color forecolor)
        {
            Display_btn.FillColor = fillColor;
            Display_btn.CheckedState.FillColor = fillColor;
            Display_btn.DisabledState.FillColor = fillColor;
            Display_btn.CheckedState.ForeColor = forecolor;
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
        public void ChangePnMainColor(Color newColor)
        {
            pnMainSettings.FillColor = newColor;
        }
        public void ChangePnKataColor(Color newColor)
        {
            pnKata.FillColor = newColor;
            pnKata.BackColor = Color.FromArgb(241, 244, 254);
        }
        public void ChangesPnKataColorBackDark (Color newColor)
        {
            pnKata.BackColor = Color.FromArgb(21, 22, 27);
        }
        public void ChangePnSettingsColor(Color newColor)
        {
            pnSettings.BackColor = newColor;
            pnSettings.BorderColor = newColor;
        }
        public void ChangeGlobalSettings(Color newColor)
        {
            GlobalSettings.BackColor = newColor;
            GlobalSettings.ForeColor = newColor;
        }

        private void pnMainSettings_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
