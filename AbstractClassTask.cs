using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp
    
{
    abstract class Operations
    {
        public abstract void Calculate(int num1,int num2);

    }
     class Add: Operations
        {
            public override void  Calculate(int num1,int num2)        
            {                
                Console.WriteLine("The sum of two numbers is {0}", num1 + num2);
            }
    }
    class sub : Operations
    {
        public override void Calculate(int num1, int num2)
        {
           Console.WriteLine("The difference of two numbers is {0}", num1 - num2);
        }
    }
    class Multiply : Operations
    {
        public override void Calculate(int num1, int num2)
        {
            Console.WriteLine("The Multiple of two numbers is {0}", num1 * num2);
        }
    }
    class divide : Operations
    {
        public override void Calculate(int num1, int num2)
        {
           Console.WriteLine("The division of two numbers is {0}", num1 / num2);
        }
    }
    internal class AbstractClassTask
    {
        public static void Main()
        {
            Add add = new Add();
            sub diff=new sub();
            Multiply multi = new Multiply();
            divide division = new divide();
            add.Calculate(25,65);
            diff.Calculate(25, 65);
            multi.Calculate(25, 65);
            division.Calculate(755, 5);

        }
    }
}
