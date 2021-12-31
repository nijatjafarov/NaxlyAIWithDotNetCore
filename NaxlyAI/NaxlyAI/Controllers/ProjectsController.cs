using Microsoft.AspNetCore.Mvc;
using NaxlyAI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Controllers
{
    public class ProjectsController : Controller
    {
        NaxlyAIContext context = new NaxlyAIContext();
        public IActionResult Index()
        {
            var team = context.Projects;
            return View(team);
        }

        public IActionResult Project_Details(int id)
        {
            Project project = context.Projects.Find(id);

            return View(project);
        }
    }
}
