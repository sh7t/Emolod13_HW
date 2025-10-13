using ByNumb.Entities;
using ByNumb.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByNumb.Forms
{
    public partial class Fight : Form
    {
        private Player player;
        private Enemy enemy;
        private MainScreen mainScreen;
        public Fight(Player player, MainScreen mainScreen)
        {
            InitializeComponent();
            enemy = new EnemyGenerator().GenerateEnemy(player.getLevel());

            this.player = player;
            this.mainScreen =  mainScreen;
        }

        private void Fight_Load(object sender, EventArgs e)
        {
            player.setHealthPoints(player.getMaxHealthPoints());
            player.setMana(player.getMaxMana());

            playerNameLabel.Text = player.getName();
            enemyNameLabel.Text = enemy.getName();

            playerHealthPoinntsProgressBar.Maximum = player.getMaxHealthPoints();
            playerManaProgressBar.Maximum = player.getMaxMana();
            enemyHealthPoinntsProgressBar.Maximum = enemy.getMaxHealthPoints();

            playerHealthPoinntsProgressBar.Value = player.getHealthPoints();
            playerManaProgressBar.Value = player.getMana();
            enemyHealthPoinntsProgressBar.Value = enemy.getHealthPoints();

            playerHealthPointsLabel.Text = GameEngine.somethingFromSomething(player.getHealthPoints(), player.getMaxHealthPoints());
            playerManaLabel.Text = GameEngine.somethingFromSomething(player.getMana(), player.getMaxMana());
            enemyHealthPointsLabel.Text = GameEngine.somethingFromSomething(enemy.getHealthPoints(), enemy.getMaxHealthPoints());
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            playerHealthPoinntsProgressBar.Value = Math.Max(0, player.getHealthPoints());
            playerManaProgressBar.Value = Math.Max(0, player.getMana());
            enemyHealthPoinntsProgressBar.Value = Math.Max(0, enemy.getHealthPoints());

            playerHealthPointsLabel.Text = GameEngine.somethingFromSomething(player.getHealthPoints(), player.getMaxHealthPoints());
            playerManaLabel.Text = GameEngine.somethingFromSomething(player.getMana(), player.getMaxMana());
            enemyHealthPointsLabel.Text = GameEngine.somethingFromSomething(enemy.getHealthPoints(), enemy.getMaxHealthPoints());


            if (player.getHealthPoints() <= 0)
            {
                timer.Stop();
                MessageBox.Show("You fell right on the battlefield, weakling. You're slowly dying!", "You're paltry, pal!", MessageBoxButtons.OK, MessageBoxIcon.Hand);
                mainScreen.WhenLose();
                mainScreen.Show();
                this.Close();
            }
            else if (enemy.getHealthPoints() <= 0)
            {
                timer.Stop();
                MessageBox.Show("You brought this bastard to his knees, congratulation!", $"Great job, {player.getName()}.");
                player.setGold(player.getGold() + enemy.getGoldReward());
                player.GainExperience(enemy.getExperienceReward());
                GameEngine.WhenWin(player);
                mainScreen.Show();
                Close();
            }
            
        }

        private void Fight_KeyDown(object sender, KeyEventArgs e)
        {
            enemy.setDefense(0);
            switch(e.KeyCode)
            {
                case Keys.E:
                    if (player.getMana() >= player.getIntelligence() * 5) { Logger.AddLog($"{player.getName()} attacked {enemy.getName()} with a common attack!", Color.MediumSeaGreen, logBox); }
                    else { Logger.AddLog($"{player.getName()} can't do common attack because of mana, meditate!", Color.MediumVioletRed, logBox); }
                    enemy.GainDamage(player.CommonAttack());
                    player.GainDamage(enemy.getAttack(), mainScreen);
                    Logger.AddLog($"{enemy.getName()} attacked {player.getName()}!", Color.Red, logBox);
                    break;

                case Keys.R:
                    if (player.getMana() >= player.getIntelligence() * 15) { Logger.AddLog($"{player.getName()} attacked {enemy.getName()} with a strong attack!", Color.DarkGreen, logBox); }
                    else { Logger.AddLog($"{player.getName()} can't do strong attack because of mana, meditate!", Color.MediumVioletRed, logBox); }
                    enemy.GainDamage(player.StrongAttack());
                    player.GainDamage(enemy.getAttack(), mainScreen);
                    Logger.AddLog($"{enemy.getName()} attacked {player.getName()}!", Color.Red, logBox);
                    break;

                case Keys.Space:
                    player.GainDamage(enemy.getAttack() / 2, mainScreen);
                    Logger.AddLog($"{player.getName()} set up a tight defense with his arms!", Color.DimGray, logBox);
                    Logger.AddLog($"{enemy.getName()} attacked {player.getName()}!", Color.Red, logBox);
                    Logger.AddLog($"Anyways, {enemy.getName()}'s attack blocked by {player.getName()}!", Color.DimGray, logBox);
                    break;

                case Keys.Q:
                    player.Heal();
                    Logger.AddLog($"{player.getName()} meditated for a while...", Color.MediumSeaGreen, logBox);
                    player.GainDamage(enemy.getAttack(), mainScreen);
                    Logger.AddLog($"{enemy.getName()} attacked {player.getName()}!", Color.Red, logBox);
                    break;
            }
            e.SuppressKeyPress = true;
        }
    }
}
