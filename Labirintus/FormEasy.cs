using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TrackBar;
using Timer = System.Windows.Forms.Timer;

namespace Labirintus
{
    public partial class FormEasy : Form
    {
        PictureBox player = new PictureBox();
        List<PictureBox> tégla = new List<PictureBox>();
        List<PictureBox> finish = new List<PictureBox>();

        int lépésekSzáma = 0;

        Stopwatch stopwatch = new Stopwatch();
        Timer timer = new Timer();

        int mazeRows =0;
        int mazeCols =0;

        public FormEasy()
        {
            InitializeComponent();

            label1.Text = "Még nem léptél egyet sem!";
            stopwatch.Start();
            
            timer.Interval = 1000;
            timer.Tick += Timer_Tick;
            timer.Start();
        }

        private void Timer_Tick(object? sender, EventArgs e)
        {
            label2.Text = $"Az eltelt idő: {stopwatch.Elapsed.Minutes:D2}:{stopwatch.Elapsed.Seconds:D2}";
        }

        private void FormEasy_Load(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("Maze/maze1.txt");
                int y = 0;
                while (!sr.EndOfStream)
                {
                    string sor = sr.ReadLine();
                    mazeCols = sor.Length;
                    for (int x = 0; x < sor.Length; x++)
                    {
                        if (sor[x] == '#')
                        {
                            PictureBox pb = new PictureBox();
                            pb.Location = new Point(x * 20, y * 20);
                            pb.Size = new Size(20, 20);
                            pb.Image = Image.FromFile("Icon/brick.png");
                            pb.SizeMode = PictureBoxSizeMode.StretchImage;
                            this.Controls.Add(pb);
                            tégla.Add(pb);
                        }
                        if (sor[x] == 'E')
                        {
                            PictureBox cél = new PictureBox();
                            cél.Location = new Point(x * 20, y * 20);
                            cél.Size = new Size(20, 20);
                            cél.Image = Image.FromFile("Icon/finish.png");
                            cél.SizeMode = PictureBoxSizeMode.StretchImage;
                            this.Controls.Add(cél);
                            finish.Add(cél);
                        }
                    }
                    y++;
                }
                mazeRows = y;
                sr.Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


            player.Location = new Point(0, 0);
            player.Size = new Size(20, 20);
            player.Image = Image.FromFile("Icon/running.png");
            player.SizeMode = PictureBoxSizeMode.StretchImage;
            Controls.Add(player);

            SetFormSize(mazeRows, mazeCols);
            KeyDown += FormEasy_KeyDown;
        }

        private void LépésSzámláló()
        {
            lépésekSzáma++;
            label1.Text = $"Az eddigi lépések száma {lépésekSzáma}";
        }

        private void SetFormSize(int rows, int cols)
        {
            int titleSize = 20;
            int mazeWidt = cols * titleSize;
            int mazeHeight = rows * titleSize;
            int extraHeight = 40;

            this.ClientSize = new System.Drawing.Size(mazeWidt, mazeHeight + extraHeight);
        }


        private void FormEasy_KeyDown(object? sender, KeyEventArgs e)
        {
            int x = player.Location.X;
            int y = player.Location.Y;

            if (e.KeyCode == Keys.Right)
            {
                x += 20;
                LépésSzámláló();
            }

            if (e.KeyCode == Keys.Left)
            {
                x -= 20;
                LépésSzámláló();
            }

            if (e.KeyCode == Keys.Up)
            {
                y -= 20;
                LépésSzámláló();
            }

            if (e.KeyCode == Keys.Down)
            {
                y += 20;
                LépésSzámláló();
            }

            var wall = tégla.FirstOrDefault(w => w.Location.X == x && w.Location.Y == y);
            if (wall == null)
            {
                player.Location = new Point(x, y);
            }

            var célállomás = finish.FirstOrDefault(c => c.Location.X == x && c.Location.Y == y);
            if (célállomás != null)
            {
                timer.Stop();
                FormRestart restart = new FormRestart();
                restart.ShowDialog();
                
            }
        }
    }
}
