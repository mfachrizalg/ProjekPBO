using Azure.Identity;
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
    public partial class Home : UserControl
    {
        public string username {  get; set; }
        public int userLevel { get; set; }
        public Home()
        {
            InitializeComponent();
        }

        private void Learning_Click(object sender, EventArgs e)
        {
            if(!Dashboard.Instance.PanelUtama.Controls.ContainsKey("Learningg"))
            {
                Learningg ln = new Learningg();
                ln.Dock = DockStyle.Fill;
                Dashboard.Instance.PanelUtama.Controls.Add(ln);
            }
            Dashboard.Instance.PanelUtama.Controls["Learningg"].BringToFront();
        }

        private void Photo_Click(object sender, EventArgs e)
        {

        }

        private void HiText_Click(object sender, EventArgs e)
        {

        }

        private void Exercise_Click(object sender, EventArgs e)
        {
            int userLevel = this.userLevel;
            string username = this.username;
            if (!Dashboard.Instance.PanelUtama.Controls.ContainsKey("level1"))
            {
                level1 lv = new level1();
                lv.Username = username;
                lv.userLevel = userLevel;
                lv.Dock = DockStyle.Fill;
                Dashboard.Instance.PanelUtama.Controls.Add(lv);
            }
            Dashboard.Instance.PanelUtama.Controls["level1"].BringToFront();
        }

        private void monthCalendar1_DateChanged(object sender, DateRangeEventArgs e)
        {

        }

        private void pnExercise_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2CircleButton1_Click(object sender, EventArgs e)
        {

        }

        private void ProgressPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Completed_Click(object sender, EventArgs e)
        {

        }

        private void ProgressText_Click(object sender, EventArgs e)
        {

        }

        private void ProgressBar_ValueChanged(object sender, EventArgs e)
        {

        }

        private void pnLearning_Paint(object sender, PaintEventArgs e)
        {

        }

        private void MainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Welcome_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void pnKata_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Katakata_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
