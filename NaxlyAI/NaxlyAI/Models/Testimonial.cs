using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Table("Testimonial")]
    public partial class Testimonial
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [Column(TypeName = "text")]
        public string Photo { get; set; }
        [Required]
        [StringLength(150)]
        public string Review { get; set; }
        [Required]
        [StringLength(50)]
        public string Fullname { get; set; }
        [Required]
        [StringLength(70)]
        public string Designation { get; set; }
        public int NumberOfStars { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime? Date { get; set; }
    }
}
