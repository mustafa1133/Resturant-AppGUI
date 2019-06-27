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
    public partial class AddCustomer : Form
    {
        public Customer customer { get; set; }
        public AddCustomer()
        {
            InitializeComponent();
            customer = new Customer();
            
        }

        public AddCustomer(Customer customer): this()
        {
            this.customer = customer;
            textBoxCustName.Text = customer.Name;
            txtCustPhone.Text = customer.Phone.ToString();
            txtStreet.Text = customer.Address.Street;
            txtPostalCode.Text = customer.Address.PostalCode;
            txtProvince.Text = customer.Address.Province;
            txtCity.Text = customer.Address.City;
        }




        private void btnAddCust_Click(object sender, EventArgs e)
        {
            customer.Name = textBoxCustName.Text;
            customer.Phone = Convert.ToUInt32 (txtCustPhone.Text);
            customer.Address.Street = txtStreet.Text;
            customer.Address.PostalCode = txtPostalCode.Text;
            customer.Address.Province = txtProvince.Text;
            customer.Address.City = txtCity.Text;
            DialogResult = DialogResult.OK;
            Close();

   
        }
    }
}
