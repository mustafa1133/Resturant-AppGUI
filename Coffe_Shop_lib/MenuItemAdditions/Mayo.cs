using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib.MenuItemAdditions
{
    public class Mayo:MenuItemAddition
    {
        public Mayo(IMenuItem item) : base(item)
        {
            if (item != null)
            {
                Description = item.Description + "Mayo";
                BaseCost = item.BaseCost + 0.00m;
            }

        }

        public Mayo() : base()
        {
            Description = "Mayo";
            BaseCost = 0.00m;
        }
    }
}
