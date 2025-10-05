using ByNumb.Entities;
using System;


namespace ByNumb.Services
{
    public class EnemyGenerator
    {
        // Fields
        private string[] names = { };

        // Init
        public EnemyGenerator()
        {

        }

        // Methods
        public Enemy GenerateEnemy(int playerLevel)
        {
            Random random = new Random();

            return new Enemy(names[random.Next(0, names.Length)], Math.Max(1, playerLevel + random.Next(-1, 2)));
        }
    }
}
