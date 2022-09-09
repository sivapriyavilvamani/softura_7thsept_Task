using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
{
    class Base
    {
        public void Add(int num1, int num2)
        {
            Console.WriteLine("The sum is {0}", num1 + num2);
        }
        public void sub(int num1, int num2)
        {
            Console.WriteLine("The sub is {0}", num1 - num2);
        }

    }
    class Derived : Base
    {
       
        public void Multiply(int num1, int num2)
        {
            Console.WriteLine("The Multiple is {0}", num1 * num2);
        }
        public void Div(int num1, int num2)
        {
            Console.WriteLine("The div {0}", num1 / num2);
        }

    }
    internal class OperationsTask
    {
   
        public static void Main()
        {
            Derived dobj = new Derived();
            dobj.Add(56,87);
            dobj.sub(56, 25);
            dobj.Multiply(25, 54);
            dobj.Div(89745, 5);

        }

    }

}

