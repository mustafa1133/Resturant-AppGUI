using CoffeeShopLib;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib.MenuItemAdditions
{
    public class Tomato: MenuItemAddition
    {
        public Tomato(IMenuItem item) : base(item)
        {
            if (item != null)
            {
                Description = item.Description + " Tomato";
                BaseCost = item.BaseCost + 0.35m;
            }

        }

        public Tomato() : base()
        {
            Description = "Tomato";
            BaseCost = 0.35m;
        }
    }
}
