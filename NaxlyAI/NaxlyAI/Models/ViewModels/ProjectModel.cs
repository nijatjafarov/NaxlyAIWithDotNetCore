using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Models.ViewModels
{
    public class ProjectModel
    {
        public int ClientId { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        [StringLength(200)]
        public string PageHeader { get; set; }
        public int IndustyId { get; set; }
        public int TimePeriod { get; set; }
        [StringLength(150)]
        public string Website { get; set; }
        [Required]
        [StringLength(150)]
        public string Header { get; set; }
        [StringLength(500)]
        public string Description { get; set; }
        [StringLength(200)]
        public string Challenge { get; set; }
        [StringLength(200)]
        public string Solution { get; set; }
        public IFormFile CoverPicture { get; set; }
        public IFormFile PagePicture { get; set; }
        [StringLength(500)]
        public string ProcessDescription { get; set; }
        [StringLength(500)]
        public string ResultDescription { get; set; }
        public ICollection<int> ProjectMembers { get; set; }
        public ICollection<int> ProjectTeches { get; set; }
    }
}
