using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatmanPlatform
{
    class UIManager
    {
        public static int Score { get; set; }
        public static int Health { get; set; }


        public static void InitializeSetting(ref Label scoreLabel)
        {
            Score = 0;
            scoreLabel.Text = "Score: " + Score;
        }

        public static void UpdateScore (ref Label scoreLabel, int value)
        {
            Score += value;
            scoreLabel.Text = "Score: " + Score;
        }
    }
}
