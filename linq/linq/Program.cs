using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace linq
{
   
        public class student {
            public int id { get; set; }
            public string name { get; set; }
            public int age { get; set; }
            public string dept { get; set; }

        }
    internal class Program
    {public void show()
        {
            List<student> list = new List<student>()
         {
             new student (){ id = 1, name = "Ashok", age=21, dept="ECE"},
             new student (){ id = 1, name = "Sai", age=22, dept="ECE"},
             new student (){ id = 1, name = "Ajay", age=21, dept="CSE"},
             new student (){ id = 1, name = "Rakesh", age=21, dept="IT"},
             new student (){ id = 1, name = "Naveen", age=21, dept="MECH"},
             new student (){ id = 1, name = "Venkat", age=21, dept="ECE"},

         };
            var result=(from l in list
                       where l.dept=="ECE"
                       select l);
            foreach(var item in result)
            {
                Console.WriteLine(item.id);
                Console.WriteLine(item.name);
                Console.WriteLine(item.age);
                Console.WriteLine(item.dept);

            }
        }


        static void Main(string[] args)
        {
            Program program = new Program();
            program.show();
        }
    }
}
