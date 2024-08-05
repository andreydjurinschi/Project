using LeaveManagementSystem.Web.Models;
using Microsoft.AspNetCore.Mvc;

namespace LeaveManagementSystem.Web.Controllers
{
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            var person = new TestViewModel
            {
                Name = "Andrey",
                Age = 20,
                Description = "2 grade Student",
                DateofBirth = new DateTime(2004, 07, 09, 06, 15, 30),
            };

            return View(person);
        }
    }
}
