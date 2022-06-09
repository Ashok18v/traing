using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylistdict
{
    internal class Class1
    {
        public void details()
        {
            var student = Tuple.Create("Ashok", "Veera", 21, "Gurazala", 7032111289, "B.Tech", 4, 8.5);
            Tuple<int, string, int> empolyee = new Tuple<int, string, int>(10, "Veera", 21);
            Console.WriteLine(empolyee.Item1);
            Console.WriteLine(empolyee.Item2);
            Console.WriteLine(empolyee.Item3);
            Console.WriteLine(student.Item1);
            Console.WriteLine(student.Item2);
            Console.WriteLine(student.Item3);
            Console.WriteLine(student.Item4);
            Console.WriteLine(student.Item5);
            Console.WriteLine(student.Item6);
            Console.WriteLine(student.Item7);
            Console.WriteLine(student.Rest);

        }
        public void nested()
        {
            var student = Tuple.Create("Ashok", "Veera", 21, "Gurazala", 7032111289, "B.Tech", 4, Tuple.Create("Akhila",19,"B.tech"));
            Console.WriteLine(student.Rest.Item1.Item1);
            Console.WriteLine(student.Rest.Item1.Item2);
            Console.WriteLine(student.Rest.Item1.Item3);
           

        }
        public void settuple(Tuple<int, string, int> student1)
        {
            Console.WriteLine(student1.Item1);
            Console.WriteLine(student1.Item2);
            Console.WriteLine(student1.Item3);
        }
        public static Tuple< int,string,int> retruntype(int id)
        {
            var details = Tuple.Create(10, "a", 111);
            return details;


        }
    }
}
