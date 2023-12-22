using Guna.UI2.WinForms;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LoginRegister
{
    public partial class Dashboard : Form
    {
        private Settings mySettingsUserControl;
        public int userLVL {  get; set; }
        public string username { get; set; }
        public float Progress{ get; set; }
        public Dashboard()
        {
            InitializeComponent();
         
        }

        public void getUserData(string username, int userLvl)
        {
            this.username = username;
            this.userLVL = userLvl;
            //MessageBox.Show($"DASHBOARD\nUsername: {this.username}\n UserLevel: {this.userLVL}");
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void guna2TileButton1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void moveImageBox(object sender)
        {
            Guna2Button b = (Guna2Button) sender;
        }
        private void guna2Button2_CheckedChanged(object sender, EventArgs e)
        {
            moveImageBox(sender);
        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ProgressPanel_Paint(object sender, PaintEventArgs e)
        {
        }

        private void guna2Panel5_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleProgressBar1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ProgressText_TextChanged(object sender, EventArgs e)
        {

        }
        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2HtmlLabel5_Click_1(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel1_Click(object sender, EventArgs e)
        {

        }

        private void guna2HtmlLabel2_Click(object sender, EventArgs e)
        {

        }

        private void Top_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        public void Left_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Topp_Paint(object sender, PaintEventArgs e)
        {

        }
        bool SidebarExpand = true;
        private void SidebarTrans_Tick(object sender, EventArgs e)
        {
            if(SidebarExpand)
            {
                Left.Width -= 5;
                if (Left.Width <= 67)
                {
                    SidebarTrans.Stop ();
                    SidebarExpand = false;

                }
            }
            else
            {
                Left.Width += 5;
                if (Left.Width >= 179)
                {
                    SidebarTrans.Stop();
                    SidebarExpand = true;

                }
            }
        }

        private void Sidebar_Click(object sender, EventArgs e)
        {
            SidebarTrans.Start ();
        }

        private void guna2PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void BgMain_Paint(object sender, PaintEventArgs e)
        {

        }
        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {
            User user = new User();
            user.username = this.username;
            user.userLevel = this.userLVL;
            Home home = new Home();
            home.username = user.username;
            home.userLevel = user.userLevel;

            //MessageBox.Show($"HOME\nusername: {user.username} \n userLevel: {user.userLevel}");
            if (!Dashboard.Instance.PanelUtama.Controls.ContainsKey("Home"))
            {

                home.Dock = DockStyle.Fill;
                Dashboard.Instance.PanelUtama.Controls.Add(home);
            }
            Dashboard.Instance.PanelUtama.Controls["Home"].BringToFront();

        }

        private void Dash_Click(object sender, EventArgs e)
        {
            User user = new User();
            user.username = this.username;
            user.userLevel = this.userLVL;
            Home home = new Home();
            home.username = user.username;
            home.userLevel = user.userLevel;
            home.getUserData(user.username, user.userLevel);

            //MessageBox.Show($"HOME\nusername: {user.username} \n userLevel: {user.userLevel}");
            if (!Dashboard.Instance.PanelUtama.Controls.ContainsKey("Home"))
            {
                
                home.Dock = DockStyle.Fill;
                Dashboard.Instance.PanelUtama.Controls.Add(home);
            }
            Dashboard.Instance.PanelUtama.Controls["Home"].BringToFront();
        }
        private void Profile_Click(object sender, EventArgs e)
        {
            if (!Dashboard.Instance.PanelUtama.Controls.ContainsKey("Profile"))
            {
                Profile prf = new Profile();
                prf.Dock = DockStyle.Fill;
                Dashboard.Instance.PanelUtama.Controls.Add(prf);
            }
            Dashboard.Instance.PanelUtama.Controls["Profile"].BringToFront();

        }
        private void Settings_Click(object sender, EventArgs e)
        {
            if (!Dashboard.Instance.PanelUtama.Controls.ContainsKey("Settings"))
            {
                Settings set = new Settings();
                set.getUserData(this.username);
                set.LightModeClicked += Settings_LightModeClicked;
                set.DarkModeClicked += Settings_DarkModeClicked;

                set.Dock = DockStyle.Fill;
                Dashboard.Instance.PanelUtama.Controls.Add(set);
            }
            Dashboard.Instance.PanelUtama.Controls["Settings"].BringToFront();
        }
        private void Settings_LightModeClicked(object sender, ColorChangedEventArgs e)
        {
            Left.BackColor = e.NewColor;
            Topp.BackColor = e.NewColor;

            UpdateLearnLabel(Color.White, Color.FromArgb(35, 36, 41));
            UpdateDashButton(Color.White, Color.FromArgb(5, 38, 129));
            UpdateProfileButton(Color.White, Color.FromArgb(5, 38, 129));
            UpdateSettingsButton(Color.White, Color.FromArgb(5, 38, 129));
        }
        private void Settings_DarkModeClicked(object sender, ColorChangedEventArgs e)
        {
            ChangeTopPanel(Color.FromArgb(21, 22, 27));
            ChangeLeftPanel(Color.FromArgb(21, 22, 27));

            UpdateLearnLabel(Color.FromArgb(21, 22, 27), Color.White);
            UpdateDashButton(Color.FromArgb(21, 22, 27), Color.White);
            UpdateProfileButton(Color.FromArgb(21, 22, 27), Color.White);
            UpdateSettingsButton(Color.FromArgb(21, 22, 27), Color.White);
        }
        public void ChangeLeftPanel(Color NewColor)
        {
            Left.BackColor = NewColor;
        }
        public void ChangeTopPanel(Color NewColor)
        {
            Topp.BackColor = NewColor;
        }
        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {

        }

        private void pnExercise_Paint(object sender, PaintEventArgs e)
        {

        }

        static Dashboard _obj;
        public static Dashboard Instance
        { 
            get
            {
                if (_obj == null)
                {
                    _obj = new Dashboard();
                }
                return _obj;
            }
        }
        public Guna2Panel PanelUtama
        {
            get { return MainPanel; }
            set { MainPanel = value; }
        }
        private void Dashboard_Load(object sender, EventArgs e)
        {
            mySettingsUserControl = new Settings();
            mySettingsUserControl.getUserData(this.username);
            Controls.Add(mySettingsUserControl);
            mySettingsUserControl.Visible = true;
            _obj = this;

            Home home = new Home();
            home.username = username;
            home.userLevel = userLVL;
            home.getUserData(username, userLVL);
            home.Dock = DockStyle.Fill;
            MainPanel.Controls.Add(home);
        }
        private void UpdateDashButton(Color fillColor, Color forecolor)
        {
            Dash.FillColor = fillColor;
            Dash.CheckedState.FillColor = fillColor;
            Dash.DisabledState.FillColor = fillColor;
            Dash.CheckedState.ForeColor = forecolor;
        }
        private void UpdateProfileButton(Color fillColor, Color forecolor)
        {
            Profile.FillColor = fillColor;
            Profile.CheckedState.FillColor = fillColor;
            Profile.DisabledState.FillColor = fillColor;
            Profile.CheckedState.ForeColor = forecolor;
        }
        private void UpdateSettingsButton(Color fillColor, Color forecolor)
        {
            Settings.FillColor = fillColor;
            Settings.CheckedState.FillColor = fillColor;
            Settings.DisabledState.FillColor = fillColor;
            Settings.CheckedState.ForeColor = forecolor;
        }
        private void UpdateLearnLabel(Color backColor, Color foreColor)
        {
            learn.BackColor = backColor;
            learn.ForeColor = foreColor;
        }
    }
}