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
           
            playerCharacteristics.Text = player.ShowCharacteristics();
        }

        private void turnButton_Click(object sender, EventArgs e)
        {
            GameEngine.ChooseEventType(this, player);
        }
    }
}
