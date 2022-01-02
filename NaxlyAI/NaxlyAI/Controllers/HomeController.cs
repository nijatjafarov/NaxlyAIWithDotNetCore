using Microsoft.AspNetCore.Mvc;
using NaxlyAI.Models;
using NaxlyAI.Models.ViewModels;
//using NaxlyAI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Controllers
{
    public class HomeController : Controller
    {
        NaxlyAIContext context = new NaxlyAIContext();
        public IActionResult Index()
        {
            AppHome home = new AppHome()
            {
                HomePage = context.HomePages.FirstOrDefault(),
                AboutPage = context.AboutCompanies.FirstOrDefault(),
                Configuration = context.Configurations.FirstOrDefault(),
                Services = context.Services,
                ReasonsForChoosingUs = context.ReasonForChoosingUs.Take(2),
                Testimonials = context.Testimonials.Take(3),
                ClientsFirstRaw = context.Clients.Take(4),
                ClientsSecondRaw = context.Clients.Skip(4).Take(3),
                Projects = context.Projects
            };

            return View(home);
        }
    }
}
