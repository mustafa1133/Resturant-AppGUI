using CoffeeShopForm;
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

namespace CoffeShopForm
{
    public partial class Form1 : Form
    {
        Customer customer = new Customer();
        public Customer ACustomer { get; set; }
        public Form1()
        {
            InitializeComponent();
            Customer restcustomer = new Customer("1 King St", 0,Address.SHOP_ADDRESS);
            lbxCustomer.Items.Add(restcustomer);
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            AddCustomer cusForm = new AddCustomer();
            DialogResult dr = cusForm.ShowDialog();
            
            if(dr== DialogResult.OK)
            {
                lbxCustomer.Items.Add(cusForm.customer);
            }


        }



        private void lbxCustomer_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Customer changeCustomer = lbxCustomer.SelectedItem as Customer;
            AddCustomer cust = new AddCustomer(changeCustomer);
            DialogResult dr = cust.ShowDialog();
            if (dr== DialogResult.OK)
            {
                lbxCustomer.Items.Remove(lbxCustomer.SelectedItem);
                lbxCustomer.Items.Add(changeCustomer);
            }
        }

        private void btnAddOrder_Click(object sender, EventArgs e)
        {
            AddOrder ordForm = new AddOrder(lbxCustomer.SelectedItem as Customer);
            DialogResult dr = ordForm.ShowDialog();
            
            lbxCustomerOrdered.Items.Add(ordForm.CurrentOrder);

        }

        private void lbxCustomerOrdered_SelectedIndexChanged(object sender, EventArgs e)
        {
            
           
        }

        private void button2_Click(object sender, EventArgs e)
        {

            CustomerRepository repository = new CustomerRepository();
            foreach (Customer customer in lbxCustomer.Items)
            {
                repository.Add(customer);
            }
            repository.Save("Customers.json");

            MessageBox.Show("SAVED");
        }

        private void btnCusNDel_Click(object sender, EventArgs e)
        {

            CustomerRepository repository = new CustomerRepository();
            foreach (Customer customer in lbxCustomer.Items)
            {
                repository.Add(customer);
            }
            OrdersNotDel basically = new OrdersNotDel(repository);
            basically.ShowDialog();
        }
        
    }
}