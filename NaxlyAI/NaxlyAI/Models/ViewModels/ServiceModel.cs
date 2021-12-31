using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Models.ViewModels
{
    public class ServiceModel
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [Required]
        [StringLength(150)]
        public string PageHeader { get; set; }
        [StringLength(60)]
        public string Intro { get; set; }
        [StringLength(300)]
        public string Description { get; set; }
        public string StartYourProjectUrl { get; set; }
        public IFormFile FirstPicture { get; set; }
        [StringLength(100)]
        public string SubservicesHeader { get; set; }
        public string SubservicesDescription { get; set; }
        [StringLength(100)]
        public string TechnologiesHeader { get; set; }
        [StringLength(200)]
        public string TechnologiesDescription { get; set; }
        public IFormFile SecondPicture { get; set; }
        [StringLength(100)]
        public string ApplicationHeader { get; set; }
        [StringLength(500)]
        public string ApplicationDescription { get; set; }
        [Required]
        [StringLength(100)]
        public string ProjectsHeader { get; set; }
        public IFormFile CoverPicture { get; set; }
        [StringLength(50)]
        public string Icon { get; set; }
        [StringLength(100)]
        public string ContactHeader { get; set; }
        [StringLength(500)]
        public string ContactDescription { get; set; }
        public IEnumerable<IFormFile> Files { get; set; }
        public IEnumerable<int> IndustryIds { get; set; }
        public IEnumerable<int> TechIds { get; set; }
        public string SubfieldString { get; set; }
    }
}
