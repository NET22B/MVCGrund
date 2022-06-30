using Microsoft.AspNetCore.Mvc;
using MVCGrund.Models;

namespace MVCGrund.Controllers
{
    public class HomeController : Controller
    {

        public HomeController()
        {

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy(/*string name, int salary*/ DemoModel viewModel)
        {
            //var name = viewModel.Name;
            //var salary = viewModel.Salary;

            var model = new DemoModel
            {
                Name = viewModel.Name,
                Salary = viewModel.Salary
            };

            return View(model);
        }

        [HttpGet]
        public IActionResult SendToPrivacy()
        {
            return View();
        }

        [HttpPost]
        public IActionResult SendToPrivacy(DemoModel viewModel)
        {
            var model = new DemoModel
            {
                Name = viewModel.Name,
                Salary = viewModel.Salary
            };

            return View(model);
        }



    }
}