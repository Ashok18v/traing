using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace counting
{
    internal class Program
    {
        public void counti()
        {int count=1;
            Dictionary<char, int> dict = new Dictionary<char, int>();
            string text = "Lorem ipsum dolor sit amet, consectetur adipiscing elit. Nunc accumsan sem ut ligula scelerisque sollicitudin. Ut at sagittis augue. Praesent quis rhoncus justo. Aliquam erat volutpat. Donec sit amet suscipit metus, non lobortis massa. Vestibulum augue ex, dapibus ac suscipit vel, volutpat eget massa. Donec nec velit non ligula efficitur luctus.";
            char[] c=text.ToCharArray();
            for(int i=0; i<c.Length; i++)
            {  if (!dict.ContainsKey(c[i]))
                {
                    dict.Add(c[i],count);
                }
                else if (dict.ContainsKey(c[i]))
                {
                    dict[c[i]] = dict[c[i]]+1;
                }
             
            }foreach(var item in dict)
            {
                Console.WriteLine(Convert.ToString(item.Key)+"-"+item.Value);
            }
        }
        static void Main(string[] args)
        {//Program program = new Program();
          // program.counti();
          read read = new read();
            read.NEW();
          
        }
    }
}
