namespace AlexsGame
{
    partial class frmMapMaker
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSave = new System.Windows.Forms.Button();
            this.btnUndo = new System.Windows.Forms.Button();
            this.numworldx = new System.Windows.Forms.NumericUpDown();
            this.btnTileBack = new System.Windows.Forms.Button();
            this.btnTileForward = new System.Windows.Forms.Button();
            this.numworldy = new System.Windows.Forms.NumericUpDown();
            this.picTileSet = new System.Windows.Forms.PictureBox();
            this.picIcon = new System.Windows.Forms.PictureBox();
            this.picMap = new System.Windows.Forms.PictureBox();
            this.lblWorldX = new System.Windows.Forms.Label();
            this.lblWorldY = new System.Windows.Forms.Label();
            this.mapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripTextBox2 = new System.Windows.Forms.ToolStripTextBox();
            this.mapName = new System.Windows.Forms.ToolStripTextBox();
            this.mapToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.newMapToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadMapToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.saveMapToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            ((System.ComponentModel.ISupportInitialize)(this.numworldx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numworldy)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTileSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).BeginInit();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnSave
            // 
            this.btnSave.BackColor = System.Drawing.Color.SeaShell;
            this.btnSave.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(903, 727);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(60, 48);
            this.btnSave.TabIndex = 0;
            this.btnSave.TabStop = false;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = false;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnUndo
            // 
            this.btnUndo.BackColor = System.Drawing.Color.SeaShell;
            this.btnUndo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUndo.Location = new System.Drawing.Point(838, 727);
            this.btnUndo.Name = "btnUndo";
            this.btnUndo.Size = new System.Drawing.Size(60, 48);
            this.btnUndo.TabIndex = 0;
            this.btnUndo.TabStop = false;
            this.btnUndo.Text = "Undo";
            this.btnUndo.UseVisualStyleBackColor = false;
            this.btnUndo.Click += new System.EventHandler(this.btnUndo_Click);
            // 
            // numworldx
            // 
            this.numworldx.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.numworldx.Location = new System.Drawing.Point(912, 790);
            this.numworldx.Maximum = new decimal(new int[] {
            49,
            0,
            0,
            0});
            this.numworldx.Name = "numworldx";
            this.numworldx.Size = new System.Drawing.Size(45, 32);
            this.numworldx.TabIndex = 0;
            this.numworldx.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numworldx.ValueChanged += new System.EventHandler(this.numworldx_ValueChanged);
            // 
            // btnTileBack
            // 
            this.btnTileBack.Location = new System.Drawing.Point(835, 543);
            this.btnTileBack.Name = "btnTileBack";
            this.btnTileBack.Size = new System.Drawing.Size(60, 44);
            this.btnTileBack.TabIndex = 0;
            this.btnTileBack.TabStop = false;
            this.btnTileBack.Text = "<--";
            this.btnTileBack.UseVisualStyleBackColor = true;
            this.btnTileBack.Click += new System.EventHandler(this.btnTileBack_Click);
            // 
            // btnTileForward
            // 
            this.btnTileForward.Location = new System.Drawing.Point(903, 543);
            this.btnTileForward.Name = "btnTileForward";
            this.btnTileForward.Size = new System.Drawing.Size(60, 44);
            this.btnTileForward.TabIndex = 0;
            this.btnTileForward.TabStop = false;
            this.btnTileForward.Text = "-->";
            this.btnTileForward.UseVisualStyleBackColor = true;
            this.btnTileForward.Click += new System.EventHandler(this.btnTileForward_Click);
            // 
            // numworldy
            // 
            this.numworldy.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F);
            this.numworldy.Location = new System.Drawing.Point(912, 822);
            this.numworldy.Maximum = new decimal(new int[] {
            49,
            0,
            0,
            0});
            this.numworldy.Name = "numworldy";
            this.numworldy.Size = new System.Drawing.Size(45, 32);
            this.numworldy.TabIndex = 1;
            this.numworldy.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            this.numworldy.ValueChanged += new System.EventHandler(this.numworldy_ValueChanged);
            // 
            // picTileSet
            // 
            this.picTileSet.Image = global::AlexsGame.Properties.Resources.set0;
            this.picTileSet.Location = new System.Drawing.Point(835, 26);
            this.picTileSet.Name = "picTileSet";
            this.picTileSet.Size = new System.Drawing.Size(128, 512);
            this.picTileSet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picTileSet.TabIndex = 10;
            this.picTileSet.TabStop = false;
            this.picTileSet.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picTileSetsm_MouseDown);
            // 
            // picIcon
            // 
            this.picIcon.Location = new System.Drawing.Point(835, 593);
            this.picIcon.Name = "picIcon";
            this.picIcon.Size = new System.Drawing.Size(128, 128);
            this.picIcon.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picIcon.TabIndex = 4;
            this.picIcon.TabStop = false;
            // 
            // picMap
            // 
            this.picMap.Location = new System.Drawing.Point(0, 26);
            this.picMap.Name = "picMap";
            this.picMap.Size = new System.Drawing.Size(832, 832);
            this.picMap.TabIndex = 12;
            this.picMap.TabStop = false;
            this.picMap.Paint += new System.Windows.Forms.PaintEventHandler(this.picMap_Paint);
            this.picMap.MouseDown += new System.Windows.Forms.MouseEventHandler(this.picMap_MouseDown);
            this.picMap.MouseLeave += new System.EventHandler(this.picMap_MouseLeave);
            this.picMap.MouseMove += new System.Windows.Forms.MouseEventHandler(this.picMap_MouseMove);
            this.picMap.MouseUp += new System.Windows.Forms.MouseEventHandler(this.picMap_MouseUp);
            // 
            // lblWorldX
            // 
            this.lblWorldX.AutoSize = true;
            this.lblWorldX.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorldX.Location = new System.Drawing.Point(841, 796);
            this.lblWorldX.Name = "lblWorldX";
            this.lblWorldX.Size = new System.Drawing.Size(65, 20);
            this.lblWorldX.TabIndex = 13;
            this.lblWorldX.Text = "World X";
            // 
            // lblWorldY
            // 
            this.lblWorldY.AutoSize = true;
            this.lblWorldY.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWorldY.Location = new System.Drawing.Point(841, 828);
            this.lblWorldY.Name = "lblWorldY";
            this.lblWorldY.Size = new System.Drawing.Size(65, 20);
            this.lblWorldY.TabIndex = 13;
            this.lblWorldY.Text = "World Y";
            // 
            // mapToolStripMenuItem
            // 
            this.mapToolStripMenuItem.Name = "mapToolStripMenuItem";
            this.mapToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.mapToolStripMenuItem.Text = "Map";
            // 
            // loadMapToolStripMenuItem
            // 
            this.loadMapToolStripMenuItem.Name = "loadMapToolStripMenuItem";
            this.loadMapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.loadMapToolStripMenuItem.Text = "Load Map";
            this.loadMapToolStripMenuItem.Click += new System.EventHandler(this.loadMapToolStripMenuItem_Click);
            // 
            // saveMapToolStripMenuItem
            // 
            this.saveMapToolStripMenuItem.Name = "saveMapToolStripMenuItem";
            this.saveMapToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.saveMapToolStripMenuItem.Text = "Save Map";
            this.saveMapToolStripMenuItem.Click += new System.EventHandler(this.saveMapToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(42, 20);
            this.quitToolStripMenuItem.Text = "Quit";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTextBox1,
            this.toolStripTextBox2,
            this.mapName,
            this.mapToolStripMenuItem1,
            this.quitToolStripMenuItem1});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(967, 27);
            this.menuStrip1.TabIndex = 14;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.Margin = new System.Windows.Forms.Padding(0, 0, 1, 0);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.ReadOnly = true;
            this.toolStripTextBox1.Size = new System.Drawing.Size(32, 23);
            // 
            // toolStripTextBox2
            // 
            this.toolStripTextBox2.Margin = new System.Windows.Forms.Padding(5, 0, 1, 0);
            this.toolStripTextBox2.Name = "toolStripTextBox2";
            this.toolStripTextBox2.ReadOnly = true;
            this.toolStripTextBox2.Size = new System.Drawing.Size(32, 23);
            // 
            // mapName
            // 
            this.mapName.Name = "mapName";
            this.mapName.Size = new System.Drawing.Size(100, 23);
            // 
            // mapToolStripMenuItem1
            // 
            this.mapToolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newMapToolStripMenuItem,
            this.loadMapToolStripMenuItem1,
            this.saveMapToolStripMenuItem1});
            this.mapToolStripMenuItem1.Name = "mapToolStripMenuItem1";
            this.mapToolStripMenuItem1.Size = new System.Drawing.Size(43, 23);
            this.mapToolStripMenuItem1.Text = "Map";
            // 
            // newMapToolStripMenuItem
            // 
            this.newMapToolStripMenuItem.Name = "newMapToolStripMenuItem";
            this.newMapToolStripMenuItem.Size = new System.Drawing.Size(127, 22);
            this.newMapToolStripMenuItem.Text = "New Map";
            this.newMapToolStripMenuItem.Click += new System.EventHandler(this.newMapToolStripMenuItem_Click);
            // 
            // loadMapToolStripMenuItem1
            // 
            this.loadMapToolStripMenuItem1.Name = "loadMapToolStripMenuItem1";
            this.loadMapToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.loadMapToolStripMenuItem1.Text = "Load Map";
            this.loadMapToolStripMenuItem1.Click += new System.EventHandler(this.loadMapToolStripMenuItem_Click);
            // 
            // saveMapToolStripMenuItem1
            // 
            this.saveMapToolStripMenuItem1.Name = "saveMapToolStripMenuItem1";
            this.saveMapToolStripMenuItem1.Size = new System.Drawing.Size(127, 22);
            this.saveMapToolStripMenuItem1.Text = "Save Map";
            this.saveMapToolStripMenuItem1.Click += new System.EventHandler(this.saveMapToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem1
            // 
            this.quitToolStripMenuItem1.Name = "quitToolStripMenuItem1";
            this.quitToolStripMenuItem1.Size = new System.Drawing.Size(42, 23);
            this.quitToolStripMenuItem1.Text = "Quit";
            this.quitToolStripMenuItem1.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // frmMapMaker
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(967, 863);
            this.Controls.Add(this.lblWorldY);
            this.Controls.Add(this.lblWorldX);
            this.Controls.Add(this.picMap);
            this.Controls.Add(this.picTileSet);
            this.Controls.Add(this.btnTileForward);
            this.Controls.Add(this.btnTileBack);
            this.Controls.Add(this.numworldy);
            this.Controls.Add(this.numworldx);
            this.Controls.Add(this.picIcon);
            this.Controls.Add(this.btnUndo);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "frmMapMaker";
            this.Text = "Map Maker";
            ((System.ComponentModel.ISupportInitialize)(this.numworldx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numworldy)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picTileSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picIcon)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picMap)).EndInit();
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnUndo;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.PictureBox picIcon;
        private System.Windows.Forms.NumericUpDown numworldx;
        private System.Windows.Forms.Button btnTileBack;
        private System.Windows.Forms.Button btnTileForward;
        private System.Windows.Forms.PictureBox picTileSet;
        private System.Windows.Forms.NumericUpDown numworldy;
        private System.Windows.Forms.Label lblWorldX;
        private System.Windows.Forms.Label lblWorldY;
        private System.Windows.Forms.PictureBox picMap;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem loadMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveMapToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem mapToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem loadMapToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem saveMapToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox2;
        private System.Windows.Forms.ToolStripTextBox mapName;
        private System.Windows.Forms.ToolStripMenuItem newMapToolStripMenuItem;
    }
}

