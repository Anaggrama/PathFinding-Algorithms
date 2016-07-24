using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;

namespace WindowsFormsApplication1
{
    public partial class Main : Form
    {
        public int MapSizeX = 40;
        public int MapSizeY = 30;

        sMapData[,] MapData = new sMapData[40, 30];
        sPos StartPos = new sPos(1, 4);
        sPos EndPos = new sPos(25, 27);

        sOptions Options = new sOptions();

        public int LastMouseX;
        public int LastMouseY;

        public Main()
        {
            InitializeComponent();
            Pantalla.Paint += new PaintEventHandler(Pantalla_Paint);
            LoadMap();

            Options.ShowTempPaths = false;
            mnuDTempPath.Checked = Options.ShowTempPaths;
        }

        private void Pantalla_Paint(object sender, PaintEventArgs e)
        {
            int x;
            int y;

            Graphics grp = e.Graphics;

            for (x = 0; x <= 39; x++)
            {
                for (y = 0; y <= 29; y++)
                {
                    if (MapData[x, y].Bloq == 1)
                    {
                        SolidBrush brush = new SolidBrush(Color.Red);
                        grp.FillRectangle(brush, x * 10, y * 10, 10, 10);
                    }
                    if (MapData[x, y].Type == 1)
                    {
                        SolidBrush brush = new SolidBrush(Color.Blue);
                        grp.FillRectangle(brush, x * 10, y * 10, 10, 10);
                    }
                    else if (MapData[x, y].Type == 2)
                    {
                        SolidBrush brush = new SolidBrush(Color.Green);
                        grp.FillRectangle(brush, x * 10, y * 10, 10, 10);
                    }
                    else if (MapData[x, y].tmpPath == 1)
                    {
                        SolidBrush brush = new SolidBrush(Color.Yellow);
                        grp.FillRectangle(brush, x * 10, y * 10, 10, 10);
                    }
                    if (MapData[x, y].Path == 1)
                    {
                        SolidBrush brush = new SolidBrush(Color.Orange);
                        grp.FillRectangle(brush, x * 10, y * 10, 10, 10);
                    }
                    Pen pen = new Pen(Color.Black);
                    grp.DrawRectangle(pen, x * 10, y * 10, 10, 10);
                }
            }

            
        }

