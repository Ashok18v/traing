using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson_linq
{
    internal class Class1
    {
        int count = 1;
        public void display()
        {

            int[] num = new int[] { 5, 9, 1, 2, 3, 7, 5, 6, 7, 3, 7, 6, 8, 5, 4, 9, 6, 2 };
            Dictionary<int, int> map = new Dictionary<int, int>();
            var R = from d in num
                    group d by d into c
                    select c;
            foreach(var s in R)
            {
                Console.WriteLine(s.Key + ":" + s.Count());
            }
        }
        public void display1()
        {
            string line = "apple";
            char[] c = line.ToCharArray();
            var result = from a in c
                         group a by a into y
                         select y;
            foreach(var x in result)
            {
                Console.WriteLine(x.Key+":"+x.Count());
            }

        }
    }
}

