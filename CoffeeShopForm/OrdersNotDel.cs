using CoffeeShopLib;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CoffeeShopForm
{
    public partial class OrdersNotDel : Form
    {
        CustomerRepository cusRpo = new CustomerRepository();
        List<Customer> Customers { get; set; }
        public OrdersNotDel(CustomerRepository cusR)
        {
            InitializeComponent();
            this.cusRpo = cusR;
            Customers = new List<Customer>();
            Customers = this.cusRpo.FindNotDelivered();

            foreach (Customer c in Customers)
            {
                lbxNotDel.Items.Add(c);
            }
        }


    }
}
