using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Models.ViewModels
{
    public class EditAbout
    {
        [Required]
        [StringLength(40)]
        public string PageHeader { get; set; }
        [StringLength(150)]
        public string Slogan { get; set; }
        [Required]
        [StringLength(300)]
        public string Description { get; set; }
        [StringLength(70)]
        public string VideoTitle { get; set; }
        public string VideoUrl { get; set; }
        public int? FoundationYear { get; set; }
        public IFormFile Picture1 { get; set; }
        public IFormFile Picture2 { get; set; }
        public IFormFile Picture3 { get; set; }
        [StringLength(100)]
        public string AboutOurHistory { get; set; }
        [StringLength(120)]
        public string WhyChooseUs { get; set; }
        public IFormFile WhyChooseUsPicture1 { get; set; }
        public IFormFile WhyChooseUsPicture2 { get; set; }
        [StringLength(150)]
        public string TeamMemberDesc { get; set; }
        public IFormFile HomeCoverPicture { get; set; }
    }
}
