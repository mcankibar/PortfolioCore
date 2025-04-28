using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.ViewComponents
{
    public class _DefaultStatisticsComponentPartial : ViewComponent
    {
        PortfolioContext context = new PortfolioContext();
        public IViewComponentResult Invoke()
        {
            ViewBag.ReferansCount = context.Portfolios.Count();
            ViewBag.PortfolioCount = context.Portfolios.Count();
            ViewBag.SkillCount = context.Skills.Count();

            return View();
        }
    }

}
