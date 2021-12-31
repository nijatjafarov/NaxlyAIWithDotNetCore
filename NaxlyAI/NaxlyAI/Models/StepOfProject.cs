using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Table("StepOfProject")]
    public partial class StepOfProject
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(500)]
        public string Description { get; set; }
        [Required]
        [StringLength(100)]
        public string Picture { get; set; }
        public int ProjectId { get; set; }

        [ForeignKey(nameof(ProjectId))]
        [InverseProperty("StepOfProjects")]
        public virtual Project Project { get; set; }
    }
}
