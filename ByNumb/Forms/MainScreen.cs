using ByNumb.Entities;
using ByNumb.Services;
using System;
using System.Windows.Forms;

namespace ByNumb.Forms
{
    public partial class MainScreen : Form
    {
        private Player player;
        public MainScreen(Player _player)
        {
            InitializeComponent();
            player = _player;
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

        public void WhenLose()
        {
            BackgroundImage = global::ByNumb.Properties.Resources.LosingScreen;
            playerImage.Image = global::ByNumb.Properties.Resources.DeadPlayer;
            FakeButtonImage.Show();
            turnButton.Hide();
            saveButton.Hide();

            GameEngine.WhenLose(player);
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            SaveLoadService.Save(player);
        }

        public void UpdateCharacteristics(Player player)
        {
            playerCharacteristics.Text = player.ShowCharacteristics();
        }
    }
}
