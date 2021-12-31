using Microsoft.AspNetCore.Mvc;
using NaxlyAI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Controllers
{
    public class ContactController : Controller
    {
        NaxlyAIContext context = new NaxlyAIContext();
        public IActionResult Index()
        {

            return View(context.Contacts.FirstOrDefault());
        }

        [HttpPost]
        public IActionResult Index(UserMessage userMessage)
        {
            if (ModelState.IsValid)
            {
                userMessage.Date = DateTime.Now;
                context.UserMessages.Add(userMessage);
                context.SaveChanges();
                return View(context.Contacts.FirstOrDefault());
            }

            return View(context.Contacts.FirstOrDefault());
        }
    }
}
