using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlexsGame
{
    public partial class frmSelect : Form
    {
        public frmSelect()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {
            frmMapMaker f = new frmMapMaker();
            f.Show();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            frmMain g = new frmMain();
            g.Show();
        }
    }
}
