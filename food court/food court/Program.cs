using System; 
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace food_court
{
    internal class Program
    {
      List<string> files = new List<string>();
        public void mange_food_items()
        {
            object[] adding = new object[4];
            Console.WriteLine("Category");
            adding[0] = "Category:" + Console.ReadLine();
            Console.WriteLine("Add the item");
            adding[1] = "Name:" + Console.ReadLine();
            Console.WriteLine("Price");
            adding[2] = "Price:" + Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Details");
            adding[3] = "Details:" + Console.ReadLine();
          
            FileStream fs = new FileStream(@"C:\visual\item.txt", FileMode.Append, FileAccess.Write);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(adding[0]);
            sw.WriteLine(adding[1]);
            sw.WriteLine(adding[2]);
            sw.WriteLine(adding[3]);
            sw.Close();
            fs.Close(); 
        }
        public void run() { 
            FileStream fi = new FileStream(@"C:\visual\item.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr=new StreamReader(fi);
            string line;
            Console.WriteLine("Category" + "\t" + "Items" +"\t"+ "\t"+"\t" + "Price"+"\t"+"Details");
            while(sr.Peek()> 0)
            {
                line=sr.ReadLine();
                if (line.StartsWith("Cat"))
                {
                    string[] my=line.Split(':');
                    Console.Write(my[1]+"\t"+"\t");
                }
                if (line.StartsWith("Name"))
                {
                    
                    string[] my = line.Split(':');
                    
                    Console.Write(my[1]+"\t"+"\t"+"\t");
                    for(int i = 0; i < sr.Peek(); i++)
                    {
                        files.Add(my[1]);
                        break;
                    }


                }
                if (line.StartsWith("Price"))
                {
                    string[] my = line.Split(':');
                    Console.Write(my[1]+"\t");

                }
                if (line.StartsWith("Deta"))
                {
                    string[] my = line.Split(':');
                    Console.Write(my[1]);
                    Console.WriteLine();
                    
                }

            }
            sr.Close();
            fi.Close();
            Console.WriteLine();
        }
        public void show()
        {
            Console.WriteLine("List of Food items");
            foreach(var items in files)
            {
                Console.WriteLine(items);
            }
            
        }
        static void Main(string[] args)
        {
            Program program = new Program();
           // program.mange_food_items();
           program.run();
           program.show();
        }
    }
}
