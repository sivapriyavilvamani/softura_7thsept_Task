using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class task4
    {
        public static void Main()
        {
            Console.WriteLine("Enter your number");
            int number = Convert.ToInt32(Console.ReadLine());
           for(int i = 1; i <= 20; i++)
            {

                Console.WriteLine("{0}*{1}={2}",number,i,number*i);
            }
        }
        }
}
