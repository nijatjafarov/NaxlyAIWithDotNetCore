using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Table("ServicesPage")]
    public partial class ServicesPage
    {
        [Key]
        public int Id { get; set; }
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
        [StringLength(100)]
        public string AwardPicture { get; set; }
        [StringLength(150)]
        public string AwardDescription { get; set; }
    }
}
