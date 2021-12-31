using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Table("ProjectAndTech")]
    public partial class ProjectAndTech
    {
        [Key]
        public int Id { get; set; }
        public int ProjectId { get; set; }
        public int TechId { get; set; }

        [ForeignKey(nameof(ProjectId))]
        [InverseProperty("ProjectAndTeches")]
        public virtual Project Project { get; set; }
        [ForeignKey(nameof(TechId))]
        [InverseProperty(nameof(Technology.ProjectAndTeches))]
        public virtual Technology Tech { get; set; }
    }
}
