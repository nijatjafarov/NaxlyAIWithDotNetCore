using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Models.ViewModels
{
    public class AdminCompany
    {
        public AboutCompany AboutPage { get; set; }
        public Contact ContactPage { get; set; }
        public IEnumerable<StepOfHistory> StepsOfHistory { get; set; }
        public IEnumerable<ReasonForChoosingU> ReasonsToChooseUs { get; set; }
        public IEnumerable<SocialMediaOfCompany> SocialMediasOfCompany { get; set; }
    }
}
