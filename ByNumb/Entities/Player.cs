using ByNumb.Items;

namespace ByNumb.Entities
{
    public class Player : Entity
    {
        // Fields
        private int experience = 0, experienceForLevelUp = 10;
        private int strength = 0;
        private int endurance = 0;
        private int agility = 0;
        private int intelligence = 0;
        private int mana = 0, maxMana = 0;
        private int gold = 0;
        private double criticalChance = 0;
        private Weapon weapon = null;
        private Armor armor = null;

        // Init
        public Player(string name, int strength, int endurance, int agility, int intelligence) : base(name)
        {
            this.name = name;
            this.strength = strength;
            this.endurance = endurance;
            this.agility = agility;
            this.intelligence = intelligence;

            maxHealthPoints = this.endurance * 10;
            maxMana = this.intelligence * 5;
            criticalChance = this.agility * 0.5;
            healthPoints = maxHealthPoints;
            mana = maxMana;
        }

        // Get-set'ters
        public int getExperience() { return experience; }
        public void setExperience(int experience) { this.experience = experience; }

        public int getExperienceForLevelUp() { return experienceForLevelUp; }
        public void setExperienceForLevelUp(int experienceForLevelUp) { this.experienceForLevelUp = experienceForLevelUp; }

        public int getStrength() { return strength; }
        public void setStrength(int strength) { this.strength = strength; }

        public int getEndurance() { return endurance; }
        public void setEndurance(int endurance) { this.endurance = endurance; }

        public int getAgility() { return agility; }
        public void setAgility(int agility) { this.agility = agility; }

        public int getIntelligence() { return intelligence; }
        public void setIntelligence(int intelligence) { this.intelligence = intelligence; }

        public int getMana() { return mana; }
        public void setMana(int mana) { this.mana = mana; }

        public int getMaxMana() { return maxMana; }
        public void setMaxMana(int maxMana) { this.maxMana = maxMana; }

        public int getGold() { return gold; }
        public void setGold(int gold) { this.gold = gold; }

        public double getCriticalChance() { return criticalChance; }
        public void setCriticalChance(double criticalChance) { this.criticalChance = criticalChance; }

        public Weapon getWeapon() { return weapon; }
        public void setWeapon(Weapon weapon) { this.weapon = weapon; }

        public Armor getArmor() { return armor; }
        public void setArmor(Armor armor) { this.armor = armor; }

        // Methods
        public int CalculateAttackPower()
        {
            if (armor != null)
            {
                return (strength + weapon.getAttackBonus());
            }
            return strength;
        }

        public int CalculateDefensePotential()
        {
            if (armor != null)
            {
                return (agility + armor.getDefenseBonus());
            }
            return agility;
        }
    }
}
