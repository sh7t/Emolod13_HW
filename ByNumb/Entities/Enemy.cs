using System;
using ByNumb;
using ByNumb.Services;


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
        public Enemy(string name, int level) : base(name)
        {
            Random random = new Random();

            attack = level * 5;
            defense = level * 10;
            maxHealthPoints = healthPoints = level * 100;
            goldReward = 15 + (level - 1) * 10 + random.Next(1, 11);
            experienceReward = 20 + (level - 1) * 10 + random.Next(1, 11);
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
