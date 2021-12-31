using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Table("ProjectAndMember")]
    public partial class ProjectAndMember
    {
        [Key]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int MemberId { get; set; }

        [ForeignKey(nameof(MemberId))]
        [InverseProperty(nameof(TeamMember.ProjectAndMembers))]
        public virtual TeamMember Member { get; set; }
        [ForeignKey(nameof(ProjectId))]
        [InverseProperty("ProjectAndMembers")]
        public virtual Project Project { get; set; }
    }
}
