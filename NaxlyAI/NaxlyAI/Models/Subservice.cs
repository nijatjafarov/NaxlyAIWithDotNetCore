using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Table("Subservice")]
    public partial class Subservice
    {
        [Key]
        public int Id { get; set; }
        [StringLength(50)]
        public string Icon { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [Required]
        [StringLength(150)]
        public string Description { get; set; }
        [StringLength(50)]
        public string Type { get; set; }
        [Required]
        public string Url { get; set; }
        public int ServiceId { get; set; }

        [ForeignKey(nameof(ServiceId))]
        [InverseProperty("Subservices")]
        public virtual Service Service { get; set; }
    }
}
