﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Table("SocialMediaOfCompany")]
    public partial class SocialMediaOfCompany
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        [StringLength(50)]
        public string Icon { get; set; }
        [Required]
        public string Url { get; set; }
    }
}
