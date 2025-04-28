using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultFooterComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.summary = context.Abouts.First().Summary;
            var values = context.SocialMedias.ToList();
            return View(values);
        }
    }
    
}
