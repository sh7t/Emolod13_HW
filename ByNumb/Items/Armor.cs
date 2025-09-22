using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByNumb.Items
{
    public class Armor : Item
    {
        // Fields
        private int defenseBonus = 0;

        // Init
        public Armor(string name, double price, int defenseBonus) : base(name, price)
        {
            this.defenseBonus = defenseBonus;
        }

        // Get-set'ters
        public int getDefenseBonus() { return defenseBonus; }
        public void setDefenseBonus(int defenseBonus) { this.defenseBonus = defenseBonus; }
    }
}
