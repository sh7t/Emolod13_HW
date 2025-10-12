using ByNumb.Forms;
using ByNumb.Items;
using ByNumb.Services;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;

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
        private int gold = 10000;
        private double criticalChance = 0;
        private Weapon weapon = null;
        private Armor armor = null;

        // Init
        public Player(string name) : base(name)
        {
            maxHealthPoints = healthPoints = this.endurance * 50;
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
        public void GainExperience(int experience)
        {
            this.experience += experience;
            while (this.experience > this.experienceForLevelUp)
            {
                this.experience -= this.experienceForLevelUp;
                this.experienceForLevelUp += 10;
                this.level++;
            }
        }
        public void LoseExperience(int experience)
        {
            if (this.experience - experience > 0) { this.experience -= experience; }
            else { this.experience = 0; }
        }
        public bool BuyItem(int price, string itemName)
        {
            if (this.gold >= price)
            {
                this.gold -= price;
                MessageBox.Show($"Congratulations, you successfully bought a new item {itemName}!", "Brand-new!", MessageBoxButtons.OK);
                return true;
            }
            else
            {
                MessageBox.Show("You don't have enough gold to buy it! Try again later.", "Not enough money!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }
        public void GainGold(int gold)
        {
            this.gold += gold;
        }
        public void LoseGold(int gold)
        {
            if (this.gold - gold > 0) { this.gold -= gold; }
            else{ this.gold = 0; }
        }
        public void GainHP(int hp)
        {
            if (healthPoints < maxHealthPoints - hp) { healthPoints += hp;}
            else { healthPoints = maxHealthPoints; }
        }
        public void GainMana(int mana)
        {
            if (this.mana < maxMana - mana) { this.mana += mana; }
            else { this.mana = maxMana; }
        }
        public void GainDamage(int damage, MainScreen mainScreen)
        {
            if (damage > CalculateDefensePotential())
            {
                this.setHealthPoints(this.getHealthPoints() - (damage - this.CalculateDefensePotential()));
            }
            if (this.healthPoints <= 0) { mainScreen.WhenLose(); }
        }

        public int CommonAttack()
        {
            if (this.getMana() >= intelligence * 5)
            {
                this.setMana(this.getMana() - intelligence * 5);
                return CalculateAttackPower();
            }
            else
            {
                return 0;
            }
        }
        public int StrongAttack()
        {
            if (this.getMana() >= intelligence * 15)
            {
                this.setMana(this.getMana() - intelligence * 15);
                return CalculateAttackPower() + level * 2;
            }
            else
            {
                return 0;
            }
            
        }
        public void Heal()
        {
            if (this.getHealthPoints() < this.getMaxHealthPoints() - (this.getMaxHealthPoints() / 5))
            {
                this.setHealthPoints(this.getHealthPoints() + (this.getMaxHealthPoints() / 5));
            }
            if (this.getMana() < this.getMaxMana() - (this.getMaxMana() / 20))
            {
                this.setMana(this.getMaxMana() - (this.getMaxMana() / 20));
            }
        }

        public int CalculateAttackPower()
        {
            if (CustomRandom.Next(1, 1001) <= ((int)(criticalChance * 10)))
            {
                if (weapon != null)
                {
                    return (int)(1.5 * (strength + weapon.getAttackBonus()));
                }
                else
                {
                    return (int)1.5 * strength;
                }
            }
            else
            {
                if (weapon != null)
                {
                    return strength + weapon.getAttackBonus();
                }
                else
                {
                    return strength;
                }
            }
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
                return (characteristics + $"\nWeapon: {weapon.getName()}(+{weapon.getAttackBonus()} Att)\nArmor: {armor.getName()}(+{armor.getDefenseBonus()} Def)");
            }
            else if (armor == null && weapon != null)
            {
                return (characteristics + $"\nWeapon: {weapon.getName()}(+{weapon.getAttackBonus()} Att)");
            }
            else if (armor != null && weapon == null)
            {
                return (characteristics + $"\nArmor: {armor.getName()}(+{armor.getDefenseBonus()} Def)");
            }
            else
            {
                return characteristics;
            }
        }
    }
}
