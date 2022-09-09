using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    internal class validatepolymorphism
    {
        public void validate(string id,string pw)
        {
            Console.WriteLine("The User Login is Validated using Email & Password");
        }
        public void validate(string id, int pin)
        {
            Console.WriteLine("The User Login is Validated using Userid & Pin");
        }
        public void validate(double num, int pin)
        {
            Console.WriteLine("The User Login is Validated using Mobilenumber & Pin");
        }

        public static void Main()
        {
            validatepolymorphism valuate = new validatepolymorphism();
            valuate.validate("siva@gmail.com", "12ghy");
            valuate.validate("hj12dr", 1256);
            valuate.validate(9692693868, 1256);
        }
    }
}
