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
    public partial class Display_Settings : UserControl
    {
        // Define an event for light mode
        public event EventHandler<ColorChangedEventArgs> LightModeClicked;

        // Define an event for dark mode
        public event EventHandler<ColorChangedEventArgs> DarkModeClicked;

        public event EventHandler<EventArgs> GlobalSettingsAppearanceChanged;


        public Display_Settings()
        {
            InitializeComponent();
        }

        private void pnDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Light_btn_Click(object sender, EventArgs e)
        {
            Guna2Button btn = new Guna2Button();
            btn.FillColor = Color.White;

            LightModeClicked?.Invoke(this, new ColorChangedEventArgs(Color.White));
            GlobalSettingsAppearanceChanged?.Invoke(this, EventArgs.Empty);
            pnDisplay.FillColor = (btn.Name == "Light_btn")?Color.White:Color.White;
            Theme_Style.ForeColor = Color.Black;
            Display.BackColor = Color.White;
        }

        private void Dark_btn_Click(object sender, EventArgs e)
        {
            Guna2Button btn = new Guna2Button();
            btn.FillColor = Color.FromArgb(35, 36, 41);
            btn.CheckedState.ForeColor = Color.FromArgb(35, 36, 41);

            DarkModeClicked?.Invoke(this, new ColorChangedEventArgs(Color.FromArgb(35, 36, 41)));
            GlobalSettingsAppearanceChanged?.Invoke(this, EventArgs.Empty);
            pnDisplay.FillColor = (btn.Name == "Dark_btn") ? Color.FromArgb(35, 36, 41) : Color.FromArgb(35, 36, 41);
            Theme_Style.ForeColor = Color.White;
            Display.BackColor = Color.FromArgb(35, 36, 41);
        }

        private void pnDisplay_Paint_1(object sender, PaintEventArgs e)
        {

        }

        private void Theme_Style_Click(object sender, EventArgs e)
        {

        }

        private void Display_Click(object sender, EventArgs e)
        {

        }
    }
    public class ColorChangedEventArgs : EventArgs
    {
        public Color NewColor { get; }

        public ColorChangedEventArgs(Color newColor)
        {
            NewColor = newColor;
        }

    }
}
