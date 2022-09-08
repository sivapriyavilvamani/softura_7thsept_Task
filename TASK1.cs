using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class TASK1
    {
        public static void Main()
        {
            Console.WriteLine("Enter your units consumed");
            int unit = Convert.ToInt32(Console.ReadLine());
            if (unit < 200)
            {
                Console.WriteLine("The electric bill is {0}", unit * 2);
            }
            else if (unit > 201 && unit <= 350)
            {
                int unitslab1 = unit - 200;
                Console.WriteLine("The electric bill is {0}", 400 + unitslab1 * 3);
            }
            else if (unit > 350 && unit <= 500)
            {
                int unitslab2 = unit - 350;
                Console.WriteLine("The electric bill is {0}", 850 + unitslab2 * 5);
            }
            else if (unit > 500)
            {

                int unitslab3 = unit - 500;
                Console.WriteLine("The electric bill is {0}", 1600 + unitslab3 * 7);
            }
        }
    }
}

