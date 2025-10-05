using System;

namespace ByNumb.Items
{
    public abstract class Item
    {
        // Fields
        protected string name = null;
        protected int price = 0;

        // Init
        public Item(string name, int price)
        {
            this.name = name;
            this.price = price;
        }

        // Get-set'ters
        public string getName() { return name; }
        public void setName(string name) { this.name = name; }

        public int getPrice() { return price; }
        public void setPrice(int price) { this.price = price; }

        // Methods
    }
}
