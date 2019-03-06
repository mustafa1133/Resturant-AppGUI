using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe_Shop_lib
{
    [Serializable]
    public class MenuItem
    {
        private string name;
        private string description;
        private decimal baseCost;

        public string Name
        {
            get { return name; }
            set { name = value; }
        }
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

        public MenuItem(string namei, string descriptioni, decimal baseCosti)
        {
            Name = namei;
            Description = descriptioni;
            BaseCost = baseCosti;
        }
        public MenuItem()
        {

        }

        public string GetInfo()
        {
            return $"==========MENU ITEM DESCRIPTION========\n  Name: {Name}\n  Details: {Description}\n  Cost:{BaseCost:C}\n";
        }
    }
}
