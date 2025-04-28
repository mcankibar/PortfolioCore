using Microsoft.AspNetCore.Mvc;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class SkillController : Controller
    {
         PortfolioContext context = new PortfolioContext();
        public IActionResult SkillList()
        {

            var values = context.Skills.ToList();

            return View(values);
        }

        public IActionResult CreateSkill()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateSkill(Skill skill)
        {
            context.Skills.Add(skill);
            context.SaveChanges();
            return RedirectToAction(nameof(SkillList));
            
        }

        public IActionResult DeleteSkill(int id)
        {
            var skill = context.Skills.Find(id);
            context.Skills.Remove(skill);
            context.SaveChanges();
            return RedirectToAction(nameof(SkillList));

        }

        public IActionResult UpdateSkill(int id)
        {
            var skill = context.Skills.Find(id);
           
            return View(skill);

        }

        [HttpPost]
        public IActionResult UpdateSkill(Skill skill)
        {
            context.Skills.Update(skill);
            context.SaveChanges();
            return RedirectToAction(nameof(SkillList));

        }
    }
}
