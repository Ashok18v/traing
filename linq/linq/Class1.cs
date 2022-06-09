using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
    public class employee
    {
        public int id { get; set; }
        public string name { get; set; }
        public int age { get; set; }
        public string dept { get; set; }

    }
    internal class Class1
    {
        public void emp()
        {
            List<employee> list = new List<employee>()
         {
             new employee (){ id = 1, name = "Ashok", age=21, dept="ECE"},
             new employee (){ id = 1, name = "Sai", age=22, dept="ECE"},
             new employee (){ id = 1, name = "Ajay", age=21, dept="CSE"},
             new employee (){ id = 1, name = "Rakesh", age=21, dept="IT"},
             new employee (){ id = 1, name = "Naveen", age=21, dept="MECH"},
             new employee (){ id = 1, name = "Venkat", age=21, dept="ECE"},

         };
            var result1 = (from e in list
                           where e.dept == "IT"
                           select e).Single();
            Console.WriteLine(result1);

        }
    }
}
