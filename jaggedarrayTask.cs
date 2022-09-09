using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class jaggedarrayTask
    {
        public static void Main()
        {
            string[] List = new string[] { "A", "B", "C" };
            string[] prodName = new string[] { "Biscuits", "Chocolates", "Drinks" };
            string[][] Products = new string[3][];
            Products[0] = new string[] { "Milkbikies","britania","oreo","digestive" };
            Products[1] = new string[] { "Dairymilk", "Eclairs","CandyMan","5 star","Milkybar" };
            Products[2] = new string[] { "limca", "Coke", "Pepsi", "Fanta", "Miranda" };
            for (int i = 0; i < Products.Length; i++)
            {
                Console.Write(List[i]+"\n",prodName[i]+"\t");

                for (int j = 0; j < Products[i].Length; j++)
                {
                    Console.Write(Products[i][j] + "\t");
                }
                Console.WriteLine();

            }
        }
    }
}
