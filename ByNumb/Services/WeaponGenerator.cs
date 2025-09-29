using ByNumb.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByNumb.Services
{
    public class WeaponGenerator
    {
        // Fields
        string[] weaponNames = { "Nightfall", "Stormbringer", "Aetherion", "Voidcleaver", "Dawnreaver", "Frostbrand",
            "Bloodthorn", "Shadowrend", "Sunhammer", "Starforge", "Grimfang", "Lifebinder", "Emberfall", "Mistweaver", "Ironwrath",
            "Moonshard", "Thundermaul", "Riftblade", "Soulcage", "Blackspire", "Dig-Dagger", "excalibur", };

        // Init
        public WeaponGenerator()
        {

        }

        // Methods
        public Weapon GenerateWeapon()
        {
            Random random = new Random();
            Weapon weapon = new Weapon(weaponNames[random.Next(0, weaponNames.Length)], 0, 0);
            return weapon;
        }

        public Weapon[] GenerateWeaponArray(byte arrayLength)
        {
            Random random = new Random();
            Weapon[] weaponArray = new Weapon[arrayLength];
            for (int i = 0; i < weaponArray.Length; i++)
            {
                weaponArray[i] = new Weapon(weaponNames[random.Next(0, weaponNames.Length)], 0, 0);
            }
            return weaponArray;
        }
    }
}
