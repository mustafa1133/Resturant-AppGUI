using System;
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
        private Order[] orders = new Order[50];
        private Address address;
        private uint orderPositionInArray;
        private const uint MAX_NUMBER_OF_ITEMS = 50;
        private static uint numberOfIdNumber;


        public Customer(string aName, uint aTelephoneNumber,Address aAddress)
        {
            Name = aName;
            Phone = aTelephoneNumber;
            IdNumber = numberOfIdNumber++;
            Address = aAddress;
        }


        public Customer()
        {
            Orders = new Order[MAX_NUMBER_OF_ITEMS];
            address = new Address();
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
        public Order[] Orders
        {
            get { return orders; }
            private set { orders = value; }
        }
        public Address Address
        {
            get { return address; }
            set { address = value; }
        }


        public Order CreatePhoneOrder(Address aAddress)
        {
            Order someOrder = new Order(aAddress);
            if (orderPositionInArray<= Orders.Length)
            {
                Orders[orderPositionInArray++] = someOrder;
            }
            return someOrder;


        }

        public Order AddOrder(Order aOrder)
        {
            if (orderPositionInArray <= Orders.Length)
            {
                Orders[orderPositionInArray++] = aOrder;
            }
            return aOrder;

        }
        static Customer()
        {
            numberOfIdNumber = 1;
        }

        public override string ToString()
        {
            string result;

            result = $" ==========CUSTOMER INFORMATION========\n" + $"  ID Number: {IdNumber}\n  Name: {Name}\n  Telephonenumber:{Phone}\n {Address.GetInfo()}\n";
            foreach (Order aOrder in Orders)
            {
                if (aOrder != null)
                {
                    result += $"{aOrder.GetInfo()}\n";
                }
            }
            return result;

        }
    }
}

