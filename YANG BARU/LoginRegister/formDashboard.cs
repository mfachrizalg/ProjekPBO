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
    public partial class formDashboard : Form
    {

        public float Progress{ get; set; }
        public formDashboard()
        {
            InitializeComponent();
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

        private void guna2Button1_Click_1(object sender, EventArgs e)
        {

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

        private void Left_Paint(object sender, PaintEventArgs e)
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
                    SidebarExpand = false;
                    SidebarTrans.Stop ();

                }
            }
            else
            {
                Left.Width += 5;
                if (Left.Width >= 199)
                {
                    SidebarExpand = true;
                    SidebarTrans.Stop();

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

        }

        private void Dash_Click(object sender, EventArgs e)
        {
            formDashboard frm = new formDashboard();
            frm.TopLevel = false;
            MainPanel.Controls.Add(frm);
            frm.BringToFront();
            frm.Show();
        }
        private void Profile_Click(object sender, EventArgs e)
        {
            ProgressPanel.Hide();
            formProfile frm = new formProfile();
            frm.TopLevel = false;
            MainPanel.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.Show();

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click_2(object sender, EventArgs e)
        {

        }

        private void Learningg_Click(object sender, EventArgs e)
        {
            ProgressPanel.Hide();
            Learning frm = new Learning();
            frm.TopLevel = false;
            MainPanel.Controls.Add(frm);
            frm.Dock = DockStyle.Fill;
            frm.BringToFront();
            frm.Show();
        }
    }
}
