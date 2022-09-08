using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class task2
    {
        public static void Main()
        {
            Console.WriteLine("Do you have travel history?");
            string answer = Console.ReadLine();
            if (answer == "yes")
            {
                Console.WriteLine("Do you have temperature?");
                string tempreture = Console.ReadLine();
                if (tempreture == "yes")
                {
                    Console.WriteLine("Do you have cough and fever?");
                    string health = Console.ReadLine();
                    if (health == "yes")
                    {
                        Console.WriteLine("Take a swab test");

                    }
                    else
                        Console.WriteLine("Quarantine and take fever medicine");

                }
            }
            else
                Console.WriteLine("safe,you dont have covid19");
        }
    }
}