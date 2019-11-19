using System;
using System.Drawing;
using System.Windows.Forms;

namespace AlexsGame
{
    public partial class frmMapMaker : Form
    {
        int tilesetnum = 0;
        bool drawing = false;
        Map m = new Map("main", 26, 26, 50, 50);

        public frmMapMaker()
        {
            InitializeComponent();
            this.DoubleBuffered = true;
            mapName.Text = "main";
            ReDraw();
        }

        void ReDraw()
        {
            picMap.Width = m.map.GetLength(0) * 32;
            picMap.Height = m.map.GetLength(1) * 32;
            picTileSet.Left = picMap.Width + 3;
            btnTileBack.Left = picMap.Width + 5;
            btnTileForward.Left = btnTileBack.Left + 65;
            picIcon.Left = picMap.Width + 3;
            btnUndo.Left = picMap.Width + 5;
            btnSave.Left = btnUndo.Left + 65;
            lblWorldX.Left = picMap.Width + 3;
            lblWorldY.Left = picMap.Width + 3;
            numworldx.Left = lblWorldX.Left + 75;
            numworldy.Left = lblWorldY.Left + 75;
            numworldx.Maximum = m.map.GetLength(2) - 1;
            numworldy.Maximum = m.map.GetLength(3) - 1;
            numworldx.Value = m.map.GetLength(2) / 2;
            numworldy.Value = m.map.GetLength(3) / 2;
            m.worldx = (int)numworldx.Value;
            m.worldy = (int)numworldy.Value;
        }

        private void picMap_Paint(object sender, PaintEventArgs e)
        {
            m.DrawMap(e);
        }

        private void picMap_MouseDown(object sender, MouseEventArgs e)
        {
            int X = e.X / 32;
            int Y = e.Y / 32;
            if (e.Button == MouseButtons.Left && e.Y < picMap.Width && e.Y > 0 && e.X < picMap.Height && e.X > 0)
            {
                btnSave.BackColor = Color.SeaShell;
                btnUndo.BackColor = Color.SeaShell;
                drawing = true;
                m.DrawTile(picMap, X, Y);
            }
            if (e.Button == MouseButtons.Right && e.Y < picMap.Width && e.Y > 0 && e.X < picMap.Height && e.X > 0 && !drawing)
            {
                m.tilenum = m.map[X, Y, m.worldx, m.worldy];
                m.tilewalk[m.tilenum] = m.walk[X, Y, m.worldx, m.worldy];
                picIcon.Image = m.tile[m.tilenum];
                for (int i = 0; i < m.tileset.Length; i++)
                {
                    if (m.tilenum >= i*256 && m.tilenum < (i+1)*256) tilesetnum = i;
                }
                picTileSet.Image = Image.FromFile(m.resourceDir + @"Sets\set" + tilesetnum + ".bmp");
            }
        }

        private void picMap_MouseMove(object sender, MouseEventArgs e)
        {
            int X = e.X / 32;
            int Y = e.Y / 32;
            Cursor = Cursors.Cross;
            if (e.Button == MouseButtons.Left && e.Y < picMap.Width && e.Y > 0 && e.X < picMap.Height && e.X > 0)
            {
                m.DrawTile(picMap, X, Y);
            }
            toolStripTextBox1.Text = "X: " + Convert.ToString(X); toolStripTextBox2.Text = "Y: " + Convert.ToString(Y);
        }

        private void picMap_MouseUp(object sender, MouseEventArgs e)
        {
            drawing = false;
        }

        private void numworldx_ValueChanged(object sender, EventArgs e)
        {
            m.worldx = (int)numworldx.Value;
            picMap.Refresh();
        }

        private void numworldy_ValueChanged(object sender, EventArgs e)
        {
            m.worldy = (int)numworldy.Value;
            picMap.Refresh();
        }

        private void btnTileBack_Click(object sender, EventArgs e)
        {
            if (tilesetnum > 0)
            {
                tilesetnum--;
                picTileSet.Image = Image.FromFile(m.resourceDir + "set" + tilesetnum + ".bmp");
            }
        }

        private void btnTileForward_Click(object sender, EventArgs e)
        {
            if (tilesetnum < m.tileset.Length - 1)
            {
                tilesetnum++;
                picTileSet.Image = Image.FromFile(m.resourceDir + @"Sets\set" + tilesetnum + ".bmp");
            }
        }

        private void picTileSetsm_MouseDown(object sender, MouseEventArgs e)
        {
            int X = e.X / 16; int Y = e.Y / 16;
            m.tilenum = (tilesetnum * 256) + (Y * 8) + X;
            picIcon.Image = m.tile[m.tilenum];
        }

        private void btnUndo_Click(object sender, EventArgs e)
        {
            m.LoadMap();
            btnUndo.BackColor = Color.Green;
            picMap.Refresh();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            m.SaveMap();
            btnSave.BackColor = Color.Green;
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void loadMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m.LoadMap();
            ReDraw();
            picMap.Refresh();
        }

        private void saveMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m.SaveMap();
        }

        private void newMapToolStripMenuItem_Click(object sender, EventArgs e)
        {
            m = new Map(mapName.Text, 26, 26, 50, 50);
            m.SaveMap();
            m.LoadMap();
            ReDraw();
            picMap.Refresh();
        }

        private void picMap_MouseLeave(object sender, EventArgs e)
        {
            Cursor = Cursors.Default;
        }
    }
}
