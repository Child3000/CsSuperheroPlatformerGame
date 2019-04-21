using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace BatmanPlatform
{
    class Dash
    {
        private static int dashPeriod;

        private static int dashSpeed;

        private static int platformSpeed;

        private static int defaultPlaformSpeed;

        private static bool allowDash = true;

        private static Timer DashTick = new Timer();

        private static Bitmap[] dashImage = new Bitmap[2];



        public static int DashPeriod
        {

            get { return dashPeriod; }
        }

        public static int DashSpeed
        {
            get { return dashSpeed; }
        }

        public static int PlatformSpeed
        {
            get { return platformSpeed; }
        }

        public static Bitmap[] DashImage
        {
            set { dashImage = value; }

            get { return dashImage; }
        }


        public static bool AllowDash
        {
            get { return allowDash; }
        }

        public static void SetDashPeriod (int time)
        {
            dashPeriod = time;
        }

        public static void SetDashSpeed (int speed)
        {
            dashSpeed = speed;
        }

        public static void RestrictDashKey()
        {
            allowDash = false;
        }

        public static void InitializePlatformSpeed( int value)
        {
            platformSpeed = value;
            defaultPlaformSpeed = value;
        }

        public static void PerformDashAction()
        {
            platformSpeed = dashSpeed;
            DashTick.Interval = Dash.DashPeriod;
            DashTick.Tick += new EventHandler(tm_DashTick);
            DashTick.Start();
        }

        private static void tm_DashTick(object sender, EventArgs e)
        {
            allowDash = true;
            platformSpeed = 10;
            DashTick.Stop();
        }
    }
}
