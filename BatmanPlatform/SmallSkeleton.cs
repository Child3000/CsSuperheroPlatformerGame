using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BatmanPlatform
{
    class SmallSkeleton : EnemyProperties
    {
        const int CONST_MIN_HEALTH = 0;

        public PictureBox tinySkeleton = new PictureBox();

        public Timer AnimateExplosionTimer = new Timer();
        Timer ChangeStateTimer = new Timer();

        Random rnd = new Random();

        bool isAnimationWork = false;
        bool isSmall = false;
        bool isDamageAnimationWorking = false;
        bool isDamagePlayer = false;
        int damageAnimateCount = 0;
        int stateCount = 0;
        int ranNum = -1;


        public SmallSkeleton(Form form)
        {
            tinySkeleton.Image = Properties.Resources.skeletonSwordStill;
            tinySkeleton.SizeMode = PictureBoxSizeMode.Zoom;
            tinySkeleton.Size = new Size(100, 100);
            tinySkeleton.BackColor = Color.Transparent;
            tinySkeleton.Tag = "Enemy";

            tinySkeleton.Left = rnd.Next(600, 800);
            tinySkeleton.Top = rnd.Next(50, 128);

            form.Controls.Add(tinySkeleton);
            tinySkeleton.BringToFront();

            InitializeProperties(LevelManager.SkeletonHealth, LevelManager.SkeletonSpeed);

            ChangeStateTimer.Interval = 2000;
            ChangeStateTimer.Tick += new EventHandler(tm_ChangeStateTick);
            ChangeStateTimer.Start();

            AnimateExplosionTimer.Interval = 500;
            AnimateExplosionTimer.Tick += new EventHandler(tm_AnimateExplosion);
        }

        public void FollowPlayer( ref PictureBox player)
        {
            if (isAnimationWork)
            {
                tinySkeleton.Image = Properties.Resources.skeletonSwordMove;
                isAnimationWork = false;
            }

            if (player.Left + player.Width * 2 < tinySkeleton.Left)
                tinySkeleton.Left -= MoveSpeed;

            else
            {
                if (MoveSpeed != 0)
                    isDamagePlayer = true;
            }

            if (player.Top < tinySkeleton.Top && tinySkeleton.Top > 20)
                tinySkeleton.Top -= MoveSpeed;

            if (player.Top > tinySkeleton.Top && tinySkeleton.Top + tinySkeleton.Height < 230)
                tinySkeleton.Top += MoveSpeed;
        }

        public bool isDeath()
        {
            return Health <= 0 ? true : false;
        }

        public bool IsDamagePlayer
        {
            set { isDamagePlayer = value; }
            get { return isDamagePlayer; }
        }


        public void Damaged (int damageValue)
        {
            Health -= damageValue;
            tinySkeleton.Image = Properties.Resources.SkeletonSwordDamaged;

            if (isSmall)
            {
                ChangeImageBackToNormal();
            }
            isDamageAnimationWorking = true;

            if (Health <= 0)
            {
                Health = 0;
                LevelManager.ReduceSmallSkeletonNum();

                tinySkeleton.Image = Properties.Resources.explosion;
                tinySkeleton.BringToFront();
                // form.Controls.Remove(tinySkeleton);

                AnimateExplosionTimer.Start();
            }
        }

        public void SelfDestroy ()
        {
            ChangeStateTimer.Stop();
            ChangeStateTimer.Dispose();
            ChangeStateTimer = null;

            AnimateExplosionTimer.Stop();
            AnimateExplosionTimer.Dispose();
            AnimateExplosionTimer = null;

            tinySkeleton.Dispose();
            tinySkeleton = null;
        }

        public void tm_AnimateExplosion(object sender, EventArgs e)
        {
            SelfDestroy();
        }


        private void tm_ChangeStateTick(object sender, EventArgs e)
        {
            if (isDamageAnimationWorking)
            {
                damageAnimateCount++;

                if (damageAnimateCount == 1)
                {
                    isDamageAnimationWorking = false;
                    damageAnimateCount = 0;
                }
            }

            /* Idle */
            if (stateCount == 1)
            {
                if(!isDamageAnimationWorking)
                {
                    tinySkeleton.Image = Properties.Resources.skeletonSwordStill;

                    if (isSmall)
                    {
                        ChangeImageBackToNormal();
                    }
                }
                
                MoveSpeed = 0;
                stateCount = 0;
            }

            /* Move or Attack */
            else
            {
                ranNum = rnd.Next(0, 2);

                if(ranNum == 1)
                {
                    if (!isDamageAnimationWorking)
                    {
                        tinySkeleton.Image = Properties.Resources.SkeletonSwordAttack;
                        tinySkeleton.Height = tinySkeleton.Height + 60;
                        tinySkeleton.Width = tinySkeleton.Width + 60;
                        tinySkeleton.Left -= 30;
                        tinySkeleton.Top -= 40;
                        isSmall = true;
                    }
                   
                }
                else
                {
                    if (!isDamageAnimationWorking)
                        tinySkeleton.Image = Properties.Resources.skeletonSwordMove;

                    SetDefaultMoveSpeed();
                }
                

                stateCount = 1;
            }
        }

        private void ChangeImageBackToNormal()
        {
            tinySkeleton.Height = tinySkeleton.Height - 60;
            tinySkeleton.Width = tinySkeleton.Width - 60;
            tinySkeleton.Left += 30;
            tinySkeleton.Top += 40;
            isSmall = false;
        }
    }
}
