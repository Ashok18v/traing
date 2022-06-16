using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace event_mangement
{
    internal class customer_details
    {
        public static string str = "Data Source=LAPTOP-2D3FN7GQ;Initial Catalog=Event_mangement;Integrated Security=True";
        public DataTable select()
        {
            #region
            SqlConnection sq=new SqlConnection(str);
            SqlDataAdapter adp = new SqlDataAdapter("select *from Event_details", sq);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
            #endregion

        }
        public void cust_new(int code)
        {
            #region
            SqlConnection sq = new SqlConnection(str);
            SqlDataAdapter adapter = new SqlDataAdapter("insert into customer (Venue_code,Venue) select Venue_code, Venue from Event_details where Venue_code="+code, sq);
          DataTable dataTable = new DataTable();
            adapter.Fill(dataTable);
            #endregion
            #region
            Console.WriteLine("Enter the Event Date(YY-MM-DD)");
            object date=Console.ReadLine();
            Console.WriteLine("Enter the Timings(starttime - endtime )");
            object time=Console.ReadLine();
            string app = "Process in progress";
            Console.WriteLine("Enter your Mobile Number");
            long num = Convert.ToInt64(Console.ReadLine());
          SqlConnection sq2 = new SqlConnection(str);
            SqlDataAdapter sqlDataAdapter = new SqlDataAdapter("update customer set Event_Date='" + date + "',Timings='" + time + "',Event_Approval='" + app + "'Moblie_Number="+num+" where Venue_code=" + code, sq);
            DataTable d = new DataTable();
            sqlDataAdapter.Fill(d);
            Console.WriteLine("We will notify your apporval soon");
            #endregion
        }
        public DataTable show(long a)
        {
            #region
            SqlConnection sq = new SqlConnection(str);
            SqlDataAdapter adp = new SqlDataAdapter("select *from customer where Moblie_Number="+a, sq);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
            #endregion

        }
        public DataTable ssw()
        {
            #region
            SqlConnection sq = new SqlConnection(str);
            SqlDataAdapter adp = new SqlDataAdapter("select *from customer", sq);
            DataTable dt = new DataTable();
            adp.Fill(dt);
            return dt;
            #endregion
        }
            public string up(long numb) {
            Console.WriteLine("Apporved or Not Approved");
            string asd = Console.ReadLine();
            #region
            SqlConnection sqm = new SqlConnection(str);
            SqlDataAdapter adps = new SqlDataAdapter("update customer set Event_Approval='"+asd+"' where Moblie_Number="+numb, sqm);
            DataTable dta = new DataTable();
            adps.Fill(dta);
            return "Updated";
            #endregion

        }
    }
}
