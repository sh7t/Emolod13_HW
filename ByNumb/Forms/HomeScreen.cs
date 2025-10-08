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
    public partial class HomeScreen : Form
    {
        public HomeScreen()
        {
            InitializeComponent();
        }

        private void playButton_Click(object sender, EventArgs e)
        {
            if (playerNameTextBox.Text.Length >= 2)
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
            else
            {
                MessageBox.Show("Your character's name is too short. Please go back and rename him!", "Unnamed character issue", 
                    MessageBoxButtons.OK, MessageBoxIcon.Error);
            }        
        }
    }
}
