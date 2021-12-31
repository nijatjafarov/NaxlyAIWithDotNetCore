using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Table("ServiceFile")]
    public partial class ServiceFile
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public string Extention { get; set; }
        public int Size { get; set; }
        public int ServiceId { get; set; }

        [ForeignKey(nameof(ServiceId))]
        [InverseProperty("ServiceFiles")]
        public virtual Service Service { get; set; }
    }
}