        private void LoadMap()
        {
            MapData[0, 0].Bloq = 1;
            MapData[1, 0].Bloq = 1;
            MapData[2, 0].Bloq = 1;
            MapData[3, 0].Bloq = 1;
            MapData[4, 0].Bloq = 1;
            MapData[5, 0].Bloq = 1;
            MapData[6, 0].Bloq = 1;
            MapData[7, 0].Bloq = 1;
            MapData[8, 0].Bloq = 1;
            MapData[9, 0].Bloq = 1;
            MapData[10, 0].Bloq = 1;
            MapData[11, 0].Bloq = 1;
            MapData[12, 0].Bloq = 1;
            MapData[13, 0].Bloq = 1;
            MapData[14, 0].Bloq = 1;
            MapData[15, 0].Bloq = 1;
            MapData[16, 0].Bloq = 1;
            MapData[17, 0].Bloq = 1;
            MapData[18, 0].Bloq = 1;
            MapData[19, 0].Bloq = 1;
            MapData[20, 0].Bloq = 1;
            MapData[21, 0].Bloq = 1;
            MapData[22, 0].Bloq = 1;
            MapData[23, 0].Bloq = 1;
            MapData[24, 0].Bloq = 1;
            MapData[25, 0].Bloq = 1;
            MapData[26, 0].Bloq = 1;
            MapData[27, 0].Bloq = 1;
            MapData[28, 0].Bloq = 1;
            MapData[29, 0].Bloq = 1;
            MapData[30, 0].Bloq = 1;
            MapData[31, 0].Bloq = 1;
            MapData[32, 0].Bloq = 1;
            MapData[33, 0].Bloq = 1;
            MapData[34, 0].Bloq = 1;
            MapData[35, 0].Bloq = 1;
            MapData[36, 0].Bloq = 1;
            MapData[37, 0].Bloq = 1;
            MapData[38, 0].Bloq = 1;
            MapData[39, 0].Bloq = 1;
            MapData[0, 29].Bloq = 1;
            MapData[1, 29].Bloq = 1;
            MapData[2, 29].Bloq = 1;
            MapData[3, 29].Bloq = 1;
            MapData[4, 29].Bloq = 1;
            MapData[5, 29].Bloq = 1;
            MapData[6, 29].Bloq = 1;
            MapData[7, 29].Bloq = 1;
            MapData[8, 29].Bloq = 1;
            MapData[9, 29].Bloq = 1;
            MapData[10, 29].Bloq = 1;
            MapData[11, 29].Bloq = 1;
            MapData[12, 29].Bloq = 1;
            MapData[13, 29].Bloq = 1;
            MapData[14, 29].Bloq = 1;
            MapData[15, 29].Bloq = 1;
            MapData[16, 29].Bloq = 1;
            MapData[17, 29].Bloq = 1;
            MapData[18, 29].Bloq = 1;
            MapData[19, 29].Bloq = 1;
            MapData[20, 29].Bloq = 1;
            MapData[21, 29].Bloq = 1;
            MapData[22, 29].Bloq = 1;
            MapData[23, 29].Bloq = 1;
            MapData[24, 29].Bloq = 1;
            MapData[25, 29].Bloq = 1;
            MapData[26, 29].Bloq = 1;
            MapData[27, 29].Bloq = 1;
            MapData[28, 29].Bloq = 1;
            MapData[29, 29].Bloq = 1;
            MapData[30, 29].Bloq = 1;
            MapData[31, 29].Bloq = 1;
            MapData[32, 29].Bloq = 1;
            MapData[33, 29].Bloq = 1;
            MapData[34, 29].Bloq = 1;
            MapData[35, 29].Bloq = 1;
            MapData[36, 29].Bloq = 1;
            MapData[37, 29].Bloq = 1;
            MapData[38, 29].Bloq = 1;
            MapData[39, 29].Bloq = 1;
            MapData[0, 1].Bloq = 1;
            MapData[0, 2].Bloq = 1;
            MapData[0, 3].Bloq = 1;
            MapData[0, 4].Bloq = 1;
            MapData[0, 5].Bloq = 1;
            MapData[0, 6].Bloq = 1;
            MapData[0, 7].Bloq = 1;
            MapData[0, 8].Bloq = 1;
            MapData[0, 9].Bloq = 1;
            MapData[0, 10].Bloq = 1;
            MapData[0, 11].Bloq = 1;
            MapData[0, 12].Bloq = 1;
            MapData[0, 13].Bloq = 1;
            MapData[0, 14].Bloq = 1;
            MapData[0, 15].Bloq = 1;
            MapData[0, 16].Bloq = 1;
            MapData[0, 17].Bloq = 1;
            MapData[0, 18].Bloq = 1;
            MapData[0, 19].Bloq = 1;
            MapData[0, 20].Bloq = 1;
            MapData[0, 21].Bloq = 1;
            MapData[0, 22].Bloq = 1;
            MapData[0, 23].Bloq = 1;
            MapData[0, 24].Bloq = 1;
            MapData[0, 25].Bloq = 1;
            MapData[0, 26].Bloq = 1;
            MapData[0, 27].Bloq = 1;
            MapData[0, 28].Bloq = 1;
            MapData[0, 29].Bloq = 1;
            MapData[39, 1].Bloq = 1;
            MapData[39, 2].Bloq = 1;
            MapData[39, 3].Bloq = 1;
            MapData[39, 4].Bloq = 1;
            MapData[39, 5].Bloq = 1;
            MapData[39, 6].Bloq = 1;
            MapData[39, 7].Bloq = 1;
            MapData[39, 8].Bloq = 1;
            MapData[39, 9].Bloq = 1;
            MapData[39, 10].Bloq = 1;
            MapData[39, 11].Bloq = 1;
            MapData[39, 12].Bloq = 1;
            MapData[39, 13].Bloq = 1;
            MapData[39, 14].Bloq = 1;
            MapData[39, 15].Bloq = 1;
            MapData[39, 16].Bloq = 1;
            MapData[39, 17].Bloq = 1;
            MapData[39, 18].Bloq = 1;
            MapData[39, 19].Bloq = 1;
            MapData[39, 20].Bloq = 1;
            MapData[39, 21].Bloq = 1;
            MapData[39, 22].Bloq = 1;
            MapData[39, 23].Bloq = 1;
            MapData[39, 24].Bloq = 1;
            MapData[39, 25].Bloq = 1;
            MapData[39, 26].Bloq = 1;
            MapData[39, 27].Bloq = 1;
            MapData[39, 28].Bloq = 1;
            MapData[39, 29].Bloq = 1;

            MapData[StartPos.X, StartPos.Y].Type = 1;
            MapData[EndPos.X, EndPos.Y].Type = 2;
        }

