using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Table("StepOfHistory")]
    [Index(nameof(Header), Name = "UQ__StepOfHi__EB3211CE7251FA53", IsUnique = true)]
    public partial class StepOfHistory
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Header { get; set; }
        public int Year { get; set; }
        [Required]
        [StringLength(200)]
        public string Description { get; set; }
    }
}
