using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Table("TeamMember")]
    public partial class TeamMember
    {
        public TeamMember()
        {
            ProjectAndMembers = new HashSet<ProjectAndMember>();
            SocialMediaAccountOfMembers = new HashSet<SocialMediaAccountOfMember>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Photo { get; set; }
        [Required]
        [StringLength(50)]
        public string Fullname { get; set; }
        [Required]
        [StringLength(70)]
        public string Designation { get; set; }
        [Required]
        [StringLength(300)]
        public string Email { get; set; }

        [InverseProperty(nameof(ProjectAndMember.Member))]
        public virtual ICollection<ProjectAndMember> ProjectAndMembers { get; set; }
        [InverseProperty(nameof(SocialMediaAccountOfMember.Member))]
        public virtual ICollection<SocialMediaAccountOfMember> SocialMediaAccountOfMembers { get; set; }
    }
}
