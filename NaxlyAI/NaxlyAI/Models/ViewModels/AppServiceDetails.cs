using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Models.ViewModels
{
    public class AppServiceDetails
    {
        public Service Service { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public ServicesPage ServicesPage { get; set; }
        public IEnumerable<ServiceAndIndustry> ServiceAndIndustries { get; set; }
        public IEnumerable<Subservice> Subservices { get; set; }
        public IEnumerable<TechAndService> TechesAndService { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
        public IEnumerable<Project> Projects { get; set; }
        public IEnumerable<ServiceFile> Files { get; set; }
    }
}
