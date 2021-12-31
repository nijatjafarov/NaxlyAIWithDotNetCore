using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Table("Industry")]
    public partial class Industry
    {
        public Industry()
        {
            Projects = new HashSet<Project>();
            ServiceAndIndustries = new HashSet<ServiceAndIndustry>();
        }

        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Icon { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(300)]
        public string Description { get; set; }

        [InverseProperty(nameof(Project.Industy))]
        public virtual ICollection<Project> Projects { get; set; }
        [InverseProperty(nameof(ServiceAndIndustry.Industry))]
        public virtual ICollection<ServiceAndIndustry> ServiceAndIndustries { get; set; }
    }
}
