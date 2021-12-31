using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Models.ViewModels
{
    public class AppServices
    {
        public IEnumerable<Service> Services { get; set; }
        public ServicesPage ServicesPage { get; set; }
        public IEnumerable<Industry> Industries { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
    }
}
