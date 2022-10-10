using Microsoft.AspNetCore.Mvc;
using EmploeeTask1.Models;


namespace EmploeeTask1.Controllers
{
    public class EmployeeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult EmployeeInfo()
        {
           Employee employee = Employee.GetEmployeeInfo();
            return View(employee);
        }
        public IActionResult allEmployeeInfo()
        {
            List<Employee> liemp = Employee.GetAllEmployee();
            return View(liemp);
        }
        public IActionResult Insert()
        {
            return View();
        }
    }
}
