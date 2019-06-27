using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib.MenuItemAdditions
{ 
    public class Cheese:MenuItemAddition
    {
        public Cheese(IMenuItem item) : base(item)
        {
            if (item != null)
            {
                Description = item.Description + " Cheese";
                BaseCost = item.BaseCost + 0.40m;
            }

        }

        public Cheese() : base()
        {
            Description = "Cheese";
            BaseCost = 0.40m;
        }
    }
}

