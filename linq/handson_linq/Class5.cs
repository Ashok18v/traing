using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson_linq
{
    internal class Class5
    {
        public void displa()
        {
            List<string> fruits = new List<string>() { "Lemon", "Apple", "Orange", "Lime", "Watermelon", "Loganberry" };
            var r = from s in fruits
                    where s.StartsWith("L")
                    select s;
            foreach (var s in r)
            {
                Console.WriteLine(s);
            }




        }
    }
}
