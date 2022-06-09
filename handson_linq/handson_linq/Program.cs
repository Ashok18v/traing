using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson_linq
{
    internal class Program
    {
        public void numbers()
        {
            List<int> n1 = new List<int> { 1, 3, -2, -4, -7, -3, -8, 12, 19, 6, 9, 10, 14 };
            var result = (from n in n1
                          where n != 0
                          where n>0
                          select n).ToList();   
            foreach(var n in result)
            {
                Console.WriteLine(n);
            }

        }
        static void Main(string[] args)
        {
           // Program program = new Program();    
          //  program.numbers();
          Class1 class1 = new Class1();
           class1.display1();
       // Class2 class2 = new Class2();
         //  class2.disp();
        // Class3 class3 = new Class3();
          //  class3.max();
       // Class4 class4 = new Class4();
          //  class4.print();
         // Class5 class5 = new Class5();
          //  class5.displa();
        }

    }
}
