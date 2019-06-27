using CoffeeShopLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib.MenuItemAdditions
{
    public class Milk : MenuItemAddition
    {
        public Milk(IMenuItem item): base(item)
        {
            if (item != null)
            {
                Description = item.Description + " Milk";
                BaseCost = item.BaseCost + 0.10m;
            }

        }

        public Milk():base()
        {
            Description = "Milk";
            BaseCost = 0.10m;
        }
    }
}
