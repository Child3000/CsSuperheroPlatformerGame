using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatmanPlatform
{
    public partial class Form1 : Form
    {
        bool landed = false;
        int gravity = 5;
        int score = 0;
        int platformSpeed = 10;
        Random rnd = new Random();


        public Form1()
        {
            InitializeComponent();
        }

        private void IsKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && landed == true)
            {
                gravity = -gravity;
                landed = false;
            }

            if (e.KeyCode == Keys.R)
            {
                reset();
            }
        }

        private void Game_Tick(object sender, EventArgs e)
        {
            player.Top += gravity;
            player.Left = 80;
            lblScore.Text = "Score: " + score;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Platform")
                {
                    x.Left -= platformSpeed;


                    if (x.Left < -500)
                    {
                        x.Left = 500;
                        x.Width = rnd.Next(100, 300);
                        score++;
                    }
                }
            }

            if (player.Bounds.IntersectsWith(p2.Bounds) ||
               player.Bounds.IntersectsWith(p1.Bounds))
            {
                landed = true;
                player.Top = p2.Top - player.Height;
                player.Image = Properties.Resources.batman_1;
            }

            if (player.Bounds.IntersectsWith(p3.Bounds) ||
                player.Bounds.IntersectsWith(p4.Bounds))
            {
                landed = true;
                player.Top = p3.Top + p3.Height;
                player.Image = Properties.Resources.batman_2;
            }

            if (player.Top < -40 || player.Top > ClientSize.Height)
            {
                gameTimer.Stop();
                lblScore.Text += " -- Press R to reset";
            }
        }

        private void reset()
        {
            score = 0;
            p1.Width = 273;
            p2.Width = 273;
            p3.Width = 273;
            p4.Width = 273;
            player.Left = 147;
            player.Top = 131;

            p1.Left = 104;
            p1.Top = 235;

            p2.Left = 491;
            p2.Top = 235;

            p3.Left = 304;
            p3.Top = 26;

            p4.Left = 702;
            p4.Top = 26;

            gameTimer.Start();
        }
    }
}
