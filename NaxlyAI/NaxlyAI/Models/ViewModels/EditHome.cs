using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Models.ViewModels
{
    public class EditHome
    {
        [Display(Name = "First Picture")]
        public IFormFile FirstPicture { get; set; }
        [StringLength(150)]
        [Display(Name = "Services Description")]
        public string AboutServices { get; set; }
        [Display(Name = "Services Picture")]
        public IFormFile ServicesPicture { get; set; }
        [StringLength(150)]
        [Display(Name = "Projects Description")]
        public string AboutProjects { get; set; }
        [StringLength(150)]
        [Display(Name = "Work Process Description")]
        public string AboutWorkProcess { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "First Work Process Header")]
        public string WorkProcessHeader1 { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "First Work Process Description")]
        public string WorkProcessDesc1 { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Second Work Process Header")]
        public string WorkProcessHeader2 { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Second Work Process Description")]
        public string WorkProcessDesc2 { get; set; }
        [Required]
        [StringLength(50)]
        [Display(Name = "Third Work Process Header")]
        public string WorkProcessHeader3 { get; set; }
        [Required]
        [StringLength(100)]
        [Display(Name = "Third Work Process Description")]
        public string WorkProcessDesc3 { get; set; }
        [StringLength(100)]
        [Display(Name = "Why Choose Us Description")]
        public string AboutWhyChooseUs { get; set; }
        [Display(Name = "Why Choose Us Picture")]
        public IFormFile WhyChooseUsPicture { get; set; }
        [StringLength(100)]
        [Display(Name = "Client Description")]
        public string ClientDescription { get; set; }
    }
}
