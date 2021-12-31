using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Table("AboutCompany")]
    public partial class AboutCompany
    {
        [Key]
        public int Id { get; set; }
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
        [StringLength(100)]
        public string Picture1 { get; set; }
        [StringLength(100)]
        public string Picture2 { get; set; }
        [StringLength(100)]
        public string Picture3 { get; set; }
        [StringLength(100)]
        public string AboutOurHistory { get; set; }
        [StringLength(120)]
        public string WhyChooseUs { get; set; }
        [StringLength(100)]
        public string WhyChooseUsPicture1 { get; set; }
        [StringLength(100)]
        public string WhyChooseUsPicture2 { get; set; }
        [StringLength(150)]
        public string TeamMemberDesc { get; set; }
        [StringLength(100)]
        public string HomeCoverPicture { get; set; }
    }
}
