using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Bonus : Department
    {      
        public void Marketing_sales(float salary)
        {
            double bonus = salary + (0.2 * salary);
            Console.WriteLine("The salary is {0} ", bonus);
         
        }
        public void Production(float salary)
        {           
            double bonus = salary + (0.1 * salary);
            Console.WriteLine("The salary is {0} ", bonus);

        }

    }
    
    internal class salarytask
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Id { get; set; }
        public int Experience { get; set; }
        public string gender { get; set; }
        public int Salary { get; set; }

        public static void Main()
        {
            salarytask st = new salarytask()
            {
                Name = "Gowtham",
                Age = 31,
                Id = "sg237",
                Experience = 9,
                gender = "Male",
               //Salary = 50000

            };

            Console.WriteLine("Name {0},Age {1},ID {2},Experience {3},Gender {4}, ",st.Name,st.Age,st.Id,st.Experience,st.gender);
            Console.WriteLine("Enter the Salary");
            float salary = float.Parse(Console.ReadLine());

            Console.WriteLine("Please enter the Department");
            string deparment = Console.ReadLine();

            Bonus bonus = new Bonus();

            if (deparment == "sales" )
            {
                bonus.Marketing_sales(salary);
            }
            else
                bonus.Production(salary);
        }
        
    }
}
