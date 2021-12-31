using Microsoft.AspNetCore.Mvc;
using NaxlyAI.Models;
using NaxlyAI.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Controllers
{
    public class AboutController : Controller
    {
        NaxlyAIContext context = new NaxlyAIContext();
        public IActionResult Index()
        {
            AppAbout about = new AppAbout()
            {
                AboutPage = context.AboutCompanies.FirstOrDefault(),
                StepsOfHistory = context.StepOfHistories,
                reasonsForChoosingUs = context.ReasonForChoosingUs.Take(3),
                Testimonials = context.Testimonials,
                TeamMembers = context.TeamMembers.Take(4)
            };
            return View(about);
        }
    }
}
