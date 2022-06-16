using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace event_mangement
{
    internal class Program
    {
        static void Main(string[] args)
        {
            superadmin superadmin = new superadmin();
            events events = new events();
            customer_details customer_Detail = new customer_details();
            Console.WriteLine("Press 1 for SuperAdmin");
            Console.WriteLine("Press 2 for Admin");
            Console.WriteLine("Press 3 for Customer");
            int re = Convert.ToInt32(Console.ReadLine());
            switch (re)
            {
                case 1:
                    
                    Console.WriteLine("press 1 to Insert Admin");
                    Console.WriteLine("press 2 to Update Admin");
                    Console.WriteLine("press 3 to delete Admin");
                    int gii = Convert.ToInt32(Console.ReadLine());
                    switch (gii)
                    {
                        case 1:
                            string data = superadmin.insert();
                            Console.WriteLine(data);
                            break;
                        case 2:
                            string dat = superadmin.update();
                            Console.WriteLine(dat);
                            break;
                        case 3:
                            Console.WriteLine("Enter the Admin id to delete:");
                            int b = Convert.ToInt32(Console.ReadLine());
                            string da = superadmin.delete(b);
                            Console.WriteLine(da);
                            break;
                    }
                    break;
                case 2:
                    
                    Console.WriteLine("press 1 to Insert New Venue Details");
                    Console.WriteLine("press 2 to Updated Venue Details");
                    Console.WriteLine("press 3 to Delete Venue Details");
                    Console.WriteLine("Press 4 to Update the customer approval");
                    int aa = Convert.ToInt32(Console.ReadLine());
                    switch (aa)
                    {
                        case 1:

                            string n = events.insert();
                            Console.WriteLine(n);
                            break;
                        case2:
                            string m = events.update();
                            Console.WriteLine(m);
                            break;
                        case 3:
                            Console.WriteLine("Enter the Venue code to Delete:");
                            int s = Convert.ToInt32(Console.ReadLine());
                            string k = events.delete(s);
                            Console.WriteLine(k);
                            break;
                   
                case 4:
                    DataTable dr= customer_Detail.ssw();
                    for(int i = 0; i < dr.Rows.Count; i++)
                    {
                        for (int j = 0; j < dr.Columns.Count; j++)
                        {
                            Console.WriteLine(dr.Rows[i][j] + "\t");
                        }

                    }
                    Console.WriteLine("To update?Yes or No");
                    string ww=Console.ReadLine();
                    if (ww =="Yes")
                    { Console.WriteLine("Enter the mobile number which u want update");
                        long ff = Convert.ToInt64(Console.ReadLine());
                        customer_Detail.up(ff);
                    }
                    break;
      
                    }
                    break;

                case 3:
                    Console.WriteLine("Press 1 To Book Function Hall");
                    Console.WriteLine("Prees 2  To View the approval details");
                 int rr=Convert.ToInt32(Console.ReadLine());
                    switch (rr)
                    {
                        case 1:
                            DataTable d = customer_Detail.select();
                            for (int i = 0; i < d.Rows.Count; i++)
                            {
                                Console.WriteLine("Avalaible Function Hall Details:");
                                for (int j = 0; j < d.Columns.Count; j++)
                                {
                                    switch (j)
                                    {
                                        case 0:
                                            Console.WriteLine("Venue Code: " + d.Rows[i][j]);
                                            break;
                                        case 1:
                                            Console.WriteLine("Venue: " + d.Rows[i][j]);
                                            break;
                                        case 2:
                                            Console.WriteLine("Capacity of Hall: " + d.Rows[i][j]);
                                            break;
                                        case 3:
                                            Console.WriteLine("Equipment Provides: " + d.Rows[i][j]);
                                            break;
                                        case 4:
                                            Console.WriteLine("Food Items Provides: " + d.Rows[i][j]);
                                            break;
                                        case 5:
                                            Console.WriteLine(" Cost: " + d.Rows[i][j]);
                                            break;

                                    }
                                }
                                Console.WriteLine();
                            }
                            Console.WriteLine("Do You Want To Book? Yes or No ");
                            string ddd = Console.ReadLine();
                            if (ddd == "Yes")
                            {
                                Console.WriteLine("Enter the Venue code to book:");
                                int h = Convert.ToInt32(Console.ReadLine());
                                customer_Detail.cust_new(h);
                            }
                            else
                            {
                                Console.WriteLine("Have a Nice day");
                            }

                            break;
                        case 2:
                            Console.WriteLine("Enter the Registered Mobile Number");
                            long ll = Convert.ToInt64(Console.ReadLine());
                            DataTable sss = customer_Detail.show(ll);
                            for (int i = 0; i < sss.Rows.Count; i++)
                            {
                                for (int j = 0; j < sss.Columns.Count; j++)
                                {
                                    Console.WriteLine(sss.Rows[i][j] + "\t");
                                }
                            }
                            break;
                    }

                            break;
            }
        }
    }
}
