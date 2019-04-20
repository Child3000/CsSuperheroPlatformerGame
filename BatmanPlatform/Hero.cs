using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BatmanPlatform
{
    // 'sealed' means the class cannot be inherited //
    sealed class Hero
    {
        public Hero()
        {

        }


        public static Hero BuildHeroProperties()
        {

            switch(CharacterProperties.heroType)
            {
                case HeroType.Batman:

                    CharacterProperties.Health = 5;
                    CharacterProperties.Gravity = 5;
                    CharacterProperties.heroWeapon = Weapon.FlyingBat;
                    CharacterProperties.HeroImage[0] = Properties.Resources.batman_1;
                    CharacterProperties.HeroImage[1] = Properties.Resources.batman_2;
                    break;

                case HeroType.Superman:
                    CharacterProperties.Health = 5;
                    CharacterProperties.Gravity = 3;
                    CharacterProperties.heroWeapon = Weapon.HighSpeedLaser;
                    CharacterProperties.HeroImage[0] = Properties.Resources.superman_1;
                    CharacterProperties.HeroImage[1] = Properties.Resources.superman_2;
                    break;

                case HeroType.Supergirl:
                    CharacterProperties.Health = 3;
                    CharacterProperties.Gravity = 3;
                    CharacterProperties.heroWeapon = Weapon.BeamLaser;
                    break;

                case HeroType.Catwoman:
                    CharacterProperties.Health = 3;
                    CharacterProperties.Gravity = 5;
                    CharacterProperties.heroWeapon = Weapon.Dash;
                    break;
            }

            return new Hero();
        }
    }
}
