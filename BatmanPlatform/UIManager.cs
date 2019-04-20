using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BatmanPlatform
{
    class UIManager
    {
        public static Bitmap HeroHealthImage;
        public static Bitmap[] AvailableHealthImage = new Bitmap[5];

        public static int Score { get; set; }
        public static bool gameOver { get; set; }


        public static void InitializeSetting(ref Label scoreLabel)
        {
            Score = 0;
            scoreLabel.Text = "Score: " + Score;
            gameOver = false;

            AvailableHealthImage[0] = Properties.Resources.blackHeart;
            AvailableHealthImage[1] = Properties.Resources.redHeart;
            AvailableHealthImage[2] = Properties.Resources.evilHeart;
            AvailableHealthImage[3] = Properties.Resources.diamondHeart;
            AvailableHealthImage[4] = Properties.Resources.sexyHeart;
        }

        public static void UpdateScore (ref Label scoreLabel, int value)
        {
            Score += value;
            scoreLabel.Text = "Score: " + Score;
        }
    }
}
