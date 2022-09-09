using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Accomadation : Membership
    {
        public void silver()
        {
            Console.WriteLine("3 days accomodation in Resort");
                
         }
        public void gold()
        {
            Console.WriteLine("5 days accomodation in Resort and 2 dinners at house");

        }
        public void platinum()
        {
            Console.WriteLine("7 days accomodation in Resort and 5 dinners at house");

        }
    }
    internal class InterfaceTask
    {
        public static void Main()
        {
            Accomadation stay = new Accomadation();
            stay.silver();
            stay.gold();
            stay.platinum();
        }

    }
}
