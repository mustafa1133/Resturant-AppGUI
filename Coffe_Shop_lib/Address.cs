using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CoffeeShopLib
{
    [Serializable]
    public struct Address
    {
        public string Street;
        public string PostalCode;
        public string Province;
        public string City;
        public static Address SHOP_ADDRESS = new Address("1 King St", "Toronto", "ON", "M1M 1M1");


        public Address(string aProvince, string aStreetName,  string aPostalCode, string aCity)
        {
            Street= aStreetName;
            PostalCode = aPostalCode;
            City = aCity;
            Province = aProvince;
        }



        public string GetInfo()
        {
            return $" City: {City}\n  Street Name: {Street}\n  Province: {Province}\n  Postal Code: {PostalCode}\n";
        }
    }
}
