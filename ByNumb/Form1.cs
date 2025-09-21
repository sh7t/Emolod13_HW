using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ByNumb
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        class Player
        {
            // Fields
            private string name = null;
            private int level = 0;
            private int experience = 0, experienceForLevelUp = 0;
            private int strength = 0;
            private int endurance = 0;
            private int agility = 0;
            private int intelligence = 0;
            private int healthPoints = 0, maxHealthPoints = 0;
            private int mana = 0, maxMana = 0;
            private int gold = 0;
            private double criticalChance = 0;
            private Weapon weapon = null;
            private Armor armor = null;

            // Init
            public Player(string name, int level, int experienceForLevelUp, int strength, 
                int endurance, int agility, int intelligence)
            {
                this.name = name;
                this.level = level;
                this.experienceForLevelUp = experienceForLevelUp;
                this.strength = strength;
                this.endurance = endurance;
                this.agility = agility;
                this.intelligence = intelligence;

                maxHealthPoints = this.endurance * 10;
                healthPoints = maxHealthPoints;
                maxMana = this.intelligence * 5;
                mana = maxMana;
                criticalChance = this.agility * 0.005;
            }

            // Get-set'ters
            public string getName() { return name; }
            public void setName(string name) { this.name = name; }

            public int getLevel() { return level; }
            public void setLevel(int level) { this.level = level; }

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

            public int getHealthPoints() { return healthPoints; }
            public void setHealthPoints(int healthPoints) { this.healthPoints = healthPoints; }

            public int getMaxHealthPoints() { return maxHealthPoints; }
            public void setMaxHealthPoints(int maxHealthPoints) { this.maxHealthPoints = maxHealthPoints; }

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
                return (strength + weapon.getAttackBonus());
            }

            public int CalculateDefensePotential()
            {
                return (agility + armor.getDefenseBonus());
            }
        }
        class Weapon
        {
            // Fields
            private string name = null;
            private double price = 0;
            private int attackBonus = 0;

            // Init
            public Weapon(string name, double price, int attackBonus)
            {
                this.name = name;
                this.price = price;
                this.attackBonus = attackBonus;
            }

            // Get-set'ters
            public string getName() { return name; }
            public void setName(string name) { this.name = name;  }

            public double getPrice() { return price; }
            public void setPrice(double price) { this.price = price; }

            public int getAttackBonus() { return attackBonus; }
            public void setAttackBonus(int attackBonus) { this.attackBonus = attackBonus; }
        }
        class Armor
        {
            // Fields
            private string name = null;
            private double price = 0;
            private int defenseBonus = 0;

            // Init
            public Armor(string name, double price, int defenseBonus)
            {
                this.name = name;
                this.price = price;
                this.defenseBonus = defenseBonus;
            }

            // Get-set'ters
            public string getName() { return name; }
            public void setName(string name) { this.name = name; }

            public double getPrice() { return price; }
            public void setPrice(double price) { this.price = price; }

            public int getDefenseBonus() { return defenseBonus; }
            public void setDefenseBonus(int defenseBonus) { this.defenseBonus = defenseBonus; }
        }
        class Enemy
        {
            // Fields
            private string name = null;
            private int level = 0;
            private int attack = 0;
            private int defense = 0;
            private int healthPoints = 0;
            private int maxHealthPoints = 0;
            private int goldReward = 0;
            private int experienceReward = 0;

            // Init
            public Enemy(string name, int level, int attack, int defense, int healthPoints, int maxHealthPoints,
                int goldReward, int experienceReward, int opponentLevel, Random random)
            {
                this.name = name;
                this.level = Math.Max(1, opponentLevel + random.Next(-1, 2));
                this.attack = attack;
                this.defense = defense;
                this.healthPoints = healthPoints;
                this.maxHealthPoints = maxHealthPoints;
                this.goldReward = goldReward;
                this.experienceReward = experienceReward;
            }

            // Get-set'ters
            public string getName() { return name; }
            public void setName(string name) { this.name = name; }

            public int getLevel() { return level; }
            public void setLevel(int level) { this.level = level; }

            public int getAttack() { return attack; }
            public void setAttack(int attack) { this.attack = attack; }

            public int getDefense() { return defense; }
            public void setDefense(int defense) { this.defense = defense; }

            public int getHealthPoints() { return healthPoints; }
            public void setHealthPoints(int healthPoints) { this.healthPoints = healthPoints; }

            public int getMaxHealthPoints() {return maxHealthPoints;}
            public void setMaxHealthPoints(int maxHealthPoints) { this.maxHealthPoints = maxHealthPoints; }

            public int getGoldReward() { return goldReward; }
            public void setGoldReward(int goldReward) { this.goldReward = goldReward; }

            public int getExperienceReward() { return experienceReward; }
            public void setExperienceReward(int experienceReward) { this.experienceReward = experienceReward; }
        }
        class Event
        {
            // Fields

            // Init

            // Get-set'ters

            // Methods
        }
        class Shop
        {
            // Fields

            // Init

            // Get-set'ters

            // Methods
            public void GenerateItems()
            {

            }
            public void BuyItem(string player, string item)
            {

            }
        }
        class GameEngine
        {
            // Fields

            // Init

            // Get-set'ters

            // Methods
        }

        private void gateInFate_Title_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            System.Diagnostics.Process.Start("https://github.com/sh7t/Emolod13_HW/");
        }
    }
}