        private void cmdSimplePath_Click(object sender, EventArgs e)
        {
            int i = 0;
            int firsti = 0;
            int lasti = 0;
            int newfirsti = 0;
            int newlasti = 0;
            int lastpath = 0;
            int iterations = 0;
            bool finished = false;
            bool used = false;
            bool unreachable = false;
            Stopwatch watch = new Stopwatch();

            List<PathInfo> Path = new List<PathInfo>();
            Path.Add(new PathInfo(StartPos.X, StartPos.Y, i));

            ClearPaths();

            watch.Start();
            do
            {
                iterations++;
                newfirsti = 0;
                for (i = firsti; i <= lasti; i++)
                {
                    PathInfo tmpPath = Path[i];
                    if (MapData[tmpPath.X, tmpPath.Y - 1].Bloq == 0)
                    {
                        used = false;
                        if (MapData[tmpPath.X, tmpPath.Y - 1].tmpPath == 1) { used = true; }

                        if (used == false)
                        {
                            newlasti++;
                            if (newfirsti == 0) { newfirsti = newlasti; }
                            Path.Add(new PathInfo(tmpPath.X, tmpPath.Y - 1, i));
                            MapData[tmpPath.X, tmpPath.Y - 1].tmpPath = 1;
                            if (MapData[tmpPath.X, tmpPath.Y - 1].Type == 2)
                            {
                                finished = true;
                                lastpath = i;
                                break;
                            }
                        }
                    }
                    if (MapData[tmpPath.X, tmpPath.Y + 1].Bloq == 0)
                    {
                        used = false;
                        if (MapData[tmpPath.X, tmpPath.Y + 1].tmpPath == 1) { used = true; }

                        if (used == false)
                        {
                            newlasti++;
                            if (newfirsti == 0) { newfirsti = newlasti; }
                            Path.Add(new PathInfo(tmpPath.X, tmpPath.Y + 1, i));
                            MapData[tmpPath.X, tmpPath.Y + 1].tmpPath = 1;
                            if (MapData[tmpPath.X, tmpPath.Y + 1].Type == 2)
                            {
                                finished = true;
                                lastpath = i;
                                break;
                            }
                        }
                    }
                    if (MapData[tmpPath.X + 1, tmpPath.Y].Bloq == 0)
                    {
                        used = false;
                        if (MapData[tmpPath.X + 1, tmpPath.Y].tmpPath == 1) { used = true; }

                        if (used == false)
                        {
                            newlasti++;
                            if (newfirsti == 0) { newfirsti = newlasti; }
                            Path.Add(new PathInfo(tmpPath.X + 1, tmpPath.Y, i));
                            MapData[tmpPath.X + 1, tmpPath.Y].tmpPath = 1;
                            if (MapData[tmpPath.X + 1, tmpPath.Y].Type == 2)
                            {
                                finished = true;
                                lastpath = i;
                                break;
                            }
                        }
                    }
                    if (MapData[tmpPath.X - 1, tmpPath.Y].Bloq == 0)
                    {
                        used = false;
                        if (MapData[tmpPath.X - 1, tmpPath.Y].tmpPath == 1) { used = true; }

                        if (used == false)
                        {
                            newlasti++;
                            if (newfirsti == 0) { newfirsti = newlasti; }
                            Path.Add(new PathInfo(tmpPath.X - 1, tmpPath.Y, i));
                            MapData[tmpPath.X - 1, tmpPath.Y].tmpPath = 1;
                            if (MapData[tmpPath.X - 1, tmpPath.Y].Type == 2)
                            {
                                finished = true;
                                lastpath = i;
                                break;
                            }
                        }
                    }
                }
                if (lasti == newlasti)
                {
                    MessageBox.Show("Target unreachable.");
                    unreachable = true;
                    break; 
                }
                lasti = newlasti;
                firsti = newfirsti;
                if (Options.ShowTempPaths) { Pantalla.Refresh(); }
            }
            while (finished == false);

            watch.Stop();
            txtIteraciones.Text = iterations.ToString();
            txtTiempo.Text = String.Format("{0} ms",watch.Elapsed.Milliseconds.ToString());

            ClearPaths();
            if (unreachable == false)
            {
                do
                {
                    PathInfo lastPath = Path[lastpath];
                    MapData[lastPath.X, lastPath.Y].Path = 1;
                    lastpath = lastPath.PREV;
                    Pantalla.Refresh();
                }
                while (lastpath > 0);
            }
        }

