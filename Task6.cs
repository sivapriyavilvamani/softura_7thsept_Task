using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace ConsoleApp
{
    internal class Task6
    {
        public static void Main()
        {
            string[,] subject = new string[5, 2]
            {
                { "English", "100" },
                { "Tamil", "98" },
                { "Math", "67" },
                { "English", "100" },
                { "Tamil", "98" }
            };
            int total = 0;
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 2; j++)
                    Console.Write(subject[i, j] + "\t");
                Console.WriteLine();
                total += Convert.ToInt32(subject[i, 1]);
                
            }
            int percentage = total /5;
            Console.WriteLine("Total={0},Percentage={1}%",total,percentage);




        }
    }
}
