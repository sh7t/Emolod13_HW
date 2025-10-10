using ByNumb.Entities;
using System;


namespace ByNumb.Services
{
    public class EnemyGenerator
    {
        // Fields
        private string[] names =
        {
            "Lynx",
            "Hermit",
            "Butcher",
            "Wasp",
            "Widow",
            "Shogun",
            "Titan",
            "Volcano",
            "Megalith",
            "Fungus",
            "Vortex",
            "Fatum",
            "Arkhos",
            "Hoaxen",
            "Karcer",
            "Drakaina",
            "Tenebris",
            "Gatekeeper",
            "The Blackness",
            "Stalker",
        };

        // Init
        public EnemyGenerator()
        {

        }

        // Methods
        public Enemy GenerateEnemy(int playerLevel)
        {
            return new Enemy(names[CustomRandom.Next(0, names.Length)], Math.Max(1, playerLevel + CustomRandom.Next(-1, 2)));
        }
    }
}
