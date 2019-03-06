using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Coffe_Shop_lib
{
    [Serializable]
    public class CustomerRepository
    {
        private Customer [] customers= new Customer[10];
        private uint positionInArray;



        public Customer[] Customers
        {
            get { return customers; }

        }

        public void Add(Customer aCustomer)
        {
            if (positionInArray <= Customers.Length)
            {
                Customers[positionInArray++] = aCustomer;
            }
            else
            {
                Console.WriteLine("Customer amount exceeds 10");
            }
        }

        public void Save (string filename)
        {
            FileStream fileOut = new FileStream(filename, FileMode.Create, FileAccess.Write);
            StreamWriter writer = new StreamWriter(fileOut);
            JsonSerializer serializer = JsonSerializer.Create(new JsonSerializerSettings { Formatting = Formatting.Indented });
            serializer.Serialize(writer, customers);
            writer.Close();
            fileOut.Close();

        }

        public Customer[] Load (string filename)
        {
            Customer[] result = null;
            FileStream fileIn = new FileStream(filename, FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(fileIn);
            JsonSerializer serializer= JsonSerializer.Create (new JsonSerializerSettings { Formatting = Formatting.Indented });
            result = serializer.Deserialize(reader, typeof(Customer[])) as Customer[];
            reader.Close();
            fileIn.Close();
            return result;
        }

    }
}
