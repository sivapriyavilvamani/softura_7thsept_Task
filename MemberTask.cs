using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2

{
   
    internal class MemberTask
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public void Member(string Name, int age)
        {
            Console.WriteLine("The name is {0},the age is{1}",Name,age);
        }
        public static void Main()
        {
            MemberTask task = new MemberTask()
            {
                Name = "priya",
                Age = 28

            };
            Console.WriteLine("the Name={0},age={1}", task.Name, task.Age);


            MemberTask memberTask = new MemberTask();
            memberTask.Member("priya", 28);

            //Dictionary<string, int> dic = new Dictionary<string, int>();
            //dic.Add("Priya", 28);
            //foreach (object obj in dic)
            //    Console.WriteLine(obj.ToString());



        }


    }
}
