using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Models.ViewModels
{
    public class AppTeam
    {
        public AboutCompany About { get; set; }
        public IEnumerable<TeamMember> Members { get; set; }
    }
}
