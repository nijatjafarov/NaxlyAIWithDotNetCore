using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Table("SocialMediaAccountOfMember")]
    public partial class SocialMediaAccountOfMember
    {
        [Key]
        public int Id { get; set; }
        public int MemberId { get; set; }
        public int SocialMediaId { get; set; }
        [Required]
        public string Url { get; set; }

        [ForeignKey(nameof(MemberId))]
        [InverseProperty(nameof(TeamMember.SocialMediaAccountOfMembers))]
        public virtual TeamMember Member { get; set; }
        [ForeignKey(nameof(SocialMediaId))]
        [InverseProperty(nameof(SocialMedium.SocialMediaAccountOfMembers))]
        public virtual SocialMedium SocialMedia { get; set; }
    }
}
