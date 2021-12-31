using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Models.ViewModels
{
    public class AdminServices
    {
        public ServicesPage ServicesPage { get; set; }
        public IEnumerable<Service> Services { get; set; }
        public IEnumerable<SubfieldOfService> Subfields { get; set; }
        public IEnumerable<Subservice> Subservices { get; set; }
        public IEnumerable<ServiceFile> ServiceFiles { get; set; }
        public IEnumerable<Industry> Industries { get; set; }
        public IEnumerable<ServiceAndIndustry> ServicesAndIndustries { get; set; }
        public IEnumerable<Technology> Technologies { get; set; }
    }
}
