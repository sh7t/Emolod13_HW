using ByNumb.Entities;
using System;


namespace ByNumb.Services
{
    public class EnemyGenerator
    {
        // Fields
        

        // Init
        public EnemyGenerator()
        {

        }

        // Methods
        public Enemy GenerateEnemy()
        {
            Random random = new Random();
            
            return new Enemy("1", 0, 0, 0, 0, 0);
        }

        public Enemy[] GenerateEnemyArray(byte arrayLength)
        {
            Random random = new Random();
            
            return new Enemy[1];
        }
    }
}
