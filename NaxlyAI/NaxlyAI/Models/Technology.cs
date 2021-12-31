using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Table("Technology")]
    public partial class Technology
    {
        public Technology()
        {
            ProjectAndTeches = new HashSet<ProjectAndTech>();
            TechAndServices = new HashSet<TechAndService>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Picture { get; set; }

        [InverseProperty(nameof(ProjectAndTech.Tech))]
        public virtual ICollection<ProjectAndTech> ProjectAndTeches { get; set; }
        [InverseProperty(nameof(TechAndService.Tech))]
        public virtual ICollection<TechAndService> TechAndServices { get; set; }
    }
}
