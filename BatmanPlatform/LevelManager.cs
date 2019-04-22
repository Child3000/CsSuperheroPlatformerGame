using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BatmanPlatform
{
    class LevelManager
    {
        private static int level;

        private static int smallSkeletonNum;

        private static int defaultSkeletonNum;

        private static int skeletonHealth;

        private static int skeletonSpeed;

        private static bool isLoaded = false;


        public static int Level
        {
            set
            {
                if(value >= 1 && value <= 3)
                    level = value;
            }
            get { return level; }
        }

        public static int SkeletonHealth
        {
            get { return skeletonHealth; }
        }

        public static int SkeletonSpeed
        {
            get { return skeletonSpeed; }
        }

        public static bool IsLoaded
        {
            set { isLoaded = value; }
            get { return isLoaded; }
        }

        public static int GetSmallSkeletonNum()
        {
            return smallSkeletonNum;
        }

        public static int GetDefaultSkeletonNum()
        {
            return defaultSkeletonNum;
        }

        public static void ReduceSmallSkeletonNum()
        {
            smallSkeletonNum--;

            if(smallSkeletonNum <= 0)
            {
                level++;

                if (level == 7)
                    level = 1;
                SetLevelProperties();
            }
        }

        public static void InitializeLevel( PictureBox player )
        {
            Level = 1;
        }

        public static void SetCurrentLevel ( int value )
        {
            level = value;
        }

        // public : Provide more control and flexible to the programmer.
        //          to decide when to load the scene even though level is decided.
        public static void SetLevelProperties()
        {
            switch(level)
            {
                case 1:
                    SetFirstLevelProperties();
                    isLoaded = true;
                    break;
                case 2:
                    SetSecondLevelProperties();
                    isLoaded = true;
                    break;
                case 3:
                    SetThridLevelProperties();
                    isLoaded = true;
                    break;
                case 4:
                    SetForthLevelProperties();
                    isLoaded = true;
                    break;

                case 5:
                    SetFifthLevelProperties();
                    isLoaded = true;
                    break;

                case 6:
                    SetSixthLevelProperties();
                    isLoaded = true;
                    break;

                case 7:
                    SetSeventhLevelProperties();
                    isLoaded = true;
                    break;
            }
        }

        public static void SetFirstLevelProperties()
        {
            smallSkeletonNum = 1;
            defaultSkeletonNum = smallSkeletonNum;
            skeletonHealth = 10;
            skeletonSpeed = 1;
        }

        private static void SetSecondLevelProperties()
        {
            smallSkeletonNum = 3;
            defaultSkeletonNum = smallSkeletonNum;
            skeletonHealth = 30;
            skeletonSpeed = 1;
        }

        private static void SetThridLevelProperties()
        {
            smallSkeletonNum = 3;
            defaultSkeletonNum = smallSkeletonNum;
            skeletonHealth = 80;
            skeletonSpeed = 1;
        }

        private static void SetForthLevelProperties()
        {
            smallSkeletonNum = 2;
            defaultSkeletonNum = smallSkeletonNum;
            skeletonHealth = 100;
            skeletonSpeed = 2;
        }

        private static void SetFifthLevelProperties()
        {
            smallSkeletonNum = 1;
            defaultSkeletonNum = smallSkeletonNum;
            skeletonHealth = 300;
            skeletonSpeed = 2;
        }

        private static void SetSixthLevelProperties()
        {
            smallSkeletonNum = 5;
            defaultSkeletonNum = smallSkeletonNum;
            skeletonHealth = 300;
            skeletonSpeed = 2;
        }

        private static void SetSeventhLevelProperties()
        {
            smallSkeletonNum = 3;
            defaultSkeletonNum = smallSkeletonNum;
            skeletonHealth = 1000;
            skeletonSpeed = 2;
        }
    }
    
}
