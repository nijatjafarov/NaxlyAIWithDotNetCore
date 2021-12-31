using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Table("HomePage")]
    public partial class HomePage
    {
        [Key]
        public int Id { get; set; }
        [StringLength(100)]
        public string FirstPicture { get; set; }
        [StringLength(150)]
        public string AboutServices { get; set; }
        [StringLength(100)]
        public string ServicesPicture { get; set; }
        [StringLength(150)]
        public string AboutProjects { get; set; }
        [StringLength(150)]
        public string AboutWorkProcess { get; set; }
        [Required]
        [StringLength(50)]
        public string WorkProcessHeader1 { get; set; }
        [Required]
        [StringLength(100)]
        public string WorkProcessDesc1 { get; set; }
        [Required]
        [StringLength(50)]
        public string WorkProcessHeader2 { get; set; }
        [Required]
        [StringLength(100)]
        public string WorkProcessDesc2 { get; set; }
        [Required]
        [StringLength(50)]
        public string WorkProcessHeader3 { get; set; }
        [Required]
        [StringLength(100)]
        public string WorkProcessDesc3 { get; set; }
        [StringLength(100)]
        public string AboutWhyChooseUs { get; set; }
        [StringLength(100)]
        public string WhyChooseUsPicture { get; set; }
        [StringLength(100)]
        public string ClientDescription { get; set; }
    }
}
