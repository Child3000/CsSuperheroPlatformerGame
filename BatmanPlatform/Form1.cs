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
        #region Experiment

        Hero newHero;
        List<Control> heroSelectionList = new List<Control>();

        bool gameOver = false;

        #endregion

        int platformSpeed = 10;
        Random rnd = new Random();


        public Form1()
        {
            InitializeComponent();
            UIManager.InitializeSetting(ref lblScore);
            player.Left = 80;

            #region Add Control to HeroSelection Menu

            foreach (Control h in this.Controls)
            {
                if (h.Tag == "HeroSelection")
                {
                    heroSelectionList.Add(h);
                }
            }

            #endregion
        }

        private void IsKeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Space && CharacterProperties.IsGrounded)
            {
                CharacterProperties.Gravity = -(CharacterProperties.Gravity);
                CharacterProperties.LeaveGround();
                CharacterProperties.AllowImageConversion();
            }

            if (gameOver && e.KeyCode == Keys.R)
            {
                RestartGame();
            }
        }

        private void Game_Tick(object sender, EventArgs e)
        {
            player.Top += CharacterProperties.Gravity;

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Platform")
                {
                    x.Left -= platformSpeed;


                    if (x.Left < -500)
                    {
                        x.Left = 500;
                        x.Width = rnd.Next(100, 300);
                        UIManager.UpdateScore(ref lblScore, 1);
                    }
                }
            }

            if (player.Bounds.IntersectsWith(p2.Bounds) ||
               player.Bounds.IntersectsWith(p1.Bounds))
            {
                CharacterProperties.ReachGround();
                player.Top = p2.Top - player.Height;

                if(CharacterProperties.AlreadyIsGrounded)
                {
                    player.Image = CharacterProperties.HeroImage[0];
                    CharacterProperties.RestrictImageOverlap();
                }
            }

            if (player.Bounds.IntersectsWith(p3.Bounds) ||
                player.Bounds.IntersectsWith(p4.Bounds))
            {
                CharacterProperties.ReachGround();
                player.Top = p3.Top + p3.Height;

                if(CharacterProperties.AlreadyIsGrounded)
                {
                    player.Image = CharacterProperties.HeroImage[1];
                    CharacterProperties.RestrictImageOverlap();
                }
            }

            if (player.Top < -40 || player.Top > ClientSize.Height)
            {
                gameTimer.Stop();
                gameOver = true;
                lblScore.Text += " -- Press R to reset";
            }
        }

        #region Handle CharacterCustomization

        private void ChangeVisibilityHeroSelection()
        {
            for (int i=0; i < heroSelectionList.Count; i++)
            {
                heroSelectionList[i].Visible = !heroSelectionList[i].Visible;

            }

        }

        private void OnMouseDown_Superman(object sender, MouseEventArgs e)
        {
            newHero = CharacterCreation.CreateCustomCharacter(HeroType.Superman);
        }

        private void OnMouseUp_Superman(object sender, MouseEventArgs e)
        {
            ChangeVisibilityHeroSelection();
            KeyPreview = true;
            player.Image = CharacterProperties.HeroImage[0];
            gameTimer.Start();
        }

        private void OnMouseDown_Batman(object sender, MouseEventArgs e)
        {
            newHero = CharacterCreation.CreateCustomCharacter(HeroType.Batman);
        }

        private void OnMouseUp_Batman(object sender, MouseEventArgs e)
        {
            ChangeVisibilityHeroSelection();
            KeyPreview = true;
            player.Image = CharacterProperties.HeroImage[0];
            gameTimer.Start();
        }

        #endregion


        private void RestartGame()
        {
            UIManager.Score = 0;

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

            KeyPreview = false;
            ChangeVisibilityHeroSelection();
        }
    }
}
