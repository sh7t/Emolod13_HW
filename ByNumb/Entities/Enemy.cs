using System;
using ByNumb;


namespace ByNumb.Entities
{
    public class Enemy : Entity
    {
        // Fields
        private int attack = 0;
        private int defense = 0;
        private int goldReward = 0;
        private int experienceReward = 0;

        // Init
        public Enemy(string name, int attack, int defense, int maxHealthPoints,
            int goldReward, int experienceReward, Random random, int Level) : base(name)
        {
            this.attack = attack;
            this.defense = defense;
            this.maxHealthPoints = maxHealthPoints;
            this.goldReward = goldReward;
            this.experienceReward = experienceReward;

            level = Math.Max(1, Level + random.Next(-1, 2));
            healthPoints = maxHealthPoints;
        }

        // Get-set'ters
        public int getAttack() { return attack; }
        public void setAttack(int attack) { this.attack = attack; }

        public int getDefense() { return defense; }
        public void setDefense(int defense) { this.defense = defense; }

        public int getGoldReward() { return goldReward; }
        public void setGoldReward(int goldReward) { this.goldReward = goldReward; }

        public int getExperienceReward() { return experienceReward; }
        public void setExperienceReward(int experienceReward) { this.experienceReward = experienceReward; }
    }
}
