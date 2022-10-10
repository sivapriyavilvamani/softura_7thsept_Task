namespace EmploeeTask1.Models
{
    public class Employee
    {
       
            public int Id { get; set; }
            public string FirstName { get; set; }

            public string LastName { get; set; }

            public string Gender { get; set; }


            public static List<Employee> GetAllEmployee()

            {
                List<Employee> employee = new()
        {
        new Employee() { Id=1, FirstName= "Sivapriya", LastName="Vilvamani",Gender="Female" },
        new Employee()  { Id=2, FirstName= "Lavanya", LastName="Sivakumar",Gender="Female" },
        new Employee()  { Id=3, FirstName= "Fahad", LastName="Fasil",Gender="Male" },
        new Employee()  { Id=4, FirstName= "Kamal", LastName="Hassan",Gender="Male" } ,
        new Employee() { Id=5, FirstName= "Ramya", LastName="Vilvamani", Gender="Female" }

        };

                return employee;
            }

            public static Employee GetEmployeeInfo()
            {
                Employee emp = new Employee { Id = 1, FirstName = "Rekha", LastName = "Vikram", Gender = "Female" };
                return emp;

            }
        }
    }

