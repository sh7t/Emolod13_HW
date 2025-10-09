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
        private bool playerTurn = false;
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

            playerProgressBar.Maximum = player.getMaxHealthPoints();
            enemyProgressBar.Maximum = enemy.getMaxHealthPoints();

            playerProgressBar.Value = player.getHealthPoints();
            enemyProgressBar.Value = enemy.getHealthPoints();
        }

        private void timer_Tick(object sender, EventArgs e)
        {
            playerProgressBar.Value = Math.Max(0, player.getHealthPoints());
            enemyProgressBar.Value = Math.Max(0, enemy.getHealthPoints());

            if (player.getHealthPoints() <= 0)
            {
                timer.Stop();
                MessageBox.Show("gg");
                mainScreen.Show();
                Close();
            }
            else if (enemy.getHealthPoints() <= 0)
            {
                timer.Stop();
                MessageBox.Show("good boy");
                mainScreen.Show();
                Close();
            }
            
        }

        private void Fight_KeyDown(object sender, KeyEventArgs e)
        {
            switch(e.KeyCode)
            {
                case Keys.E:
                    enemy.setHealthPoints(enemy.getHealthPoints() - player.CommonAttack());
                    break;

                case Keys.R: 
                    enemy.setHealthPoints(enemy.getHealthPoints() - player.StrongAttack());
                    break;

                case Keys.Space:
                    player.Block();
                    break;

                case Keys.Q:
                    player.Heal();
                    break;
            }
        }

        
    }
}
