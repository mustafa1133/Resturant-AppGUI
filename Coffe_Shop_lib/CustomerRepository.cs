using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace CoffeeShopLib
{
    [Serializable]
    public class CustomerRepository : RepositoryBase
    {

        private List<Customer> customers;




        public override List<Customer> Customers
        {
            get { return customers; }
            set { customers = value; }

        }
        public CustomerRepository()
        {
            customers = new List<Customer>();
        }
       
        public void Add(Customer aCustomer)
        {
            
                Customers.Add(aCustomer);

        }

        public List<Customer> FindNotDelivered()
        {
            List<Customer> aCust;
            aCust = Customers.Where(c => c.Orders.All(orderInformation => orderInformation.Delivered== false)).ToList();
            return aCust;
        }

        public IEnumerable<Customer> BetweenTwoDateOrders(DateTime firstDate, DateTime secondDate)
        {
            IEnumerable<Customer> customersList =
                from cust in Customers
                where cust.Orders.All(orderInformation => orderInformation.DeliveryTime <=secondDate && orderInformation.DeliveryTime > firstDate)
                select cust;
            return customersList;

        }
    }
}
