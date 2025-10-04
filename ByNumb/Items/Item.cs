using System;

namespace ByNumb.Items
{
    public abstract class Item
    {
        // Fields
        protected string name = null;
        protected double price = 0;

        // Init
        public Item(string name, double price)
        {
            this.name = name;
            this.price = price;
        }

        // Get-set'ters
        public string getName() { return name; }
        public void setName(string name) { this.name = name; }

        public double getPrice() { return price; }
        public void setPrice(double price) { this.price = price; }

        // Methods
    }
}
