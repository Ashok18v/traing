using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
namespace ado.net
{
    internal class Customer_data
    {
        public static string sqlconnection = "Data Source=LAPTOP-2D3FN7GQ;Initial Catalog=Bankdb;Integrated Security=True";
        public string instertCustomer()
        {Console.WriteLine("Enter the Customer Id:");
            int id =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Customer Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the Customer Email:");
            string Email = Console.ReadLine();
            Console.WriteLine("Enter the Customer Mobile Number:");
            int Moblie_number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Customer Address:");
            string Address = Console.ReadLine();
            SqlConnection conn = new SqlConnection(sqlconnection);
            SqlCommand cmd = new SqlCommand("insert into Customer values("+id+",'"+Name+"','"+Email+"',"+Moblie_number+",'"+Address+"')",conn);
            conn.Open();
            cmd.ExecuteNonQuery();
            conn.Close();
            return "";
        }
    }
}
