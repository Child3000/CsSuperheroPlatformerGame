using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BatmanPlatform
{
    class Laser
    {
        PictureBox laserBlast = new PictureBox();
        Timer LaserTick = new Timer();

        int laserSpeed = (int)CharacterProperties.WeaponSpeed;

        public Laser(PictureBox player, Form form)
        {
            InitializeLaserProperties(player, form);

            LaserTick.Interval = 20;
            LaserTick.Tick += new EventHandler(tm_LaserTick);
            LaserTick.Start();
        }

        private void InitializeLaserProperties( PictureBox player , Form form)
        {
            laserBlast.Image = CharacterProperties.SpecialAbilityImage;
            laserBlast.BackColor = Color.Transparent;
            laserBlast.SizeMode = PictureBoxSizeMode.StretchImage;
            laserBlast.Size = new Size(80, 50);
            laserBlast.Tag = "Laser";

            laserBlast.Left = player.Left + player.Width / 2;
            laserBlast.Top  = player.Top + player.Height / 2;

            form.Controls.Add(laserBlast);
            laserBlast.BringToFront();

        }

        private void tm_LaserTick(object sender, EventArgs e)
        {
            laserBlast.Left += laserSpeed;

            if (laserBlast.Location.X > 1050)
            {
                LaserTick.Stop();
                SelfDestroy();
            }
        }

        private void SelfDestroy()
        {
            LaserTick.Dispose();
            LaserTick = null;

            laserBlast.Dispose();
            laserBlast = null;
        }

    }
}
