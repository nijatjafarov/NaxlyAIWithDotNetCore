using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Models.ViewModels
{
    public class ConfigurationModel
    {
        public IFormFile Logo { get; set; }
        [Required]
        [StringLength(20)]
        public string PhoneNumber { get; set; }
        [StringLength(150)]
        public string Slogan { get; set; }
        [StringLength(400)]
        public string Description { get; set; }
        public IFormFile SecondLogo { get; set; }
    }
}
