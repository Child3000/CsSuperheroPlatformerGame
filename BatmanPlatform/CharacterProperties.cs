using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;


public enum HeroType
{
    Unknown,
    Batman,
    Catwoman,
    Superman,
    WonderWoman,
    Speedy
}

public enum Weapon
{
    Unknown,
    FlyingBat,          // Batman
    HighSpeedLaser,     // Superman
    BeamLaser,          // Supergirl
    PurpleLaser         // Catwoman
}

namespace BatmanPlatform
{
    // This class is responsible to provide all properties of a hero / heroine
    class CharacterProperties
    {
        private static readonly int CONST_MIN_HEALTH = 0;

        private static int health;

        private static int gravity;

        private static int defaultGravity;

        private static float weaponSpeed;

        private static bool isGrounded;

        private static bool alreadyIsGrounded;

        private static int weaponDamage;

        private static int shootRate;   // Counted in milliseconds

        private static HeroType type;

        private static Weapon weapon;

        private static Bitmap[] heroImage = new Bitmap[2];

        private static Bitmap specialAbilityImage;

        private static List<PictureBox> laserList = new List<PictureBox>();


        public static void InitializePropertiesValue()
        {
            health = 0;
            gravity = 0;
            defaultGravity = 0;
            weaponSpeed = 0.0f;
            weaponDamage = 0;
            shootRate = 1000;
            isGrounded = false;
            alreadyIsGrounded = true;

            type = HeroType.Unknown;
            weapon = Weapon.Unknown;

            Dash.DashImage[0] = Properties.Resources.smoke_1;
            Dash.DashImage[1] = Properties.Resources.smoke_2;
        }

        public static Bitmap[] HeroImage
        {
            set
            {
                heroImage = value;
            }
            get
            {
                return heroImage;
            }
        }

        public static Bitmap SpecialAbilityImage
        {
            get { return specialAbilityImage; }
        }

        public static List<PictureBox> LaserList
        {
            set { laserList = value; }

            get { return laserList; }
        }

        public static HeroType heroType
        {
            set { type = value; }
            get { return type; }
        }

        public static Weapon heroWeapon
        {
            set { weapon = value; }

            get { return weapon; }
        }

        public static int Health
        {
            set { health = value; }

            get
            {
                return health;
            }
        }

        public static int Gravity
        {
            set { gravity = value; }
            get
            {
                return gravity;
            }
        }

        public static float WeaponSpeed
        {
            get { return weaponSpeed; }
        }

        public static int WeaponDamage
        {
            get { return weaponDamage;
 }
        }

        public static int ShootRate
        {
            get { return shootRate; }
        }

        public static bool IsGrounded
        {
            set {; }
            get
            {
                return isGrounded;
            }
        }

        public static bool AlreadyIsGrounded
        {
            set {; }
            get { return alreadyIsGrounded; }
        }

        public static int MIN_HEALTH
        {
            get { return CONST_MIN_HEALTH; }
        }


        public static void ResetGravityToDefault()
        {
            gravity = defaultGravity;
        }

        public static void SetDefaultGravityValue( int value)
        {
            defaultGravity = value;
            gravity = value;
        }

        public static void ReverseGravity()
        {
            gravity = -gravity;
        }

        public static void ReachGround()
        {
            isGrounded = true;
        }

        public static void LeaveGround()
        {
            isGrounded = false;
        }

        public static void AllowImageConversion()
        {
            alreadyIsGrounded = true;
        }

        public static void RestrictImageOverlap()
        {
            alreadyIsGrounded = false;
        }

        public static void UpdateHealth(int value, ref List<PictureBox> healthVisibleList, ref List<PictureBox> healthInvisibleList)
        {
            health -= value;

            if (healthVisibleList.Count >= value)
            {
                for (int i = 0; i < value; i++)
                {
                    healthInvisibleList[healthVisibleList.Count - 1] = healthVisibleList[healthVisibleList.Count - 1];
                    healthInvisibleList[healthVisibleList.Count - 1].Visible = false;
                    healthVisibleList.RemoveAt(healthVisibleList.Count - 1);
                }
            }
            else
            {
                for (int i = 0; i < healthVisibleList.Count; i++)
                {
                    healthInvisibleList[healthVisibleList.Count - 1] = healthVisibleList[healthVisibleList.Count - 1];
                    healthInvisibleList[healthVisibleList.Count - 1].Visible = false;
                    healthVisibleList.RemoveAt(healthVisibleList.Count - 1);
                }
            }
        }

        public static bool isDeath()
        {
            if (Health < CharacterProperties.MIN_HEALTH)
            {
                UIManager.gameOver = true;
                return true;
            }
            return false;
        }

        public static void SettingSpecialAbility()
        {
            switch (heroWeapon)
            {
                case Weapon.FlyingBat:

                    specialAbilityImage = Properties.Resources.flyingBat;
                    weaponSpeed = 30.0f;
                    weaponDamage = 15;   // Lowest Damage
                    shootRate = 500;    // fast
                    break;

                case Weapon.HighSpeedLaser:

                    specialAbilityImage = Properties.Resources.highSpeedLaser;
                    weaponSpeed = 20.0f;
                    weaponDamage = 20;   // Normal Damage
                    shootRate = 400;    // fastest
                    break;

                case Weapon.BeamLaser:

                    specialAbilityImage = Properties.Resources.lightning;
                    weaponSpeed = 10.0f;
                    weaponDamage = 50;  // Highest Damage
                    shootRate = 1500;   // slowest
                    break;

                case Weapon.PurpleLaser:

                    specialAbilityImage = Properties.Resources.purpleBeam;
                    weaponSpeed = 25.0f;
                    weaponDamage = 30;   // High Damage
                    shootRate = 1000;   // normal
                    break;
            }
        }
    }
}
