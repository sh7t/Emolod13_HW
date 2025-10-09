using ByNumb.Items;

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
            int minDef = 5 + (playerLevel - 1) * 2;
            int maxDef = 15 + (playerLevel - 1) * 3;
            int def = CustomRandom.Next(minDef, maxDef+1);

            Armor armor = new Armor(
                armorNames[CustomRandom.Next(0, armorNames.Length)],
                def * (40 + CustomRandom.Next(1, 11)),
                def
                );
            return armor;
        }

        public Armor[] GenerateArmorArray(byte arrayLength, int playerLevel)
        {
            Armor[] armorArray = new Armor[arrayLength];
            for (int i = 0; i < armorArray.Length; i++)
            {
                armorArray[i] = GenerateArmor(playerLevel);
            }
            return armorArray;
        }
    }
}
