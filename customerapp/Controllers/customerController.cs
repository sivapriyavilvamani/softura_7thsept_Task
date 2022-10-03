using customerapp.model;
using Microsoft.AspNetCore.Mvc;

namespace customerapp.Controllers
{
    public class customerController : Controller
    {
        public string Index()
        {
            return "Customer";
        }
        public IActionResult customerinfo()
        {
            List<customerClass> licus = customerClass.GetAllcustomer();
            return View(licus);
        }
        //public IActionResult Index()
        //{
        //    return View();
        //}
    }
}
