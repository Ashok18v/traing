using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylistdict
{
    internal class Program
    {
        public void array()
        {
            int[] arr = {1,1,2, 3,5,8};
            for (int i = 0; i < arr.Length; i++)
            {
               
                int a=arr[i]%2;
                if(a == 0)
                {
                    Console.WriteLine("odd:"+arr[i]);
                    

                }
            }

        }
        public void String()
        {
            string line= "I would not, could not, in a box. I would not, could not with a fox.I will not eat them in a house. I will not eat them with a mouse.";
            string[] arr = line.Split(' ');
            Console.WriteLine(string.Join(" ", arr));
            for(int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

        }
        public void dowhile()
        {
            do
            {
                Console.WriteLine("Hello");
            }while(false);
        }
        static void Main(string[] args)
        {
            //Program program = new Program();
            //   program.dowhile();
            //Class1 class1 = new Class1();
            //   class1.settuple(Tuple.Create(10,"a",12));
            //  var detail= Class1.retruntype(1);
            //   Console.WriteLine(detail.Item1);
            //   Class2 class2 = new Class2();
            // class2.jaggedarray();
            outer outerobj = new outer();
            int a = 10;

            int b = 20;
            outerobj.addition(ref a,b);
            Console.WriteLine("A:" + a);
            outer.inner obj = new outer.inner();
            int d;
            obj.sub(out d);
            Console.WriteLine("D:"+d);
            Calculator calculator = new Calculator(10, 20);
            calculator = -calculator;
            calculator.Print();
        }
    }
}
