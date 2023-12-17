using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;

namespace LoginRegister
{
    public partial class lvl1 : Form
    {
        public lvl1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void copy_button_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(lvl1_soal.Text);
            MessageBox.Show("Copied!");
        }
    }
}
