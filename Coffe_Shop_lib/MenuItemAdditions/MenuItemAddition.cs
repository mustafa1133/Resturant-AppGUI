using CoffeeShopLib;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib.MenuItemAdditions
{
    public abstract class MenuItemAddition : MenuItem
    {
        [JsonProperty]
        private IMenuItem menu;

        [JsonIgnore]
        public IMenuItem Menu
        {
            get
            {
                return menu;
            }
            set
            {
                menu = value;
            }
        }
        public MenuItemAddition (IMenuItem item)
        {
            Menu = item;
        }

        public MenuItemAddition()
        {

        }
    }
}
