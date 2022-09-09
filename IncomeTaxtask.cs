using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
  class Vat
    {
        public void calculateTax(double num1)
        {
            Console.WriteLine("The VAT need to pay is Rs {0}", num1 * 0.2);
        }

    }
    class Gst : Vat
    {
        public new void calculateTax(double num1)  
        {          
            Console.WriteLine("The Gst need to pay is Rs {0}", num1 * 0.12);
        }

    }
    internal class IncomeTaxtask
    {
        public static void Main()
        {
            Gst gst = new Gst();
            // GST Cal
            gst.calculateTax(10.1);

            // VAT Cal
            Vat vat = new Gst();
            vat.calculateTax(10.1);
           
        }
    }
}
