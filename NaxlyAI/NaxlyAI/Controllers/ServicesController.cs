using Microsoft.AspNetCore.Mvc;
using NaxlyAI.Models;
using NaxlyAI.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Controllers
{
    public class ServicesController : Controller
    {
        NaxlyAIContext context = new NaxlyAIContext();
        public IActionResult Index()
        {
            AppServices appServices = new AppServices()
            {
                Services = context.Services,
                ServicesPage = context.ServicesPages.FirstOrDefault(),
                Testimonials = context.Testimonials,
                Industries = context.Industries
            };
            return View(appServices);
        }

        public IActionResult Service_Details(int id)
        {
            AppServiceDetails service = new AppServiceDetails()
            {
                Service = context.Services.Find(id),
                Services = context.Services,
                Testimonials = context.Testimonials,
                Projects = context.Projects.Take(4),
                Files = context.ServiceFiles.Where(f => f.ServiceId == id),
                ServiceAndIndustries = context.ServiceAndIndustries.Where(s => s.ServiceId == id),
                TechesAndService = context.TechAndServices.Where(s => s.ServiceId == id),
                Subservices = context.Subservices.Where(s => s.ServiceId == id),
                ServicesPage = context.ServicesPages.FirstOrDefault()
            };
            return View(service);
        }

        [HttpPost]
        public IActionResult Service_Details(UserMessage userMessage)
        {
            if (ModelState.IsValid)
            {
                userMessage.Date = DateTime.Now;
                context.UserMessages.Add(userMessage);
                context.SaveChanges();
                return View();
            }

            return View();
        }
    }
}
