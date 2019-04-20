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
    Supergirl
}

public enum Weapon
{
    Unknown,
    FlyingBat,          // Batman
    HighSpeedLaser,     // Superman
    BeamLaser,          // Supergirl
    Dash                // Catwoman
}


namespace BatmanPlatform
{
    // This class is responsible to provide all properties of a hero / heroine
    class CharacterProperties
    {
        private static int health;

        private static int gravity;

        private static bool isGrounded;

        private static bool alreadyIsGrounded;

        private static HeroType type;

        private static Weapon weapon;

        private static Bitmap[] heroImage = new Bitmap[2];

        public static void InitializePropertiesValue()
        {
            health = 0;
            gravity = 0;
            isGrounded = false;
            alreadyIsGrounded = true;

            type = HeroType.Unknown;
            weapon = Weapon.Unknown;
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
    }
}
