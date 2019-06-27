using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CoffeeShopLib;
using CoffeeShopLib.MenuItems;

namespace CoffeeShopLib.MenuItemAdditions
{
    public class Suggar: MenuItemAddition
    {
        public Suggar(IMenuItem item) : base(item)
        {
            if (item!= null)
            {
                Description = item.Description + " Sugar";
                BaseCost = item.BaseCost + 0.05M;
            }
        }

        public Suggar() : base()
        {
            Description = "Suggar";
            BaseCost = 0.05m;
        }
    }
}
