using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Xml.Serialization;
using System.Xml;
using System.IO;

namespace serializeDeserialize
{
    public class Customer
    {
        public int CustomerId { get; set; }
        public string CustomerName { get; set; }
        public int NoOfUnits { get; set; }
        public int UnitPerCost { get; set; } = 7;
        public int Total { get; set; }

    }
    public class show
    {
        public void serialize()
        {
            List<Customer> customers = new List<Customer>();
            Customer customer = new Customer();
            Console.WriteLine("Enter Customer Id.");
            customer.CustomerId = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Customer name");
            customer.CustomerName = (Console.ReadLine());

            Console.WriteLine("Enter No of units");
            customer.NoOfUnits = Convert.ToInt32(Console.ReadLine());

            customer.Total = 7 * customer.NoOfUnits;

            customers.Add(customer);
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<Customer>));
            FileStream fs = new FileStream(@"C:\visual\text88.txt", FileMode.Create, FileAccess.Write);
            StreamWriter sw=new StreamWriter(fs);
            XmlWriter xmlWriter = new XmlTextWriter(sw);
            xmlSerializer.Serialize(xmlWriter, customers);
            xmlWriter.Close();
            sw.Close();
            fs.Close();
        }
            public void deserialize()
            {
            List<Customer> customers = new List<Customer>();
            FileStream fs = new FileStream(@"C:\visual\text88.txt", FileMode.Open);
            XmlSerializer serializer = new XmlSerializer(typeof(List<Customer>));
            customers=(List<Customer>)serializer.Deserialize(fs);
            foreach(Customer customer in customers)
            {
                Console.WriteLine(customer.CustomerId);
                Console.WriteLine(customer.CustomerName);
                Console.WriteLine(customer.NoOfUnits);
                Console.WriteLine(customer.Total);

            }
        }
        
    }
  
}
