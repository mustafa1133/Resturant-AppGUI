using Newtonsoft.Json;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{

    [Serializable]
    public class Customer 
    {
        private uint idnumber;
        private string name;
        private uint phone;
        private List<Order> orders;
        public Address Address;
        private static uint numberOfIdNumber;


 
        public Customer(string aName, uint aTelephoneNumber,Address aAddress)
        {
            Orders = new List<Order>();
            Name = aName;
            Phone = aTelephoneNumber;
            IdNumber = numberOfIdNumber++;
            Address = aAddress;
        }


        public Customer()
        {
            Orders = new List<Order>();
            Address = new Address();

            IdNumber = numberOfIdNumber++;
        }

        public Customer(Address restAddress)
        {
            restAddress = Address.SHOP_ADDRESS;

            IdNumber = numberOfIdNumber++;
        }

        public uint IdNumber
        {
            get { return idnumber; }
            set { idnumber = value; }
        }
        public string Name
        {
            get { return name; }
            set { name = value; }
        }
        public uint Phone
        {
            get { return phone; }
            set { phone= value; }

        }
        [JsonProperty]
        public List<Order> Orders
        {
            get { return orders; }
            private set { orders = value; }
        }



        public Order CreatePhoneOrder(Address aAddress)
        {
            Order someOrder = new Order(aAddress) { Customer = this};
            Orders.Add(someOrder);

            return someOrder;
        }

        public Order AddOrder(Order aOrder)
        {

            Orders.Add(aOrder);
            return aOrder;

        }
        static Customer()
        {
            numberOfIdNumber = 0;
        }

        public override string ToString()
        {
            string result;

            result = $" ID Number: {IdNumber}\n  Name: {Name}\n";
            if(Orders != null)
            {

                foreach (Order aOrder in Orders)
                {
                    if (aOrder != null)
                    {
                        result += $"{aOrder.GetInfo()}\n";
                    }
                }
            }
            return result;

        }

    }
}

