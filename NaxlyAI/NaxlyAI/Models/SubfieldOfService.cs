using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Table("SubfieldOfService")]
    public partial class SubfieldOfService
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(200)]
        public string Name { get; set; }
        public int ServiceId { get; set; }

        [ForeignKey(nameof(ServiceId))]
        [InverseProperty("SubfieldOfServices")]
        public virtual Service Service { get; set; }
    }
}
