using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Models.ViewModels
{
    public class ServiceDetails
    {
        public string Name { get; set; }
        public string PageHeader { get; set; }
        public string Intro { get; set; }
        public string Description { get; set; }
        public string StartYourProjectUrl { get; set; }
        public string FirstPicture { get; set; }
        public string SubservicesHeader { get; set; }
        public string SubservicesDescription { get; set; }
        public string TechnologiesHeader { get; set; }
        public string TechnologiesDescription { get; set; }
        public string SecondPicture { get; set; }
        public string ApplicationHeader { get; set; }
        public string ApplicationDescription { get; set; }
        public string ProjectsHeader { get; set; }
        public string CoverPicture { get; set; }
        public string Icon { get; set; }
        public string ContactHeader { get; set; }
        public string ContactDescription { get; set; }
        public IEnumerable<string> FileNames { get; set; }
        public IEnumerable<string> IndustryNames { get; set; }
        public IEnumerable<string> TechNames { get; set; }
        public IEnumerable<string> SubfieldNames { get; set; }
    }
}
