using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultContactComponentPartial : ViewComponent
    {
         PortfolioContext portfolioContext = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            var values = portfolioContext.Contacts.FirstOrDefault();
            return View(values);
        }
    }
    
}
