using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coffe_Shop_lib
{
    [Serializable]
    public class OrderItem
    {
        private MenuItem menuItem = new MenuItem();



        public MenuItem MenuItem
        {
            get { return menuItem; }
            set { menuItem = value; }
        }

        public OrderItem(MenuItem menuItemi)
        {
            MenuItem = menuItemi;

        }
        public string GetInfo()
        {
            string result = $"{menuItem.GetInfo()}";
            return result;
        }
    }
}
