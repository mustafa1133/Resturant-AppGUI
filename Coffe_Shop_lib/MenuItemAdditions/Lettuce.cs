using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib.MenuItemAdditions
{
    public class Lettuce : MenuItemAddition
    {
        public Lettuce(IMenuItem item) : base(item)
        {
            if (item != null)
            {
                Description = item.Description + " Lettuce";
                BaseCost = item.BaseCost + 0.30m;
            }

        }

        public Lettuce() : base()
        {
            Description = "Lettuce";
            BaseCost = 0.10m;
        }
    }
}
