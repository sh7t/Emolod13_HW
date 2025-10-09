using ByNumb.Entities;
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
    public partial class Shop : Form
    {
        private Player player;
        public Shop(Player player)
        {
            InitializeComponent();
            this.player = player;
        }

    }
}
