using System;

namespace ByNumb.Items
{
    public class Weapon : Item
    {
        // Fields
        private int attackBonus = 0;

        // Init
        public Weapon(string name, int price, int attackBonus) : base(name, price)
        {
            this.attackBonus = attackBonus;
        }

        // Get-set'ters
        public int getAttackBonus() { return attackBonus; }
        public void setAttackBonus(int attackBonus) { this.attackBonus = attackBonus; }
    }
}
