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
        public Armor GenerateArmor()
        {
            Random random = new Random();
            Armor armor = new Armor(armorNames[random.Next(0, armorNames.Length)], 0, 0); // unfinished
            return armor;
        }

        public Armor[] GenerateArmorArray(byte arrayLength)
        {
            Random random = new Random();
            Armor[] armorArray = new Armor[arrayLength];
            for (int i = 0; i < armorArray.Length; i++)
            {
                armorArray[i] = GenerateArmor();
            }
            return armorArray;
        }
    }
}
