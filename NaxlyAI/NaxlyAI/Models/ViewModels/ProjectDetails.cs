using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Models.ViewModels
{
    public class ProjectDetails
    {
        public string ClientName { get; set; }
        public string Name { get; set; }
        public string PageHeader { get; set; }
        public string IndustyName { get; set; }
        public int TimePeriod { get; set; }
        public string Website { get; set; }
        public string Header { get; set; }
        public string Description { get; set; }
        public string Challenge { get; set; }
        public string Solution { get; set; }
        public string CoverPicture { get; set; }
        public string PagePicture { get; set; }
        public string ProcessDescription { get; set; }
        public string ResultDescription { get; set; }
        public ICollection<string> ProjectMembers { get; set; }
        public ICollection<string> ProjectTeches { get; set; }
    }
}
