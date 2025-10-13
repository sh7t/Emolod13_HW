using ByNumb.Entities;
using ByNumb.Items;
using ByNumb.Services;
using System;
using System.Windows.Forms;

namespace ByNumb.Forms
{
    public partial class Shop : Form
    {
        private Player player;
        private MainScreen mainScreen;
        private Item[] items;
        private bool isFirstBought, isSecondBought, isThirdBought, isFourthBought, isFifthBought;

        public Shop(Player player, MainScreen mainScreen)
        {
            InitializeComponent();
            this.player = player;
            this.mainScreen = mainScreen;
            isFirstBought = false;
            isSecondBought = false;
            isThirdBought = false;
            isFourthBought = false;
            isFifthBought = false;
        }

        private void Shop_Load(object sender, EventArgs e)
        {
            // ShopType
            // 0 - Armor, 1 - Weapon
            if (CustomRandom.Next(0, 2) == 0)
            {
                firstItem.Image = Properties.Resources.FirstArmor;
                secondItem.Image = Properties.Resources.SecondArmor;
                thirdItem.Image = Properties.Resources.ThirdArmor;
                fourthItem.Image = Properties.Resources.FourthArmor;
                fifthItem.Image= Properties.Resources.FifthArmor;
                
                items = ArmorGenerator.GenerateArmorArray(5, player.getLevel());
            }
            else
            {
                firstItem.Image = Properties.Resources.FirstSword;
                secondItem.Image = Properties.Resources.SecondSword;
                thirdItem.Image = Properties.Resources.ThirdSword;
                fourthItem.Image = Properties.Resources.FourthSword;
                fifthItem.Image = Properties.Resources.FifthSword;

                items = WeaponGenerator.GenerateWeaponArray(5, player.getLevel());
            }
            ShowItemCharacteristics(items);
        }

        

        private void firstItemLabel_Click(object sender, EventArgs e)
        {
            byte itemIndex = 0;
            if (ClickAndBuy(itemIndex, isFirstBought))
            {
                isFirstBought = true;
                if (items[itemIndex] is Armor armor)
                {
                    player.setArmor((Armor)items[itemIndex]);
                    firstItem.Image = Properties.Resources.OutOfStockArmor;
                }
                else
                {
                    player.setWeapon((Weapon)items[itemIndex]);
                    firstItem.Image = Properties.Resources.OutOfStockSword;
                }
            }
        }
        private void secondItemLabel_Click(object sender, EventArgs e)
        {
            byte itemIndex = 1;
            if (ClickAndBuy(itemIndex, isSecondBought))
            {
                isSecondBought = true;
                if (items[itemIndex] is Armor armor)
                {
                    player.setArmor((Armor)items[itemIndex]);
                    secondItem.Image = Properties.Resources.OutOfStockArmor;
                }
                else
                {
                    player.setWeapon((Weapon)items[itemIndex]);
                    secondItem.Image = Properties.Resources.OutOfStockSword;
                }
            }
        }
        private void thirdItemLabel_Click(object sender, EventArgs e)
        {
            byte itemIndex = 2;
            if (ClickAndBuy(itemIndex, isThirdBought))
            {
                isThirdBought = true;
                if (items[itemIndex] is Armor armor)
                {
                    player.setArmor((Armor)items[itemIndex]);
                    thirdItem.Image = Properties.Resources.OutOfStockArmor;
                }
                else
                {
                    player.setWeapon((Weapon)items[itemIndex]);
                    thirdItem.Image = Properties.Resources.OutOfStockSword;
                }
            }
        }
        private void fourthItemLabel_Click(object sender, EventArgs e)
        {
            byte itemIndex = 3;
            if (ClickAndBuy(itemIndex, isFourthBought))
            {
                isFourthBought = true;
                if (items[itemIndex] is Armor armor)
                {
                    player.setArmor((Armor)items[itemIndex]);
                    fourthItem.Image = Properties.Resources.OutOfStockArmor;
                }
                else
                {
                    player.setWeapon((Weapon)items[itemIndex]);
                    fourthItem.Image = Properties.Resources.OutOfStockSword;
                }
            }
        }
        private void fifthItemLabel_Click(object sender, EventArgs e)
        {
            byte itemIndex = 4;
            if (ClickAndBuy(itemIndex, isFifthBought))
            {
                isFifthBought = true;
                if (items[itemIndex] is Armor armor)
                {
                    player.setArmor((Armor)items[itemIndex]);
                    fifthItem.Image = Properties.Resources.OutOfStockArmor;
                }
                else
                {
                    player.setWeapon((Weapon)items[itemIndex]);
                    fifthItem.Image = Properties.Resources.OutOfStockSword;
                }
            }
        }
        private bool ClickAndBuy(byte arrayIndex, bool isBuyed)
        {
            DialogResult dialogResult;
            if (!isBuyed)
            {
                if (items[arrayIndex] is Armor armor) { dialogResult = MessageBox.Show($"You want to buy {items[arrayIndex].getName()}.\nPrice: {items[arrayIndex].getPrice()}\nDefense Bonus: +{((Armor)items[arrayIndex]).getDefenseBonus()} Def\n\nYour gold: {player.getGold()}\n\nAre you sure?", $"{items[arrayIndex].getName()}", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information); }
                else { dialogResult = MessageBox.Show($"You want to buy {items[arrayIndex].getName()}.\nPrice: {items[arrayIndex].getPrice()}\nAttack Bonus: +{((Weapon)items[arrayIndex]).getAttackBonus()} Att\n\nYour gold: {player.getGold()}\n\nAre you sure?", $"{items[arrayIndex].getName()}", MessageBoxButtons.YesNoCancel, MessageBoxIcon.Information); }
                
                if (dialogResult == DialogResult.Yes)
                {
                    isBuyed = player.BuyItem(items[arrayIndex].getPrice(), items[arrayIndex].getName());
                    if (isBuyed) { return true; }
                }
                return false;
            }
            else
            {
                MessageBox.Show($"You can't buy this item because it's already out of stock.", $"{items[arrayIndex].getName()}", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
        }

        private void leaveButton_Click(object sender, EventArgs e)
        {
            mainScreen.Show();
            this.Close();
        }
        private void ShowItemCharacteristics(Item[] items)
        {
            firstItemLabel.Text = $"{items[0].getName()}";
            secondItemLabel.Text = $"{items[1].getName()}";
            thirdItemLabel.Text = $"{items[2].getName()}";
            fourthItemLabel.Text = $"{items[3].getName()}";
            fifthItemLabel.Text = $"{items[4].getName()}";

            firstItemPriceLabel.Text = $"for {items[0].getPrice()} gold";
            secondItemPriceLabel.Text = $"for {items[1].getPrice()} gold";
            thirdItemPriceLabel.Text = $"for {items[2].getPrice()} gold";
            fourthItemPriceLabel.Text = $"for {items[3].getPrice()} gold";
            fifthItemPriceLabel.Text = $"for {items[4].getPrice()} gold";
        }
    }
}
