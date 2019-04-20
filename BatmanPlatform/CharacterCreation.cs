using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace BatmanPlatform
{

    class CharacterCreation
    {
        public static Hero CreateCustomCharacter(HeroType heroType)
        {
            CharacterProperties.InitializePropertiesValue();
            CharacterProperties.heroType = heroType;

            return Hero.BuildHeroProperties();
        }
    }
}
