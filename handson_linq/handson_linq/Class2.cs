using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson_linq
{
    internal class Class2
    {
        public void find()
        {
            string[] cities =new string[] { "ROME", "LONDON", "NAIROBI", "LIFORNIA", "ZURICH","NEW DELHI","AMSTERDAM","ABU DHABI","PARIS" };
            var result= from c in cities
                        where c.StartsWith("A") && c.EndsWith("M")
                        select c;
            foreach(var c in result)
            {
                Console.WriteLine(c);
            }
           
        }
        public void disp()
        {
            Console.WriteLine("How many records you want to display ? :");
            int a = Convert.ToInt32(Console.ReadLine());
            List<int> ints = new List<int>() { 5, 7, 13, 24, 6, 9, 8, 7 };
            var re= from n in ints
                    orderby n descending
                    select n;
            var r= (from n in re
                   select n).Take(a).ToList();
            foreach(var n in r)
            {
                Console.WriteLine(n);
            }
        }
    }
}
