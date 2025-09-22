using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByNumb.Entities
{
    public abstract class Entity
    {
        // Fields
        protected string name = null;
        protected int level = 1;
        protected int healthPoints = 0;
        protected int maxHealthPoints = 0;

        // Init
        public Entity(string name)
        {
            this.name = name;
        }

        // Get-set'tters
        public string getName() { return name; }
        public void setName(string name) { this.name = name; }

        public int getLevel() { return level; }
        public void setLevel(int level) { this.level = level; }

        public int getHealthPoints() { return healthPoints; }
        public void setHealthPoints(int healthPoints) { this.healthPoints = healthPoints; }

        public int getMaxHealthPoints() { return maxHealthPoints; }
        public void setMaxHealthPoints(int maxHealthPoints) { this.maxHealthPoints = maxHealthPoints; }
    }
}
