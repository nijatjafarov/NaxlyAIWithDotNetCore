using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Models.ViewModels
{
    public class AdminProjects
    {
        public IEnumerable<Project> Projects { get; set; }
        public IEnumerable<StepOfProject> StepsOfProjects { get; set; }
    }
}
