using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;

namespace PortfolioCore.Controllers
{
    public class StatisticsController : Controller
    {
        PortfolioContext context = new PortfolioContext();  
        public IActionResult Index()
        {
            ViewBag.v0 = "İstatistikler";

            ViewBag.v1 = context.Skills.Count(); // Toplam Yetenek
            ViewBag.v2 = context.Skills.Sum(x => x.SkillValue); // Toplam Yetenek Puanı
            ViewBag.v3 = context.Skills.Where(x => x.SkillValue >= 70).Count(); // 70'ten Büyük Yetenek
            ViewBag.v4 = context.Skills.Average(x => x.SkillValue); // Ortalama Yetenek Değeri
            ViewBag.v5 = context.Experiences.Count(); // Toplam Deneyim
            ViewBag.v6 = context.Experiences.Where(x => x.SubTitle == "Developer").Count(); // Developer Başlıklı Deneyim
            ViewBag.v7 = context.Categories.Count(); // Toplam Kategori
            ViewBag.v8 = context.Services.Count(); // Toplam Hizmet
            ViewBag.v9 = context.Portfolios.Count(); // Toplam Proje
            ViewBag.v10 = context.Testimonials.Count(); // Toplam Referans

            return View();
        }
    }
}
