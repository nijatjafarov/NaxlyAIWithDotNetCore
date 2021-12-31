using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Table("UserMessage")]
    public partial class UserMessage
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(60)]
        public string Name { get; set; }
        [Required]
        [StringLength(300)]
        public string Email { get; set; }
        [StringLength(50)]
        public string Subject { get; set; }
        [Required]
        public string Message { get; set; }
        [Column(TypeName = "datetime")]
        public DateTime Date { get; set; }
    }
}
