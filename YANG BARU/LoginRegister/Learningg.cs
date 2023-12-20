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
    public partial class Learningg : UserControl
    {
        public Learningg()
        {
            InitializeComponent();
        }

        bool menuExpand = false;

        private void Intro_Click(object sender, EventArgs e)
        {
            MenuTransition.Start();
            if (!Learningg.Instance.pnLearning.Controls.ContainsKey("Intro"))
            {
                Intro Int = new Intro();
                Int.Dock = DockStyle.Fill;
                Learningg.Instance.pnLearning.Controls.Add(Int);
            }
            Learningg.Instance.pnLearning.Controls["Intro"].BringToFront();
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
            if (!Learningg.Instance.pnLearning.Controls.ContainsKey("Data_Type"))
            {
                Data_Type data = new Data_Type();
                data.Dock = DockStyle.Fill;
                Learningg.Instance.pnLearning.Controls.Add(data);
            }
            Learningg.Instance.pnLearning.Controls["Data_Type"].BringToFront();
        }
    }
}
