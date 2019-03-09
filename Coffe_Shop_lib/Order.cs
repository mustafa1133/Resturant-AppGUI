using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    [Serializable]
    public class Order
    {
        private uint orderId;
        [JsonIgnore]
        private Customer customer;
        private DateTime orderTimer;
        private DateTime deliveryTime;
        private Address deliveryAdress;
        private decimal cost;
        private OrderItem[] items= new OrderItem[50];
        private bool delivered;
        private uint orderPositionInArray;
        private const uint MAX_NUMBER_OF_ITEMS = 50;
        private static uint numberOfOrders;
        public OrderType OrderType;
        

        public Order(decimal aCost, OrderType aOrderType, Address aAddress)
        {

            Items = new OrderItem[MAX_NUMBER_OF_ITEMS];
            orderId = numberOfOrders++;
            Cost = aCost;
            Delivered = Status();
            OrderTimer = DateTime.Now;
            DeliveryAdress = new Address();
            this.OrderType = aOrderType;
            DeliveryAdress = aAddress;


        }

        public Order()
        {
            OrderType=OrderType.Resturant;
            OrderTimer = DateTime.Now;
            DeliveryAdress = Address.SHOP_ADDRESS;
            delivered = true;
        }

        public Order(Address aAddress)
        {
            DeliveryAdress = aAddress;
        }
        static Order()
        {
            numberOfOrders = 13567;
        }
        [JsonIgnore]
        public Customer Customer
        {
            get { return customer; }
            set {
                if(customer==null)
                {
                    customer = value;
                }
                else
                {
                    Console.WriteLine("Something went wrong! Customer cannot be changed once assigned");
                }
                }
        }
        public DateTime OrderTimer
        {
            get { return orderTimer; }
            set { orderTimer = value; }

        }
        public DateTime DeliveryTime
        {
            get { return deliveryTime; }
            set { deliveryTime = value; }
        }
        public decimal Cost
        {
            get { return cost; }
            set { cost = value; }
        }

        public OrderItem[] Items
        {
            get { return items; }
            set { items = value; }
        }
        public Address DeliveryAdress
        {
            get { return deliveryAdress; }
            set { deliveryAdress = value; }
        }
        public bool Delivered
        {
            get { return delivered; }
            set { delivered = value; }
        }

        public uint OrderId
        {
            get { return orderId; }
            set { orderId = value; }
        }
        public void AddOrderItem(MenuItem aItem)
        {
            if (orderPositionInArray <= Items.Length)
            {
                OrderItem orderItem = new OrderItem(aItem);
                Items[orderPositionInArray++] = orderItem;
                Cost += aItem.BaseCost;
            }
            else
            {
                Console.WriteLine("Order Items exceed the amount of 50");
            }
        }   

        public DateTime Deliver()
        {
            if (Delivered == true)
            {
                DeliveryTime = System.DateTime.Now;
                return DeliveryTime;
            }
            else
            {
                DeliveryTime = System.DateTime.MinValue;
                return DeliveryTime;
            }
        }
        public bool Status()
        {
            if (DeliveryTime == Deliver())
            {
                Delivered = true;
            }
            return Delivered;

        }
        
        public string GetInfo()
        {
            string result = null;
            if (Status() == true)
            {

                result = $"==========ORDER INFORMATION===========\n" + $"  Order ID: {orderId}\n  Order Time: {OrderTimer}\n  Delivery Time: {Deliver()}\n  Status: DELIVERED\n  DELIVERY ADRESS\n {DeliveryAdress.GetInfo()}\n  Cost: {cost:C}\n  Order Type: {OrderType}\n\n";
                foreach (OrderItem aItem in Items)
                {
                    if (aItem != null)
                    {
                        result += $"{aItem.GetInfo()}\n";
                    }
                }
            }
            else
            {
                result = "NOT DELIVERED\n";
            }
            return result;
        }


    }
}