        private void ClearPaths()
        {
            int x = 0;
            int y = 0;

            for (x = 1; x < 39; x++)
            {
                for (y = 1; y < 29; y++)
                {
                    MapData[x, y].Path = 0;
                    MapData[x, y].tmpPath = 0;
                }
            }
            Pantalla.Refresh();
        }

        private void Pantalla_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                var pos = Pantalla.PointToClient(Cursor.Position);
                int posx = pos.X / 10;
                int posy = pos.Y / 10;
                if ((posx < 1) || (posx > 38) || (posy < 1) || (posy > 28)) { return; }
                if ((LastMouseX != posx) || (LastMouseY != posy))
                {
                    LastMouseX = posx;
                    LastMouseY = posy;
                    if (MapData[posx, posy].Bloq == 0)
                    {
                        MapData[posx, posy].Bloq = 1;
                    }
                    else
                    {
                        MapData[posx, posy].Bloq = 0;
                    }
                    Pantalla.Refresh();
                }
            }
        }

        private void cmdClear_Click(object sender, EventArgs e)
        {
            int x = 0;
            int y = 0;

            for (x = 1; x < 39; x++)
            {
                for (y = 1; y < 29; y++)
                {
                    MapData[x, y].Path = 0;
                    MapData[x, y].Bloq = 0;
                }
            }

            Pantalla.Refresh();
        }

        private void cmdClearPath_Click(object sender, EventArgs e)
        {
            ClearPaths();
        }

        private void Pantalla_Click(object sender, EventArgs e)
        {
            var pos = Pantalla.PointToClient(Cursor.Position);
            int posx = pos.X / 10;
            int posy = pos.Y / 10;
            if ((posx < 1) || (posx > 38) || (posy < 1) || (posy > 28)) { return; }
            if ((LastMouseX != posx) || (LastMouseY != posy))
            {
                LastMouseX = posx;
                LastMouseY = posy;
                if (MapData[posx, posy].Bloq == 0)
                {
                    MapData[posx, posy].Bloq = 1;
                }
                else
                {
                    MapData[posx, posy].Bloq = 0;
                }
                Pantalla.Refresh();
            }
        }

        private void mnuDTempPath_Click(object sender, EventArgs e)
        {
            if (mnuDTempPath.Checked == true)
            {
                mnuDTempPath.Checked = false;
                Options.ShowTempPaths = false;
            }
            else
            {
                mnuDTempPath.Checked = true;
                Options.ShowTempPaths = true;
            }
        }
    }

    public class PathInfo
    {
        public int X { get; set; }
        public int Y { get; set; }
        public int PREV { get; set; }

        public PathInfo(int x, int y, int prev)
        {
            X = x;
            Y = y;
            PREV = prev;
        }
    }

    public struct sMapData
    {
        public byte Type;
        public byte Bloq;
        public byte Path;
        public byte tmpPath;
    }

    public struct sPos
    {
        public byte X;
        public byte Y;

        public sPos(byte x, byte y)
        {
            X = x;
            Y = y;
        }
    }

    public struct sOptions
    {
        public bool ShowTempPaths;
    }

}
