using Google.Apis.YouTube.v3.Data;
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
using System.Net;

namespace LoginRegister
{
    public partial class Learningg : UserControl
    {
        public Learningg()
        {
            InitializeComponent();
        }

        bool menuExpand = false;

        private void Intro_Click(object sender, EventArgs e)
        {
            removeProcces();
            Data_Type data = new Data_Type(1);
            data.Dock = DockStyle.Fill;
            Learningg.Instance.pnLearning.Controls.Add(data);
            Learningg.Instance.pnLearning.Controls["Data_Type"].BringToFront();
        }

        private void MenuTransition_Tick_1(object sender, EventArgs e)
        {
            if (menuExpand == false)
            {
                introContainer.Height += 10;
                if (introContainer.Height >= 106)
                {
                    MenuTransition.Stop();
                    menuExpand = true;
                }
            }
            else
            {
                introContainer.Height -= 10;
                if (introContainer.Height <= 53)
                {
                    MenuTransition.Stop();
                    menuExpand = false;
                }
            }
        }
        static Learningg _obj;
        public static Learningg Instance
        {
            get
            {
                if (_obj == null)
                {
                    _obj = new Learningg();
                }
                return _obj;
            }
        }
        public Guna2Panel PanelLearning
        {
            get { return pnLearning; }
            set { pnLearning = value; }
        }
        private void removeProcces() 
        {
            if (Learningg.Instance.pnLearning.Controls.ContainsKey("Data_Type"))
            {
                Data_Type dt = (Data_Type)Learningg.Instance.pnLearning.Controls["Data_Type"];
                dt.webKill();
                Learningg.Instance.pnLearning.Controls.RemoveByKey("Data_Type");
            }
        }
        private void Learningg_Load(object sender, EventArgs e)
        {
            _obj = this;

            Intro Int = new Intro();
            Int.Dock = DockStyle.Fill;
            pnLearning.Controls.Add(Int);
        }

        private void pnLearning_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DataType_Click(object sender, EventArgs e)
        {

            removeProcces();
            Data_Type data = new Data_Type(2);
            data.Dock = DockStyle.Fill;
            Learningg.Instance.pnLearning.Controls.Add(data);
            Learningg.Instance.pnLearning.Controls["Data_Type"].BringToFront();
        }

        private void pnList_Paint(object sender, PaintEventArgs e)
        {

        }

        private void GlobalSettings_Click(object sender, EventArgs e)
        {

        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            removeProcces();
            Data_Type data = new Data_Type(3);
            data.Dock = DockStyle.Fill;
            Learningg.Instance.pnLearning.Controls.Add(data);
            Learningg.Instance.pnLearning.Controls["Data_Type"].BringToFront();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            removeProcces();
            Data_Type data = new Data_Type(4);
            data.Dock = DockStyle.Fill;
            Learningg.Instance.pnLearning.Controls.Add(data);
            Learningg.Instance.pnLearning.Controls["Data_Type"].BringToFront();
        }

        private void guna2Button3_Click(object sender, EventArgs e)
        {
            removeProcces();

            Data_Type data = new Data_Type(5);
            data.Dock = DockStyle.Fill;
            Learningg.Instance.pnLearning.Controls.Add(data);
            Learningg.Instance.pnLearning.Controls["Data_Type"].BringToFront();
        }

        private void guna2Button4_Click(object sender, EventArgs e)
        {
            removeProcces();

            Data_Type data = new Data_Type(7);
            data.Dock = DockStyle.Fill;
            Learningg.Instance.pnLearning.Controls.Add(data);
            Learningg.Instance.pnLearning.Controls["Data_Type"].BringToFront();
        }

        private void guna2Button5_Click(object sender, EventArgs e)
        {
            removeProcces();

            Data_Type data = new Data_Type(8);
            data.Dock = DockStyle.Fill;
            Learningg.Instance.pnLearning.Controls.Add(data);
            Learningg.Instance.pnLearning.Controls["Data_Type"].BringToFront();
        }

        private void back_Click(object sender, EventArgs e)
        {

        }
    }
}