using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace employee_table
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 emp = new Class1();
            //emp.insert();
            //DataTable dt= emp.select();
            // for(int i = 0; i < dt.Rows.Count; i++)
            // {
            //     for(int j = 0; j < dt.Columns.Count; j++)
            //     {
            //         Console.Write(dt.Rows[i][j]+"\t");
            //     }
            //     Console.WriteLine();
            // }
            string s=emp.update();
            Console.WriteLine(s);

        }
    }
}
