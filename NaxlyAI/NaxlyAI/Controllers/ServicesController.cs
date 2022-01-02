using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using NaxlyAI.Models;
using NaxlyAI.Models.ViewModels;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Controllers
{
    public class ServicesController : Controller
    {
        NaxlyAIContext context = new NaxlyAIContext();
        IHostingEnvironment hostingEnvironment;
        public ServicesController(IHostingEnvironment _hostingEnvironment)
        {
            hostingEnvironment = _hostingEnvironment;
        }
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

            TempData["ServiceName"] = service.Service.Name;

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
        public FileResult DownloadFile(string file, string service)
        {
            string uploadsFolder = Path.Combine(hostingEnvironment.WebRootPath, "ServicesFiles");
            string serviceFolderPath = Path.Combine(uploadsFolder, service);
            string filePath = Path.Combine(serviceFolderPath, file);
            var myfile = System.IO.File.ReadAllBytes(filePath);
            return File(myfile, "application/force-download", file);
        }
    }
}
