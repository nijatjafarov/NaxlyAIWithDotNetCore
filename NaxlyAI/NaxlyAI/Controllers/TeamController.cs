using Microsoft.AspNetCore.Mvc;
using NaxlyAI.Models;
using NaxlyAI.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Controllers
{
    public class TeamController : Controller
    {
        NaxlyAIContext context = new NaxlyAIContext();
        public IActionResult Index()
        {
            AppTeam team = new AppTeam()
            {
                About = context.AboutCompanies.FirstOrDefault(),
                Members = context.TeamMembers
            };
            return View(team);
        }
    }
}
