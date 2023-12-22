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
    public partial class userProfile : UserControl
    {
        public event EventHandler<ColorChangedEventArgs> LightModeClicked;
        public event EventHandler<ColorChangedEventArgs> DarkModeClicked;
        public event EventHandler<EventArgs> GlobalSettingsAppearanceChanged;
        public userProfile()
        {
            InitializeComponent();
            Settings.Instance.LightModeClicked += HandleLightModeClicked;
            Settings.Instance.DarkModeClicked += HandleDarkModeClicked;
        }
        private void HandleLightModeClicked(object sender, ColorChangedEventArgs e)
        {
            pnUProfile.BackColor = Color.White;
        }
        private void HandleDarkModeClicked(object sender, ColorChangedEventArgs e)
        {
            pnUProfile.BackColor = Color.Black;
        }
        private void label1_Click(object sender, EventArgs e)
        {

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

        private void userProfile_Load(object sender, EventArgs e)
        {

        }

        private void pnUProfile_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
