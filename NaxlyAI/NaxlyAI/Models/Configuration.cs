using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Table("Configuration")]
    public partial class Configuration
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(100)]
        public string Logo { get; set; }
        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [StringLength(150)]
        public string Slogan { get; set; }
        [StringLength(400)]
        public string Description { get; set; }
        [StringLength(100)]
        public string SecondLogo { get; set; }
    }
}
