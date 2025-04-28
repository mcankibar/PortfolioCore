using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class ExperienceController : Controller
    {
        PortfolioContext context = new PortfolioContext();
        public IActionResult ExperienceList()
        {
            var values = context.Experiences.ToList();
            return View(values);
        }

       

        [HttpGet]

        public IActionResult CreateExperience()
        {
            var values = context.Experiences.ToList();
            return View();
        }


        [HttpPost]

        public IActionResult CreateExperience(Experience experience)
        {
            context.Experiences.Add(experience);
            context.SaveChanges();

            return RedirectToAction(nameof(ExperienceList));
        }


        

        public IActionResult DeleteExperience(int id)
        {
            var targetExperience = context.Experiences.Find(id);

            
            
            context.Experiences.Remove(targetExperience);
            context.SaveChanges();
            

            return RedirectToAction(nameof(ExperienceList));
        }

        [HttpGet]

        public IActionResult UpdateExperience(int id) {
            var value = context.Experiences.Find(id);
            return View(value);
        }


        [HttpPost]

        public IActionResult UpdateExperience(Experience e)
        {
            context.Experiences.Update(e);
            context.SaveChanges();
            return RedirectToAction(nameof(ExperienceList));
        }
    }
}
