using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PortfolioCore.Context;
using PortfolioCore.Entities;

namespace PortfolioCore.Controllers
{
    public class MessageController : Controller
    {
        PortfolioContext portfolioContext = new PortfolioContext();
        public IActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public IActionResult CreateMessage(Message message)
        {



            try
            {
                message.SendDate = DateTime.Now;
                message.IsRead = false;
                portfolioContext.Messages.Add(message);
                portfolioContext.SaveChanges();
                return Ok(new { status = "success", message = "Message sent successfully!" });
            }
            catch (Exception ex)
            {
                return BadRequest(new { status = "error", message = ex.Message });
            }
        }

        [HttpPost]
        public IActionResult DeleteMessage(int messageId)
        {

            if (messageId <= 0)
            {
                return BadRequest(new { status = "error", message = "Geçersiz mesaj ID." });
            }

            var message = portfolioContext.Messages.FirstOrDefault(m => m.MessageId == messageId);
            if (message == null)
            {
                return NotFound(new { status = "error", message = "Mesaj bulunamadı." });
            }

            try
            {
                portfolioContext.Messages.Remove(message);
                portfolioContext.SaveChanges();
                return RedirectToAction(nameof(GetMessages));
            }
            catch (Exception ex)
            {
                return RedirectToAction("Error404", "Error");
            }


        }


        public IActionResult GetMessages()
        {
            var messages = portfolioContext.Messages.ToList();
            return View(messages);
        }

        [HttpPost]
        public IActionResult ToggleReadStatus(int id)
        {
            var message = portfolioContext.Messages.Find(id);
            if (message == null)
            {
                return NotFound();
            }

            message.IsRead = !message.IsRead; // Tersine çevir
            portfolioContext.SaveChanges();
            return Ok();
        }
    }
}
