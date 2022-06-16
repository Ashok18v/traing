using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace employee_table
{
    public class Class1
    { public static string sql_connection = "Data Source=LAPTOP-2D3FN7GQ;Initial Catalog=Bankdb;Integrated Security=True";
        public string insert()
        {
            Console.WriteLine("Enter the Employee Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  Employee Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the  Employee Dept:");
            string Dept = Console.ReadLine();
            Console.WriteLine("Enter the  Employee Mobile Number:");
            long Mobile_Number = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the  Employee Address:");
            string Address = Console.ReadLine();
            SqlConnection sqlConnection = new SqlConnection(sql_connection);

            SqlCommand sqlCommand = new SqlCommand("insert into Employe values(" + id + ",'" + Name + "','" + Dept + "'," + Mobile_Number + ",'" + Address + "')");
            sqlConnection.Open();
            sqlCommand.Connection = sqlConnection;
            sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            return "";
        }
        public DataTable select()
        {
            SqlConnection sqlConnection = new SqlConnection(sql_connection);
            SqlCommand sqlCommand=new SqlCommand("select *from Employe",sqlConnection);
            sqlConnection.Open();
            DataTable dataTable = new DataTable();
            SqlDataReader result= sqlCommand.ExecuteReader();
            dataTable.Load(result);
            sqlConnection.Close();
            return dataTable;
        }
        public string update()
        {
            Console.WriteLine("Enter the Employee Id:");
            int id = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the  Employee Name:");
            string Name = Console.ReadLine();
            Console.WriteLine("Enter the  Employee Dept:");
            string Dept = Console.ReadLine();
            Console.WriteLine("Enter the  Employee Mobile Number:");
            long Mobile_Number = Convert.ToInt64(Console.ReadLine());
            Console.WriteLine("Enter the  Employee Address:");
            string Address = Console.ReadLine();
            SqlConnection sqlConnection=new SqlConnection(sql_connection);
            SqlCommand sqlCommand = new SqlCommand("update Employe set Emp_Name='" + Name + "',Emp_dept='" + Dept + "',Mobile_Number=" + Mobile_Number + ",Emp_Address='" + Address + "' where Emp_Id=" + id + "",sqlConnection);
            sqlConnection.Open();
            int result=sqlCommand.ExecuteNonQuery();
            sqlConnection.Close();
            if (result == 0)
            {
                return "Not updated";
            }
            else
            {
                return "Updated";
            }
        }
    }
}
