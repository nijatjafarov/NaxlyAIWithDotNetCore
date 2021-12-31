using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace NaxlyAI.Models.ViewModels
{
    public class EditContact
    {
        [Required]
        [StringLength(50)]
        public string PageHeader { get; set; }
        [Required]
        [StringLength(50)]
        public string InnerHeader { get; set; }
        [StringLength(150)]
        public string Slogan { get; set; }
        [Required]
        [StringLength(400)]
        public string Description { get; set; }
        [Required]
        [StringLength(40)]
        public string LocationHeader { get; set; }
        [Required]
        [StringLength(100)]
        public string LocationDesc { get; set; }
        [Required]
        [StringLength(200)]
        public string Address { get; set; }
        [Required]
        [StringLength(40)]
        public string PhoneHeader { get; set; }
        [Required]
        [StringLength(100)]
        public string PhoneDesc { get; set; }
        [Required]
        [StringLength(20)]
        public string PhoneNum { get; set; }
        [Required]
        [StringLength(60)]
        public string PhoneTime { get; set; }
        [Required]
        [StringLength(40)]
        public string EmailHeader { get; set; }
        [Required]
        [StringLength(100)]
        public string EmailDesc { get; set; }
        [Required]
        [StringLength(300)]
        public string Email1 { get; set; }
        [StringLength(300)]
        public string Email2 { get; set; }
        public IFormFile PagePicture { get; set; }
    }
}
