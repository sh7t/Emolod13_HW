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
        string playerName = "";
        public MainScreen(string playerName)
        {
            InitializeComponent();
            this.playerName = playerName;
        }

        private void MainScreen_Load(object sender, EventArgs e)
        {
            Player player = new Player(playerName);
            // static Random random = new Random();
            // static GameEngine gameEngine = new GameEngine();
            playerCharacteristics.Text = player.ShowCharacteristics();
        }

        private void turnButton_Click(object sender, EventArgs e)
        {
            // gameEngine.ChooseEventType();
        }
    }
}
