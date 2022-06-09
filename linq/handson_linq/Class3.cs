using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace handson_linq
{ public class Students
    {
        public int StuId { get; set; }
        public string StuName { get; set; }
        public int GrPoint { get; set; }

    }
    internal class Class3
    {
        public void max()
        {
            Console.WriteLine("Which maximum grade point(1st, 2nd, 3rd, ...) you want to find  :");
            int a = Convert.ToInt32(Console.ReadLine());
            List<Students> stulist = new List<Students>();
            stulist.Add(new Students { StuId = 1, StuName = " Joseph ", GrPoint = 800 });
            stulist.Add(new Students { StuId = 2, StuName = "Alex", GrPoint = 458 });
            stulist.Add(new Students { StuId = 3, StuName = "Harris", GrPoint = 900 });
            stulist.Add(new Students { StuId = 4, StuName = "Taylor", GrPoint = 900 });
            stulist.Add(new Students { StuId = 5, StuName = "Smith", GrPoint = 458 });
            stulist.Add(new Students { StuId = 6, StuName = "Natasa", GrPoint = 700 });
            stulist.Add(new Students { StuId = 7, StuName = "David", GrPoint = 750 });
            stulist.Add(new Students { StuId = 8, StuName = "Harry", GrPoint = 700 });
            stulist.Add(new Students { StuId = 9, StuName = "Nicolash", GrPoint = 597 });
            stulist.Add(new Students { StuId = 10, StuName = "Jenny", GrPoint = 750 });
            
            var result= from st in stulist
                        orderby st.GrPoint descending
                        select st;
            var r = (from s in result
                     select s).Take(a).ToList();
            foreach(var s in r)
            {
                Console.WriteLine(s.StuId);
                Console.WriteLine(s.StuName);
                Console.WriteLine(s.GrPoint);
                Console.WriteLine();
            }

        }
    }
}
