﻿using System;
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
        List<PictureBox> healthVisibleList = new List<PictureBox>();
        List<PictureBox> healthInvisibleList = new List<PictureBox>();

        Timer shootRateTick = new Timer();
        Timer ignoreGravityTick = new Timer();
        bool allowFire = true;
        bool playerIsDown = true;

        #endregion

        Random rnd = new Random();
        


        public Form1()
        {
            InitializeComponent();
            UIManager.InitializeSetting(ref lblScore);
            BatmanPlatform.Dash.InitializePlatformSpeed(10);
            player.Left = 80;

            #region Initialize Timer for Shoot Rate

            // Tick is controlled by Condition of Shoot Event   //
            shootRateTick.Tick += new EventHandler(tm_ShootRateTick);

            #endregion

            #region Initialize Timer for Ignoring Gravity

            ignoreGravityTick.Tick += new EventHandler(tm_ignoreGravityTick);


            #endregion

            #region Add Control to HeroSelection Menu

            foreach (Control h in this.Controls)
            {
                if (h.Tag == "HeroSelection")
                {
                    heroSelectionList.Add(h);
                }
            }

            #endregion

            #region Add Control to Health UI

            ResetHealthControl();

            #endregion
        }

        private void IsKeyDown(object sender, KeyEventArgs e)
        {
            //  Jump    //
            if (e.KeyCode == Keys.Space && CharacterProperties.IsGrounded)
            {
                CharacterProperties.ReverseGravity();
                CharacterProperties.LeaveGround();
                CharacterProperties.AllowImageConversion();
            }

            if (UIManager.gameOver && e.KeyCode == Keys.R)
            {
                RestartGame();
            }

            //  Fire with rate  //
            if (allowFire && e.KeyCode == Keys.Z)
            {
                Shoot();

                allowFire = false;
                shootRateTick.Start();
            }

            //  Dash On Air   //    //  After Dash, Push Gravity Down   //
            if (BatmanPlatform.Dash.AllowDash && e.KeyCode == Keys.C && !CharacterProperties.IsGrounded)
            {
                ChangeVisibilityDash();

                BatmanPlatform.Dash.RestrictDashKey();
                CharacterProperties.Gravity = 0;
                ignoreGravityTick.Start();

                BatmanPlatform.Dash.PerformDashAction();
            }

        }

        private void Game_Tick(object sender, EventArgs e)
        {
            player.Top += CharacterProperties.Gravity;

            int heightRatio = playerIsDown ? player.Height / 2 : -player.Height / 3;
            dash.Top = player.Top + heightRatio;
            dash.Left = player.Left - ( player.Width + 20 );

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && x.Tag == "Platform")
                {
                    x.Left -= BatmanPlatform.Dash.PlatformSpeed;


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
                    playerIsDown = true;
                    player.Image = CharacterProperties.HeroImage[0];
                    dash.Image = Dash.DashImage[0];
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
                    playerIsDown = false;
                    player.Image = CharacterProperties.HeroImage[1];
                    dash.Image = Dash.DashImage[1];
                    CharacterProperties.RestrictImageOverlap();
                }
            }

            if (player.Top < -40 || player.Top > ClientSize.Height)
            {
                CharacterProperties.UpdateHealth(1, ref healthVisibleList, ref healthInvisibleList);

                if (CharacterProperties.isDeath())
                {
                    gameTimer.Stop();
                    lblScore.Text += " -- Press R to reset";
                }

                else
                {
                    CharacterProperties.AllowImageConversion();
                    Respawn();
                }


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
            ResetHealthControl();
            KeyPreview = true;
            player.Image = CharacterProperties.HeroImage[0];
            shootRateTick.Interval = CharacterProperties.ShootRate;
            ignoreGravityTick.Interval = BatmanPlatform.Dash.DashPeriod;
            gameTimer.Start();
        }

        private void OnMouseDown_Batman(object sender, MouseEventArgs e)
        {
            newHero = CharacterCreation.CreateCustomCharacter(HeroType.Batman);
        }

        private void OnMouseUp_Batman(object sender, MouseEventArgs e)
        {
            ChangeVisibilityHeroSelection();
            ResetHealthControl();
            KeyPreview = true;
            player.Image = CharacterProperties.HeroImage[0];
            shootRateTick.Interval = CharacterProperties.ShootRate;
            ignoreGravityTick.Interval = BatmanPlatform.Dash.DashPeriod;
            gameTimer.Start();
        }

        private void OnMouseDown_Catwoman(object sender, MouseEventArgs e)
        {
            newHero = CharacterCreation.CreateCustomCharacter(HeroType.Catwoman);
        }

        private void OnMouseUp_Catwoman(object sender, MouseEventArgs e)
        {
            ChangeVisibilityHeroSelection();
            ResetHealthControl();
            KeyPreview = true;
            player.Image = CharacterProperties.HeroImage[0];
            shootRateTick.Interval = CharacterProperties.ShootRate;
            ignoreGravityTick.Interval = BatmanPlatform.Dash.DashPeriod;
            gameTimer.Start();
        }

        private void OnMouseDown_WonderWoman(object sender, MouseEventArgs e)
        {
            newHero = CharacterCreation.CreateCustomCharacter(HeroType.WonderWoman);
        }

        private void OnMouseUp_WonderWoman(object sender, MouseEventArgs e)
        {
            ChangeVisibilityHeroSelection();
            ResetHealthControl();
            KeyPreview = true;
            player.Image = CharacterProperties.HeroImage[0];
            shootRateTick.Interval = CharacterProperties.ShootRate;
            ignoreGravityTick.Interval = BatmanPlatform.Dash.DashPeriod;
            gameTimer.Start();
        }

        private void OnMouseDown_Speedy(object sender, MouseEventArgs e)
        {
            newHero = CharacterCreation.CreateCustomCharacter(HeroType.Speedy);
        }

        private void OnMouseUp_Speedy(object sender, MouseEventArgs e)
        {
            ChangeVisibilityHeroSelection();
            ResetHealthControl();
            KeyPreview = true;
            player.Image = CharacterProperties.HeroImage[0];
            shootRateTick.Interval = CharacterProperties.ShootRate;
            ignoreGravityTick.Interval = BatmanPlatform.Dash.DashPeriod;
            gameTimer.Start();
        }

        #endregion


        private void ResetHealthControl()
        {
            healthVisibleList.Clear();
            healthInvisibleList.Clear();

            #region Visibility

            Heart_0.Visible = true;
            Heart_1.Visible = true;
            Heart_2.Visible = true;
            Heart_3.Visible = false;
            Heart_4.Visible = false;

            #endregion

            #region Number of Health To Be Displayed

            // Assume every hero has minimum amount of 3 health
            healthVisibleList.Insert(0, Heart_0);
            healthVisibleList.Insert(1, Heart_1);
            healthVisibleList.Insert(2, Heart_2);

            if (CharacterProperties.Health >= 4)
            {
                healthVisibleList.Insert(3, Heart_3);
                Heart_3.Visible = true;
            }

            if (CharacterProperties.Health >= 5)
            {
                healthVisibleList.Insert(4, Heart_4);
                Heart_4.Visible = true;
            }

            #endregion

            #region Health Image

            foreach (PictureBox pBox in healthVisibleList)
            {
                pBox.Image = UIManager.HeroHealthImage;
            }

            #endregion

            healthInvisibleList = new List<PictureBox>() { null, null, null, null, null };
        }

        private void Respawn()
        {
            player.Left = 147;
            player.Top = 131;
        }

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

        private void Shoot()
        {
            Laser laser = new Laser(player, this);
        }

        private void tm_ShootRateTick(object sender, EventArgs e)
        {
            allowFire = true;
            shootRateTick.Stop();
        }

        private void tm_ignoreGravityTick (object sender, EventArgs e)
        {
            ChangeVisibilityDash();
            CharacterProperties.ResetGravityToDefault();
            ignoreGravityTick.Stop();
        }

        private void ChangeVisibilityDash()
        {
            dash.Visible = !dash.Visible;
        }
    }
}
