using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Models.ViewModels
{
    public class TestimonialModel
    {
        public IFormFile Photo { get; set; }
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
    }
}
