using Microsoft.AspNetCore.Mvc;

namespace PortfolioCore.Controllers
{
    public class ErrorController : Controller
    {
        [Route("ErrorPage/Error404")]
        public IActionResult Error404()
        {
            return View();
        }
    }
}
