using CoffeeShopLib;
using CoffeeShopLib.MenuItemAdditions;
using CoffeeShopLib.MenuItems;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MenuItem = CoffeeShopLib.MenuItem;

namespace CoffeeShopForm
{
    public partial class AddOrder : Form
    {
        public MenuItem AMenuItem;
        public MenuItemAddition AMenuItemAddition;
        public MenuItem CurrentOrder { get; set; }
        public Customer ACustomer { get; set; }
        public AddOrder(Customer customer)
        {
            InitializeComponent();
            ACustomer = customer;
            Coffee aCoffee = new Coffee();
            CoffeeDarkRoast aDarkRoastCoffee = new CoffeeDarkRoast();
            SandwichWithBacon aBaconSandwich = new SandwichWithBacon();
            SandwichWithEggSalad aEggSandwich = new SandwichWithEggSalad();
            SandwichWithRoastedBeef aRoastBeefSandwich = new SandwichWithRoastedBeef();
            Tea aTea = new Tea();
            Milk aMilk = new Milk();
            Suggar aSuggar = new Suggar();
            Sweetener aSweetner = new Sweetener();
            Cheese aCheese = new Cheese();
            Mayo aMayo = new Mayo();
            Lettuce aLettuce = new Lettuce();
            Tomato aTomato = new Tomato();
            lbxOrders.Items.Add(aCoffee);
            lbxOrders.Items.Add(aDarkRoastCoffee);
            lbxOrders.Items.Add(aBaconSandwich);
            lbxOrders.Items.Add(aEggSandwich);
            lbxOrders.Items.Add(aRoastBeefSandwich);
            lbxOrders.Items.Add(aTea);
            lbxAdditions.Items.Add(aSweetner);
            lbxAdditions.Items.Add(aMilk);
            lbxAdditions.Items.Add(aSuggar);
            lbxAdditions.Items.Add(aCheese);
            lbxAdditions.Items.Add(aMayo);
            lbxAdditions.Items.Add(aLettuce);
            lbxAdditions.Items.Add(aTomato);


        }

        private void lbxOrders_SelectedIndexChanged(object sender, EventArgs e)
        {
            AMenuItem = lbxOrders.SelectedItem as MenuItem;
            CurrentOrder = AMenuItem;
        }

        private void lbxAdditions_SelectedIndexChanged(object sender, EventArgs e)
        {
            AMenuItemAddition = lbxAdditions.SelectedItem as MenuItemAddition;
        }

        private void btnAddItem_Click(object sender, EventArgs e)
        {
            AddAnOrder(CurrentOrder);
        }
        public void AddAnOrder(IMenuItem aItem)
        {
            AMenuItemAddition = lbxAdditions.SelectedItem as MenuItemAddition;
            if(AMenuItemAddition is Suggar)
            {
                CurrentOrder = new Suggar(aItem);
                lbxOrdered.Items.Clear();
                lbxOrdered.Items.Add(CurrentOrder);
            }
            else if (AMenuItemAddition is Milk)
            {
                CurrentOrder = new Milk(aItem);
                lbxOrdered.Items.Clear();
                lbxOrdered.Items.Add(CurrentOrder);
            }
            else if (AMenuItemAddition is Sweetener)
            {
                CurrentOrder = new Sweetener(aItem);
                lbxOrdered.Items.Clear();
                lbxOrdered.Items.Add(CurrentOrder);
            }
            else if (AMenuItemAddition is Lettuce)
            {
                CurrentOrder = new Lettuce(aItem);
                lbxOrdered.Items.Clear();
                lbxOrdered.Items.Add(CurrentOrder);
            }
            else if (AMenuItemAddition is Tomato)
            {
                CurrentOrder = new Tomato(aItem);
                lbxOrdered.Items.Clear();
                lbxOrdered.Items.Add(CurrentOrder);
            }
            else if (AMenuItemAddition is Cheese)
            {
                CurrentOrder = new Cheese(aItem);
                lbxOrdered.Items.Clear();
                lbxOrdered.Items.Add(CurrentOrder);
            }
            else if (AMenuItemAddition is Mayo)
            {
                CurrentOrder = new Mayo(aItem);
                lbxOrdered.Items.Clear();
                lbxOrdered.Items.Add(CurrentOrder);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            lbxOrdered.Items.Remove(CurrentOrder);
        }

        private void lbxConfirmed_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Confirm_Click(object sender, EventArgs e)
        {
            lbxConfirmed.Items.Add(CurrentOrder);
            lbxOrdered.Items.Clear();
        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            
            Order phoneOrder = ACustomer.CreatePhoneOrder(ACustomer.Address);
            foreach (CoffeeShopLib.MenuItem item in lbxConfirmed.Items)
            {
                phoneOrder.AddOrderItem(item);

            }

            Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
