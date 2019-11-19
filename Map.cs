using System;
using System.Drawing;
using System.Windows.Forms;
using System.IO;

namespace AlexsGame
{
    class Map
    {
        public Bitmap[] tile; public Bitmap[] tileset = new Bitmap[5];   //when adding more tilesets, add to this array size
        public int[,,,] map; public int[,,,] walk; public int[,,,] item; public int[] tilewalk;
        public int tilenum = 0, worldx = 0, worldy = 0;
        public string mapfile, resourceDir = AppDomain.CurrentDomain.BaseDirectory + @"\..\..\Resources\";

        public Map(string mapname, int mapXsize, int mapYsize, int worldXsize, int worldYsize)
        {
            map = new int[mapXsize, mapYsize, worldXsize, worldYsize];
            walk = new int[mapXsize, mapYsize, worldXsize, worldYsize];
            item = new int[mapXsize, mapYsize, worldXsize, worldYsize];
            tilewalk = new int[tileset.Length * 256];
            tile = new Bitmap[tileset.Length * 256];
            mapfile = resourceDir + @"Maps\" + mapname;
            LoadTiles();
        }
        
        public void LoadTiles()
        {
            for (int j = 0; j < tileset.Length; j++)
            {
                tileset[j] = (Bitmap)Image.FromFile(resourceDir + @"Sets\" + "set" + j + ".bmp");
                for (int i = 0; i < 256; i++)
                {
                    tile[(256 * j) + i] = tileset[j].Clone(new Rectangle((i - (8 * (i / 8))) * 32, (i / 8) * 32, 32, 32), tileset[j].PixelFormat);
                }
                tileset[j].Dispose();
            }
            string[] integerStrings = File.ReadAllText(resourceDir + @"Sets\" + "tiles.txt").Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < tilewalk.Length; i++)
            {
                tilewalk[i] = int.Parse(integerStrings[i]);
            }
        }

        public void DrawMap(PaintEventArgs e)
        {
            int n = tilenum;
            for (int Y = 0; Y < map.GetLength(1); Y++)
            {
                for (int X = 0; X < map.GetLength(0); X++)
                {
                    tilenum = map[X, Y, worldx, worldy];
                    e.Graphics.DrawImage(tile[tilenum], X * 32, Y * 32, 32, 32);
                }
            }
            tilenum = n;
        }

        public void DrawTile(PictureBox DrawTo, int X, int Y)
        {
            Graphics g = DrawTo.CreateGraphics();
            g.DrawImage(tile[tilenum], X * 32, Y * 32, 32, 32);
            map[X, Y, worldx, worldy] = tilenum;
            walk[X, Y, worldx, worldy] = tilewalk[tilenum];
        }

        public void LoadMap()
        {
            char[] maptype = { 't', 'w', 'i' };
            for (int m = 0; m < maptype.Length; m++)
            {
                string[] integerStrings = File.ReadAllText(mapfile + "_" + maptype[m] + ".txt").Split(new char[] { ' ', '\t', '\r', '\n' }, StringSplitOptions.RemoveEmptyEntries);
                for (int l = 0; l < map.GetLength(3); l++)
                {
                    for (int k = 0; k < map.GetLength(2); k++)
                    {
                        for (int j = 0; j < map.GetLength(1); j++)
                        {
                            for (int i = 0; i < map.GetLength(0); i++)
                            {
                                switch (m)
                                {
                                    case 0: map[i, j, k, l] = int.Parse(integerStrings[i + (j * map.GetLength(0)) + (k * map.GetLength(0) * map.GetLength(1)) + (l * map.GetLength(0) * map.GetLength(1) * map.GetLength(2))]); break;
                                    case 1: walk[i, j, k, l] = int.Parse(integerStrings[i + (j * map.GetLength(0)) + (k * map.GetLength(0) * map.GetLength(1)) + (l * map.GetLength(0) * map.GetLength(1) * map.GetLength(2))]); break;
                                    case 2: item[i, j, k, l] = int.Parse(integerStrings[i + (j * map.GetLength(0)) + (k * map.GetLength(0) * map.GetLength(1)) + (l * map.GetLength(0) * map.GetLength(1) * map.GetLength(2))]); break;
                                }
                            }
                        }
                    }
                }
            }
        }

        public void SaveMap()
        {
            Start:
            if (File.Exists(mapfile))
            {
                char[] maptype = { 't', 'w', 'i' };
                for (int m = 0; m < maptype.Length; m++)
                {
                    TextWriter file = new StreamWriter(mapfile + "_" + maptype[m] + ".txt");
                    for (int l = 0; l < map.GetLength(3); l++)
                    {
                        for (int k = 0; k < map.GetLength(2); k++)
                        {
                            for (int j = 0; j < map.GetLength(1); j++)
                            {
                                for (int i = 0; i < map.GetLength(0); i++)
                                {
                                    switch (m)
                                    {
                                        case 0: file.Write(map[i, j, k, l] + " "); break;
                                        case 1: file.Write(walk[i, j, k, l] + " "); break;
                                        case 2: file.Write(item[i, j, k, l] + " "); break;
                                    }
                                }
                                file.WriteLine();
                            }
                        }
                    }
                    file.Close();
                }
            }
            else { File.Create(mapfile); goto Start; }
        }
    }
}