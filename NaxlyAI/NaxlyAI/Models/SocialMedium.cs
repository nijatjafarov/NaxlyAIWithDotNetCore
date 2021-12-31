using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    public partial class SocialMedium
    {
        public SocialMedium()
        {
            SocialMediaAccountOfMembers = new HashSet<SocialMediaAccountOfMember>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(30)]
        public string Icon { get; set; }

        [InverseProperty(nameof(SocialMediaAccountOfMember.SocialMedia))]
        public virtual ICollection<SocialMediaAccountOfMember> SocialMediaAccountOfMembers { get; set; }
    }
}
