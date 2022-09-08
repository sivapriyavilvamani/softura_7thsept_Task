using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class task5
    {
        public static void Main()
        {

            string[] Package1 = { "1.South special", "2.children's club",  "3.children's club" };
            Console.WriteLine("Package1");
          
            for (int i = 0; i < Package1.Length; i++)
            {
               
                Console.WriteLine(Package1[i]);
            }
            string[] Package2 = { "1.News", "2.Sports", "3.Movies","Reginal 2" };
            Console.WriteLine("-------------");
            Console.WriteLine("Package2");
            

            for (int j = 0; j < Package2.Length; j++)

            {
                Console.WriteLine(Package2[j]);
            }

            string[] Package3 = { "1.Discovery", "2.National", "3.History" };
            Console.WriteLine("-------------");
            Console.WriteLine("Package3");
          
            for (int k = 0; k < Package3.Length; k++)
            {
                Console.WriteLine(Package3[k]);
            }
            Console.WriteLine("choose the package");
            string Package = Console.ReadLine();
            switch (Package)
            {
                case "Package1":
                    Console.WriteLine("The amount you need to pay is 250");
                    break;
                case "Package2":
                    Console.WriteLine("The amount you need to pay is 450");
                    break;
                case "Package3":
                    Console.WriteLine("The amount you need to pay is 350");
                    break;
                default:
                    Console.WriteLine("Please choose anyone of the Packages");
                    break;
            }
        }
    }
}
