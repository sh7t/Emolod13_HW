using ByNumb.Items;
using System;
using System.Security.Cryptography;

namespace ByNumb.Services
{
    public class WeaponGenerator
    {
        // Fields
        string[] weaponNames = { "Nightfall", "Stormbringer", "Aetherion", "Voidcleaver", "Dawnreaver", "Frostbrand",
            "Bloodthorn", "Shadowrend", "Sunhammer", "Starforge", "Grimfang", "Lifebinder", "Emberfall", "Mistweaver", "Ironwrath",
            "Moonshard", "Thundermaul", "Riftblade", "Soulcage", "Blackspire", "Dig-Dagger", "Excalibur", };

        // Init
        public WeaponGenerator()
        {
            
        }

        // Methods
        public Weapon GenerateWeapon(int playerLevel)
        {
            Random random = new Random();

            int minDmg = 5 + (playerLevel - 1) * 2;
            int maxDmg = 15 + (playerLevel - 1) * 3;
            int dmg = random.Next(minDmg, maxDmg+1);

            Weapon weapon = new Weapon(
                 weaponNames[random.Next(0, weaponNames.Length)],
                 dmg * (40 + random.Next(1, 11)),
                 dmg
                 );
            return weapon;
        }

        public Weapon[] GenerateWeaponArray(byte arrayLength, int playerLevel)
        {
            Weapon[] weaponArray = new Weapon[arrayLength];
            for (int i = 0; i < weaponArray.Length; i++)
            {
                weaponArray[i] = GenerateWeapon(playerLevel);
            }
            return weaponArray;
        }
        
    }
}
