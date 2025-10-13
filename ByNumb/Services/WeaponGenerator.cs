using ByNumb.Items;

namespace ByNumb.Services
{
    public class WeaponGenerator
    {
        // Fields
        private static string[] weaponNames = { "Nightfall", "Stormbringer", "Aetherion", "Voidcleaver", "Dawnreaver", "Frostbrand",
            "Bloodthorn", "Shadowrend", "Sunhammer", "Starforge", "Grimfang", "Lifebinder", "Emberfall", "Mistweaver", "Ironwrath",
            "Moonshard", "Thundermaul", "Riftblade", "Soulcage", "Blackspire", "Dig-Dagger", "Excalibur", };

        // Init
        public WeaponGenerator()
        {
            
        }

        // Methods
        private static Weapon GenerateWeapon(int playerLevel)
        {
            int minDmg = 5 + (playerLevel - 1) * 2;
            int maxDmg = 15 + (playerLevel - 1) * 3;
            int dmg = CustomRandom.Next(minDmg, maxDmg+1);

            Weapon weapon = new Weapon(
                 weaponNames[CustomRandom.Next(0, weaponNames.Length)],
                 dmg * CustomRandom.Next(1, 11),
                 dmg
                 );
            return weapon;
        }

        public static Weapon[] GenerateWeaponArray(byte arrayLength, int playerLevel)
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
