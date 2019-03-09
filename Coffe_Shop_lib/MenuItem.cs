using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    [Serializable]
    public class MenuItem
    {
        private string description;
        private decimal baseCost;

        public string Description
        {
            get { return description; }
            set { description = value; }
        }
        public decimal BaseCost
        {
            get { return baseCost; }
            set { baseCost = value; }
        }

        public MenuItem(string descriptioni, decimal baseCosti)
        {
            Description = descriptioni;
            BaseCost = baseCosti;
        }
        public MenuItem()
        {

        }

        public override string ToString()
        {
            return $"==========MENU ITEM DESCRIPTION========\n  Name:{Description}\n  Cost:{BaseCost:C}\n";
        }
    }
}
