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
    }
}
