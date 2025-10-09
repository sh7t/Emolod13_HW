using ByNumb.Entities;
using ByNumb.Forms;
using System;
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

        // Init

        // Get-set'ters

        // Methods
        public static void ChooseEventType(MainScreen mainScreen, Player player)
        {
            EventType eventType = (EventType)CustomRandom.Next(1, 5);

            switch (eventType)
            {
                case EventType.Idle:
                    MessageBox.Show("Nothing happened... Probably.", "Moving result", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;

                case EventType.Fight:
                    MessageBox.Show("You went looking for trouble... and found it.\nEnemy on Your way!", "Houston, we have a problem!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    mainScreen.Hide();
                    new Fight(player, mainScreen).ShowDialog();
                    break;

                case EventType.Shopping:
                    MessageBox.Show("You've found a mysterious shop!\nHope You'll find some things for Yourself.", "Shopping coming", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    mainScreen.Hide();
                    new Shop(player).ShowDialog();
                    break;

                case EventType.Mystery:
                    MessageBox.Show("You've found a mystery!", "Moving result", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                    break;

                default:
                    throw new Exception("Critical error. EventGeneration proccess didn't succeed.");
            }
        }
    }
}
