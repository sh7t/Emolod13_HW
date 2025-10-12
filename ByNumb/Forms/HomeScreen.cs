using ByNumb.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByNumb.Forms
{
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
            GameEngine.PlayMainTheme();
            musicInteractionButton.Image.Tag = "Play";
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (playerNameTextBox.Text.Length >= 2 && playerNameTextBox.Text.Length <= 12)
            {
                this.Hide();
                MainScreen mainScreen = new MainScreen(char.ToUpper(playerNameTextBox.Text[0]) + playerNameTextBox.Text.Substring(1));
                mainScreen.ShowDialog();
                this.Close();
            }
            else if (playerNameTextBox.Text.Length == 0)
            {
                MessageBox.Show("You haven't entered a name for Your character. Please go back and do so!", "Unnamed character issue",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (playerNameTextBox.Text.Length > 12)
            {
                MessageBox.Show("Your character's name is too long. Please go back and rename him!", "Character name issue",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("Your character's name is too short. Please go back and rename him!", "Character name issue",
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            playerNameTextBox.Clear();
        }

        private void musicInteractionButton_Click(object sender, EventArgs e)
        {
            switch (musicInteractionButton.Image.Tag.ToString())
            {
                case "Play":
                    musicInteractionButton.Image = global::ByNumb.Properties.Resources.MuteButton;
                    musicInteractionButton.Image.Tag = "Mute";
                    GameEngine.MuteMainTheme();
                    break;
                case "Mute":
                    musicInteractionButton.Image = global::ByNumb.Properties.Resources.PlayButton;
                    musicInteractionButton.Image.Tag = "Play";
                    GameEngine.PlayMainTheme();
                    break;
                default:
                    musicInteractionButton.Image.Tag = "Play";
                    break;
            }
        }

        private void loadButton_Click(object sender, EventArgs e)
        {
            // 
            //
            // after file's lesson
            //
            //
            MessageBox.Show("Your in-game achievements have been successfully loaded!", "Success!", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
