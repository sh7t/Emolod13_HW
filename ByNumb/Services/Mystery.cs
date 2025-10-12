using ByNumb.Entities;
using ByNumb.Forms;
using System;
using System.Windows.Forms;

namespace ByNumb.Services
{
    public class Mystery
    {
        enum MysteryBuff
        {
            Prank = 0,
            StolenExperience = 3, // -exp
            Hit = 8, // -hp
            StolenGold = 9, // -gold
            ExperienceBook = 10, // +ex
            MaxHP = 18, // +maxhp
            MaxMana = 19, // +maxmana
            ExperienceGranite = 20, // +exp
            GoldSac = 25, // +gold
            GoldChest = 50 // +gold
        }
        // Fields
        private string mysteryName = "";
        private string mysteryDescription = "";
        private MysteryBuff mysteryValue;

        // Init
        private Mystery(string mysteryName, string mysteryDescription, MysteryBuff mysteryValue)
        {
            this.mysteryName = mysteryName;
            this.mysteryDescription = mysteryDescription;
            this.mysteryValue = mysteryValue;
        }
        // Get-set'ters
        public string getMysteryName() { return mysteryName; }
        public void setMysteryName(string mysteryName) { this.mysteryName = mysteryName; }

        public string getMysteryDescription() { return mysteryDescription; }
        public void setMysteryDescription(string mysteryDescription) { this.mysteryDescription = mysteryDescription; }

        // Methods
        private static Mystery[] CallMysteryArray(int playerLevel)
        {
            Mystery[] mysteries = new Mystery[10];
            // 6 positive mysteries
            mysteries[0] = new Mystery("Suspicious Book", $"You've found Suspicious Book, but you read it anyways.\nYou got +{10 * playerLevel} Experience!", MysteryBuff.ExperienceBook);
            mysteries[1] = new Mystery("Granite Of Science", $"You've found Granite Of Science, and you gnaw it.\nYou got +{20 * playerLevel} Experience!", MysteryBuff.ExperienceGranite);
            mysteries[2] = new Mystery("Enchanted Mango", $"You've found Enchanted Mango, you ate it and it was tasty.\nYou got +{19 * playerLevel} Mana to mana pool", MysteryBuff.MaxMana);
            mysteries[3] = new Mystery("Faerie Fire", $"You've found Faerie Fire, you ate it and it was tasty.\nYou got +{18 * playerLevel} HP to health pool", MysteryBuff.MaxHP);
            mysteries[4] = new Mystery("Sac Of Gold", $"You've found Sac Of Gold, you opened it and were surprised.\nYou got +{25 * playerLevel} Gold to your pocket", MysteryBuff.GoldSac);
            mysteries[5] = new Mystery("Chest Of Gold", $"You've found Chest Of Gold, you opened it and were shocked.\nYou got +{50 * playerLevel} Gold to your pocket", MysteryBuff.GoldChest);
            // // 1 neutral mystery                               
            mysteries[6] = new Mystery("Gibus", "You've found a Gibus - a man, who loves joking. He pranked you and nothing really happened...", MysteryBuff.Prank);
            // // 3 negative mysteries
            mysteries[7] = new Mystery("The Knowledge Thief", $"You've found a The Knowledge Thief, or he found you. He stole your experience.\nYou got -{3 * playerLevel} Experience", MysteryBuff.StolenExperience);
            mysteries[8] = new Mystery("Robin Hood", $"You've been found by Robin Hood and he stole your gold.\nYou got -{9 * playerLevel} Gold from your pocket.", MysteryBuff.StolenGold);
            mysteries[9] = new Mystery("Aggresor", $"You've been found by Aggresor and you felt bad because of him.\nYou got -{8 * playerLevel} HP.", MysteryBuff.Hit);

            return mysteries;
        }
        public static Player MysteryRandom(Player player, MainScreen mainScreen)
        {
            Mystery mystery = CallMysteryArray(player.getLevel())[CustomRandom.Next(0, 10)];
            MessageBox.Show($"{mystery.mysteryDescription}", $"{mystery.mysteryName}", MessageBoxButtons.OK, MessageBoxIcon.Information);
            switch (mystery.mysteryValue)
            {
                case MysteryBuff.ExperienceBook:
                    player.GainExperience(((int)MysteryBuff.ExperienceBook) * player.getLevel());
                    break;

                case MysteryBuff.ExperienceGranite:
                    player.GainExperience(((int)MysteryBuff.ExperienceGranite) * player.getLevel());
                    break;

                case MysteryBuff.MaxMana:
                    player.setMaxMana(player.getMaxMana() + (((int)MysteryBuff.MaxMana) * player.getLevel()));
                    break;

                case MysteryBuff.MaxHP:
                    player.setMaxHealthPoints(player.getMaxHealthPoints() + (((int)MysteryBuff.MaxHP) * player.getLevel()));
                    break;

                case MysteryBuff.GoldSac:
                    player.GainGold(((int)MysteryBuff.GoldSac) * player.getLevel());
                    break;

                case MysteryBuff.GoldChest:
                    player.GainGold(((int)MysteryBuff.GoldChest) * player.getLevel());
                    break;

                case MysteryBuff.Prank:
                    break;

                case MysteryBuff.StolenExperience:
                    player.LoseExperience(((int)MysteryBuff.StolenExperience) * player.getLevel());
                    break;

                case MysteryBuff.StolenGold:
                    player.LoseGold(((int)MysteryBuff.StolenGold) * player.getLevel());
                    break;

                case MysteryBuff.Hit:
                    player.GainDamage((((int)MysteryBuff.Hit) * player.getLevel()) + player.CalculateDefensePotential(), mainScreen);
                    break;

                default:
                    throw new Exception("An unexpected error occured while picking mystery!");
            }
            return player;
        }
    }
}
