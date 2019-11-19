using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlexsGame
{
    public partial class frmMain : Form
    {
        Map m = new Map("main", 26, 26, 50, 50);

        public frmMain()
        {
            InitializeComponent();
            DoubleBuffered = true;
            ReDraw();
        }

        void ReDraw()
        {
            picMap.Width = m.map.GetLength(0) * 32;
            picMap.Height = m.map.GetLength(1) * 32;
        }

        private void frmMain_Paint(object sender, PaintEventArgs e)
        {
            m.DrawMap(e);
        }

        private void frmMain_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                default: break;
                case Keys.W: picChar.Top -= 10; break;
                case Keys.S: picChar.Top += 10; break;
                case Keys.A: picChar.Left -= 10; break;
                case Keys.D: picChar.Left += 10; break;
            }
        }
    }
}
