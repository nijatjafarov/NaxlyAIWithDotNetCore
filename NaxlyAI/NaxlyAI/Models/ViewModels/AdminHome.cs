using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Models.ViewModels
{
    public class AdminHome
    {
        public HomePage HomePage { get; set; }
        public Configuration Configuration { get; set; }
        public IEnumerable<Client> Clients { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
        public IEnumerable<UserMessage> UserMessages { get; set; }
    }
}
