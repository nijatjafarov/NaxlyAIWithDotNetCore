using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Table("Client")]
    public partial class Client
    {
        public Client()
        {
            Projects = new HashSet<Project>();
        }

        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(70)]
        public string Logo { get; set; }
        public string Url { get; set; }

        [InverseProperty(nameof(Project.Client))]
        public virtual ICollection<Project> Projects { get; set; }
    }
}
