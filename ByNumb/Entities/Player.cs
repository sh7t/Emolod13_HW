using ByNumb.Items;

namespace ByNumb.Entities
{
    public class Player : Entity
    {
        // Fields
        private int experience = 0, experienceForLevelUp = 10;
        private int strength = 1;
        private int endurance = 1;
        private int agility = 1;
        private int intelligence = 1;
        private int mana = 0, maxMana = 0;
        private int gold = 0;
        private double criticalChance = 0;
        private Weapon weapon = null;
        private Armor armor = null;
        private bool DidBlocked = false;

        // Init
        public Player(string name) : base(name)
        {
            maxHealthPoints = healthPoints = this.endurance * 100;
            maxMana = mana = this.intelligence * 50;
            criticalChance = this.agility * 0.5;
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
        public int CommonAttack()
        {
            if (DidBlocked)
            {
                DidBlocked = false;
                return (CalculateAttackPower() / 2);
            }
            else
            {
                return CalculateAttackPower();
            }
        }
        public int StrongAttack()
        {
            if (DidBlocked)
            {
                DidBlocked = false;
                return ((CalculateAttackPower() + level*2) / 2);
            }
            else
            {
                return CalculateAttackPower() + level*2;
            }
        }
        public int Defense()
        {
            if (DidBlocked)
            {
                DidBlocked = false;
                return 0;
            }
            else
            {
                DidBlocked = true;
                return CalculateDefensePotential();
            }
        }
        public int Healing()
        {
            if (DidBlocked)
            {
                DidBlocked = false;
                return ((maxHealthPoints / 10)*2);
            }
            else
            {
                return maxHealthPoints / 10;
            }
        }

        public int CalculateAttackPower()
        {
            if (weapon != null)
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
        
        public string ShowCharacteristics()
        {
            string characteristics = ($"Characteristics:\nName: {getName()}\nLevel: {getLevel()}" +
                                      $"\nExperience: {getExperience()}/{getExperienceForLevelUp()}\nHP: {getHealthPoints()}/{getMaxHealthPoints()}" +
                                      $"\nMana: {getMana()}/{getMaxMana()}" +
                                      $"\nStrength: {getStrength()}\nEndurance: {getEndurance()}\nAgility: {getAgility()}\nIntelligence: {getIntelligence()}" +
                                      $"\nGold: {getGold()}\nCriticalChance: {getCriticalChance()}%");
            if (weapon != null && armor != null)
            {
                return (characteristics + "\nWeapon: {weapon.getName()}\nArmor: {armor.getName()}");
            }
            else if (armor == null && weapon != null)
            {
                return (characteristics + "\nWeapon: {weapon.getName()}");
            }
            else if (armor != null && weapon == null)
            {
                return (characteristics + "\nArmor: {armor.getName()}");
            }
            else
            {
                return characteristics;
            }
        }
    }
}
