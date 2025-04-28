using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultPortfolioComponentPartial : ViewComponent
    {
        public IViewComponentResult Invoke()
        {

            return View();
        }

    }
}
