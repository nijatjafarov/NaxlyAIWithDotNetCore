using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Models.ViewModels
{
    public class ServicesPageModel
    {
        [Required]
        [StringLength(40)]
        public string PageHeader { get; set; }
        [StringLength(100)]
        public string Explanation { get; set; }
        [StringLength(100)]
        public string ExplanationAboutIndustries { get; set; }
        public string VideoUrl { get; set; }
        [StringLength(40)]
        public string AwardText { get; set; }
        public IFormFile AwardPicture { get; set; }
        [StringLength(150)]
        public string AwardDescription { get; set; }
    }
}
