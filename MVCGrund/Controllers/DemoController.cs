using Microsoft.AspNetCore.Mvc;

namespace MVCGrund.Controllers
{
    public class DemoController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
