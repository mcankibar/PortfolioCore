using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Controllers
{
    public class TestController : Controller
    {
        [Route("/")]
        public IActionResult Index()
        {
            return View();
        }
    }
}
