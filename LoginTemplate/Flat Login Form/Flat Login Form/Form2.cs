using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Flat_Login_Form
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {

        }

        bool sidebarExpand = true;
        private void sidebarTransition_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                sidebar.Width -= 5;
                if (sidebar.Width <= 62)
                {
                    sidebarExpand = false;
                    sidebarTransition.Stop();

                }
            }
            else
            {
                sidebar.Width += 5;
                if (sidebar.Width >= 181)
                {
                    sidebarExpand = true;
                    sidebarTransition.Stop();

                    pnDashboard.Width = sidebar.Width;
                    pnCourse.Width = sidebar.Width;
                    pnProfile.Width = sidebar.Width;
                    pnSettings.Width = sidebar.Width;
                }
            }
        }

        private void Menu_Click(object sender, EventArgs e)
        {
            sidebarTransition.Start();
        }

        private void guna2Panel3_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
