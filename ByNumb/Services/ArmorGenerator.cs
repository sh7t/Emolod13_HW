using ByNumb.Items;
using System;

namespace ByNumb.Services
{
    public class ArmorGenerator
    {
        // Fields
        string[] armorNames = { "Stoneguard", "Shadowplate", "Dawnshield", "Frostmail", "Ironveil", "Emberplate",
            "Voidcarapace", "Moonward", "Sunforged Aegis", "Starplate", "Bloodward", "Stormcarapace", "Nightguard", "Boneplate", "Shiva's Guard",
            "Thornmail", "Blackened Bulwark", "Blademail" };

        // Init
        public ArmorGenerator()
        {

        }

        // Methods
        public Armor GenerateArmor(int playerLevel)
        {
            Random random = new Random();

            int minDef = 5 + (playerLevel - 1) * 2;
            int maxDef = 15 + (playerLevel - 1) * 3;
            int def = random.Next(minDef, maxDef+1);

            Armor armor = new Armor(
                armorNames[random.Next(0, armorNames.Length)],
                def * (40 + random.Next(1, 11)),
                def
                );
            return armor;
        }

        public Armor[] GenerateArmorArray(byte arrayLength, int playerLevel)
        {
            Random random = new Random();
            Armor[] armorArray = new Armor[arrayLength];
            for (int i = 0; i < armorArray.Length; i++)
            {
                armorArray[i] = GenerateArmor(playerLevel);
            }
            return armorArray;
        }
    }
}
