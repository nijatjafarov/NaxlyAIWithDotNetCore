using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Models.ViewModels
{
    public class AppAbout
    {
        public AboutCompany AboutPage { get; set; }
        public IEnumerable<StepOfHistory> StepsOfHistory { get; set; }
        public IEnumerable<ReasonForChoosingU> reasonsForChoosingUs { get; set; }
        public IEnumerable<Testimonial> Testimonials { get; set; }
        public IEnumerable<TeamMember> TeamMembers { get; set; }
    }
}
