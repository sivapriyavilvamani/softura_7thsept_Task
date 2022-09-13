using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace ConsoleApp2
{
    public class Employee
    {
        public int ID { get; set; }

        public string Name { get; set; }

        public int Age { get; set; }

        public string Gender { get; set; }
    }

    internal class EmployeeserialzeTask
    {
        public static void Main()
        {

            Employee emp = new Employee()
            {
                ID = 1233,
                Name = "Sivapriya",
                Age = 28,
                Gender = "Female"
            };
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(Employee));
            using (StreamWriter stream = new StreamWriter("employeeTask.xml"))
            {
                xmlSerializer.Serialize(stream, emp);
            }
            Console.WriteLine("the Name={0},age={1},Id={2},Gender={3}", emp.Name, emp.Age, emp.ID, emp.Gender);

        }
    }
}
