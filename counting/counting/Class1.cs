using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace counting
{
    internal class read

    {
        string line;
        
        public void NEW() {
            FileStream fs = new FileStream(@"C:\visual\bonus.txt", FileMode.Open, FileAccess.Read);
            StreamReader sr = new StreamReader(fs);
            
            while (sr.Peek() > 0)
            {line = sr.ReadLine();
                 
                Console.WriteLine(line);    
            }
            char[] mychar=line.ToCharArray();
            
            
         
           
        }
    }
}
