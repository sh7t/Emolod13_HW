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

        // Init
        public GameEngine()
        {

        }
        // Get-set'ters

        // Methods
        public int CalculateEnemyLevel(int level)
        {
            Random random = new Random();
            return Math.Max(1, level + random.Next(-1, 2));
        }
    }
}
