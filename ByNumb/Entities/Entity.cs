using System;
using System.Text.Json.Serialization;

namespace ByNumb.Entities
{
    public abstract class Entity
    {
        // Fields
        [JsonInclude]
        protected string name = null;
        [JsonInclude]
        protected int level = 1;
        [JsonInclude]
        protected int healthPoints = 0;
        [JsonInclude]
        protected int maxHealthPoints = 0;

        // Init
        public Entity(string _name)
        {
            name = _name;
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
