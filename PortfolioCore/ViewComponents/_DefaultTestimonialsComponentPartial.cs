using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultTestimonialsComponentPartial: ViewComponent
    {

        PortfolioContext portfolioContext = new PortfolioContext();

        public IViewComponentResult Invoke()
        {
            var testimonials = portfolioContext.Testimonials.ToList();
            return View(testimonials);
        }
    }
}
