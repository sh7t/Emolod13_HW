using ByNumb.Entities;
using ByNumb.Forms;
using System;
using System.Media;
using System.Numerics;
using System.Windows.Forms;

namespace ByNumb.Services
{
    public class GameEngine
    {
        enum EventType
        {
            Idle = 1,
            Fight,
            Shopping,
            Mystery
        }

        // Fields
        private static SoundPlayer soundPlayer = new SoundPlayer(Properties.Resources.MainTheme);
        // Init

        // Get-set'ters
        public SoundPlayer getSoundPlayer() { return soundPlayer; }

        // Methods
        public static void ChooseEventType(MainScreen mainScreen, Player player)
        {
            EventType eventType = (EventType)CustomRandom.Next(1, 5);

            switch (eventType)
            {
                case EventType.Idle:
                    MessageBox.Show("Nothing happened... Probably.", "Moving result", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    player.GainExperience(1 * player.getLevel());
                    mainScreen.UpdateCharacteristics(player);
                    break;

                case EventType.Fight:
                    MessageBox.Show("You went looking for trouble... and found it.\nEnemy on Your way!", $"{player.getName()}, we have problems!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    MessageBox.Show("Controls:\nCommon Attack: E\nStrong Attack: R\nBlock: Space\nMeditation: Q", "I'm gonna die or what?!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    mainScreen.Hide();
                    new Fight(player, mainScreen).ShowDialog();
                    mainScreen.UpdateCharacteristics(player);
                    break;

                case EventType.Shopping:
                    MessageBox.Show("You've found a mysterious shop!\nHope you'll find some things for yourself.", "Shopping coming", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    mainScreen.Hide();
                    new Shop(player, mainScreen).ShowDialog();
                    mainScreen.UpdateCharacteristics(player);
                    break;

                case EventType.Mystery:
                    player = Mystery.MysteryRandom(player, mainScreen);
                    mainScreen.UpdateCharacteristics(player);
                    break;

                default:
                    throw new Exception("Critical error. EventGeneration proccess didn't succeed.");
            }

        }
        public static string somethingFromSomething(int value, int maxValue)
        {
            if (value >= 0)
            {
                return $"{value}/{maxValue}";
            }
            else
            {
                return $"{0}/{maxValue}";
            }
        }
        public static void PlayMainTheme()
        {
            soundPlayer.PlayLooping();
        }
        public static void MuteMainTheme()
        {
            soundPlayer.Stop();
        }
        public static void WhenWin(Player player)
        {
            player.setStrength(player.getLevel());
            player.setAgility(player.getLevel());
            player.setEndurance(player.getLevel());
            player.setIntelligence(player.getLevel());
            player.setMaxHealthPoints(player.getEndurance() * 50);
            player.setMaxMana(player.getIntelligence() * 50);
            player.setCriticalChance(player.getAgility() * 0.5);
        }
        public static void WhenLose(Player player)
        {
            player.setHealthPoints(0);
            player.setMana(0);
            player.setExperience(0);
            player.setExperienceForLevelUp(0);
            if (!player.getName().StartsWith("Dead")) { player.setName($"Dead {player.getName()}"); }
            player.setCriticalChance(0);
        }
    }
}
