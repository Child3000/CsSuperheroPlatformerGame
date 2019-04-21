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
                    CharacterProperties.SetDefaultGravityValue(5);
                    CharacterProperties.heroWeapon = Weapon.FlyingBat;
                    CharacterProperties.HeroImage[0] = Properties.Resources.batman_1;
                    CharacterProperties.HeroImage[1] = Properties.Resources.batman_2;

                    UIManager.HeroHealthImage = UIManager.AvailableHealthImage[0];

                    Dash.SetDashPeriod(400);
                    Dash.SetDashSpeed(15);
                    break;

                case HeroType.Superman:
                    CharacterProperties.Health = 3;
                    CharacterProperties.SetDefaultGravityValue(3);
                    CharacterProperties.heroWeapon = Weapon.HighSpeedLaser;
                    CharacterProperties.HeroImage[0] = Properties.Resources.superman_1;
                    CharacterProperties.HeroImage[1] = Properties.Resources.superman_2;

                    UIManager.HeroHealthImage = UIManager.AvailableHealthImage[1];

                    Dash.SetDashPeriod(400);
                    Dash.SetDashSpeed(17);
                    break;

                case HeroType.Speedy:
                    CharacterProperties.Health = 3;
                    CharacterProperties.SetDefaultGravityValue(5);
                    CharacterProperties.heroWeapon = Weapon.PurpleLaser;
                    CharacterProperties.HeroImage[0] = Properties.Resources.speedman_1;
                    CharacterProperties.HeroImage[1] = Properties.Resources.speedman_2;

                    UIManager.HeroHealthImage = UIManager.AvailableHealthImage[2];

                    Dash.SetDashPeriod(200);
                    Dash.SetDashSpeed(20);

                    break;

                case HeroType.WonderWoman:
                    CharacterProperties.Health = 3;
                    CharacterProperties.SetDefaultGravityValue(3);
                    CharacterProperties.heroWeapon = Weapon.BeamLaser;
                    CharacterProperties.HeroImage[0] = Properties.Resources.wonderwoman_1;
                    CharacterProperties.HeroImage[1] = Properties.Resources.wonderwoman_2;

                    UIManager.HeroHealthImage = UIManager.AvailableHealthImage[3];

                    Dash.SetDashPeriod(300);
                    Dash.SetDashSpeed(20);

                    break;

                case HeroType.Catwoman:
                    CharacterProperties.Health = 4;
                    CharacterProperties.SetDefaultGravityValue(3);
                    CharacterProperties.heroWeapon = Weapon.PurpleLaser;

                    CharacterProperties.HeroImage[0] = Properties.Resources.catwoman_1;
                    CharacterProperties.HeroImage[1] = Properties.Resources.catwoman_2;

                    UIManager.HeroHealthImage = UIManager.AvailableHealthImage[4];

                    Dash.SetDashPeriod(300);
                    Dash.SetDashSpeed(15);
                    break;
            }
            CharacterProperties.SettingSpecialAbility();
            return new Hero();
        }
    }
}
