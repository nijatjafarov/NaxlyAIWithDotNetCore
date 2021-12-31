using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Models.ViewModels
{
    public class AdminTeam
    {
        public IEnumerable<TeamMember> TeamMembers { get; set; }
        public IEnumerable<SocialMedium> SocialMedias { get; set; }
        public IEnumerable<SocialMediaAccountOfMember> SMsOfMembers { get; set; }
    }
}
