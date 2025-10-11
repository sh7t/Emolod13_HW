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
    public partial class MainScreen : Form
    {
        private Player player;
        public MainScreen(string playerName)
        {
            InitializeComponent();
            player = new Player(playerName);
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            UpdateCharacteristics(player);
            if (BackgroundImage == Properties.Resources.LosingScreen)
            {
                turnButton.Hide();
            }
        }

        private void turnButton_Click(object sender, EventArgs e)
        {
            GameEngine.ChooseEventType(this, player);
        }

        public void WhenWin()
        {
            player.setStrength(player.getLevel());
            player.setAgility(player.getLevel());
            player.setEndurance(player.getLevel());
            player.setIntelligence(player.getLevel());
            player.setMaxHealthPoints(player.getEndurance() * 50);
            player.setMaxMana(player.getIntelligence() * 50);
            player.setCriticalChance(player.getAgility() * 0.5);

            UpdateCharacteristics(player);
        }
        public void WhenLose()
        {
            BackgroundImage = global::ByNumb.Properties.Resources.LosingScreen;
            playerImage.Image = global::ByNumb.Properties.Resources.DeadPlayer;

            FakeButtonImage.Show();
            turnButton.Hide();

            player.setHealthPoints(0);
            player.setMana(0);
            player.setExperience(0);
            player.setExperienceForLevelUp(0);
            player.setName($"Dead {player.getName()}");
            player.setCriticalChance(0);

            UpdateCharacteristics(player);
        }
        public void UpdateCharacteristics(Player player)
        {
            playerCharacteristics.Text = player.ShowCharacteristics();
        }

 
    }
}
