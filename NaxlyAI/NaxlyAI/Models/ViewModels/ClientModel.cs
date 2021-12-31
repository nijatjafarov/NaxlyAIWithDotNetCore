using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Models.ViewModels
{
    public class ClientModel
    {
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public IFormFile Logo { get; set; }
        public string Url { get; set; }
    }
}
