using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace event_mangement
{
    internal class events
    {
        public static string str = "Data Source=LAPTOP-2D3FN7GQ;Initial Catalog=Event_mangement;Integrated Security=True";
        public string insert()
        {
            Console.WriteLine("Enter the venue code:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Venue:");
            string Place = Console.ReadLine();
            Console.WriteLine("Enter the Capacity of Hall:");
            int Capcity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Equipment Provides:");
            string equipment= Console.ReadLine();
            Console.WriteLine("Enter the Food Items Provides:");
            string food = Console.ReadLine();
            Console.WriteLine("Enter the Cost:");
            int cost = Convert.ToInt32(Console.ReadLine());
            SqlConnection connect = new SqlConnection(str);
            SqlCommand sqlCommand = new SqlCommand("insert into Event_details values("+id+",'"+Place+"',"+Capcity+",'"+equipment+"','"+food+"',"+cost+")", connect);  
            connect.Open();
            int a=sqlCommand.ExecuteNonQuery();
            connect.Close();
            if(a==0)
            {
                return "Not Inserted";
            }
            return "Inserted";
        }
        public string update()
        {
            Console.WriteLine("Enter the venue code:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Venue to be updated:");
            string Place = Console.ReadLine();
            Console.WriteLine("Enter the Capacity of Hall:");
            int Capcity = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the Equipment Provides:");
            string equipment = Console.ReadLine();
            Console.WriteLine("Enter the Food Items Provides:");
            string food = Console.ReadLine();
            Console.WriteLine("Enter the Cost:");
            int cost = Convert.ToInt32(Console.ReadLine());
            SqlConnection connect = new SqlConnection(str);
            SqlCommand sqlCommand = new SqlCommand("update Event_details set Venue='"+Place+"', Capacity=" + Capcity + ",Equipment='" + equipment + "',Food_Items='"+food+"',Cost=" + cost +"where Venue_code="+id, connect);
            connect.Open();
            int a = sqlCommand.ExecuteNonQuery();
            connect.Close();
            if (a == 0)
            {
                return "Not updated";
            }
            return "updated"; 

        }
        public string delete(int code)
        {
            SqlConnection connect = new SqlConnection(str);
            SqlCommand sqlCommand = new SqlCommand("delete from Event_details where Venue_code="+code, connect);
            connect.Open();
            int a = sqlCommand.ExecuteNonQuery();
            connect.Close();
            if (a == 0)
            {
                return "Not Deleted";
            }
            return "Deleted";

        }
    }
}
