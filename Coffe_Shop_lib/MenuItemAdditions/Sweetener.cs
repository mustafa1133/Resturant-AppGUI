using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib.MenuItemAdditions
{
    public class Sweetener : MenuItemAddition
    {

        public Sweetener(IMenuItem item) : base(item)
        {
            if (item != null)
            {
                Description = item.Description + " Sweetner";
                BaseCost = item.BaseCost + 0.06M;
            }
        }

        public Sweetener() : base()
        {
            Description = "Sweetner";
            BaseCost = 0.06m;
        }
    }
}
