using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arraylistdict
{
    internal class Class2
    {
        public void jaggedarray()
        {
            int[][] ints = new int[4][];
            ints[0] = new int[4] { 1, 2, 3, 4 };
            ints[1] = new int[4] { 5, 6, 7, 8 };
            ints[2] = new int[4] { 9, 1, 2, 3 };
            ints[3] = new int[4] { 4, 5, 6, 7 };
            string[][] strings = new string[3][]
            {
                new string[2] { "AS", "qq" },
                new string[3] { "njx", "nja", "nx" },
                new string[2] {"qq","ss" },

            };
            for (int i = 0; i < strings.Length; i++)
            {
                Console.Write("Elements:"+(i+1)+"\t");
                for (int j = 0; j < strings[i].Length; j++)
                {
                    Console.Write(strings[i][j]+"\t");
                }
                Console.WriteLine();
            }

        }
    }
}
