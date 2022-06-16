using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace event_mangement
{
    internal class superadmin
    {
        public static string str = "Data Source=LAPTOP-2D3FN7GQ;Initial Catalog=Event_mangement;Integrated Security=True";
        public string insert()
        {
            Console.WriteLine("Enter the new Admin Id:");
            int id=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the new Admin Name:");
            string Name =Console.ReadLine();
            Console.WriteLine("Enter the new Admin Role:");
            string Role =Console.ReadLine();
            SqlConnection sqlConnection = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("insert into Adminn values(" + id + ",'"+ Name+"','"+ Role+ "')",sqlConnection);
            sqlConnection.Open();
            int a=cmd.ExecuteNonQuery();
            sqlConnection.Close();
            if (a == 0)
            {
                return "Not Inserted";
            }
            return "Inserted";
        }
        public string update()
        {
            Console.WriteLine("Enter the Admin Id to be upadated:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the new Admin Name to be upadated :");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the new Admin Role to be upadated:");
            string Role = Console.ReadLine();
            SqlConnection sqlConnection = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("update Adminn set admin_Name='" +Name+ "', admin_Role='"+Role+"'where admin_Id="+id+"", sqlConnection);
            sqlConnection.Open();
            int a = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            if (a == 0)
            {
                return "Not Updated";
            }
            return "Updated";

        }
        public string delete(int id)
        {
            SqlConnection sqlConnection = new SqlConnection(str);
            SqlCommand cmd = new SqlCommand("delete from Adminn where admin_Id="+id, sqlConnection);
            sqlConnection.Open();
            int a = cmd.ExecuteNonQuery();
            sqlConnection.Close();
            if (a == 0)
            {
                return "Not Deleted";
            }
            return "Deleted";

        }
        
    }
}
