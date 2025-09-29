using ByNumb.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByNumb.Services
{
    public class GameEngine
    {
        // Fields
        int playerLevel = 0;

        // Init
        public GameEngine(Player player)
        {
            playerLevel = player.getLevel();
        }
        // Get-set'ters

        // Methods
        public int CalculateEnemyLevel()
        {
            Random random = new Random();
            return Math.Max(1, playerLevel + random.Next(-1, 2));
        }
    }
}
