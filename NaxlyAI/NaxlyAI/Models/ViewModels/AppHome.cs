using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Models.ViewModels
{
    public class AppHome
    {
        public HomePage HomePage { get; set; }
        public AboutCompany AboutPage { get; set; }
        public Configuration Configuration { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<ReasonForChoosingU> ReasonsForChoosingUs { get; set; }
        public IEnumerable<Project> Projects { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
        public IEnumerable<Client> ClientsFirstRaw { get; set; }
        public IEnumerable<Client> ClientsSecondRaw { get; set; }
    }
}
