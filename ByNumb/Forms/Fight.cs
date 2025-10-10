using ByNumb.Entities;
using ByNumb.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            playerNameLabel.Text = player.getName();
            enemyNameLabel.Text = enemy.getName();

            playerHealthPoinntsProgressBar.Maximum = player.getMaxHealthPoints();
            playerManaProgressBar.Maximum = player.getMaxMana();
            enemyHealthPoinntsProgressBar.Maximum = enemy.getMaxHealthPoints();

            playerHealthPoinntsProgressBar.Value = player.getHealthPoints();
            playerManaProgressBar.Value = player.getMana();
            enemyHealthPoinntsProgressBar.Value = enemy.getHealthPoints();

            playerHealthPointsLabel.Text = $"{player.getHealthPoints()}/{player.getMaxHealthPoints()}";
            playerManaLabel.Text = $"{player.getMana()}/{player.getMaxMana()}";
            enemyHealthPointsLabel.Text = $"{enemy.getHealthPoints()}/{enemy.getMaxHealthPoints()}";
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            playerHealthPoinntsProgressBar.Value = Math.Max(0, player.getHealthPoints());
            playerManaProgressBar.Value = Math.Max(0, player.getMana());
            enemyHealthPoinntsProgressBar.Value = Math.Max(0, enemy.getHealthPoints());

            playerHealthPointsLabel.Text = somethingFromSomething(player.getHealthPoints(), player.getMaxHealthPoints());
            playerManaLabel.Text = somethingFromSomething(player.getMana(), player.getMaxMana());
            enemyHealthPointsLabel.Text = somethingFromSomething(enemy.getHealthPoints(), enemy.getMaxHealthPoints());


            if (player.getHealthPoints() <= 0)
            {
                timer.Stop();
                MessageBox.Show("You fell right on the battlefield, weakling. You're slowly dying!");
                mainScreen.WhenLose();
                mainScreen.Show();
                this.Close();
            }
            else if (enemy.getHealthPoints() <= 0)
            {
                timer.Stop();
                MessageBox.Show("You brought this bastard to his knees, congratulation!");
                player.setGold(player.getGold() + enemy.getGoldReward());
                player.GainExperience(enemy.getExperienceReward());
                mainScreen.WhenWin();
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
                    enemy.GainDamage(player.CommonAttack());
                    player.GainDamage(enemy.getAttack());
                    break;

                case Keys.R:
                    enemy.GainDamage(player.StrongAttack());
                    player.GainDamage(enemy.getAttack());
                    break;

                case Keys.Space:
                    player.GainDamage(enemy.getAttack() / 2);
                    break;

                case Keys.Q:
                    player.Heal();
                    player.GainDamage(enemy.getAttack());
                    break;
            }
        }

        private string somethingFromSomething(int value, int maxValue)
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

        
    }
}
