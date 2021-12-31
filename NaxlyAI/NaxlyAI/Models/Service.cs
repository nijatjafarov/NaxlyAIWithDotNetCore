using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Table("Service")]
    public partial class Service
    {
        public Service()
        {
            ServiceAndIndustries = new HashSet<ServiceAndIndustry>();
            ServiceFiles = new HashSet<ServiceFile>();
            SubfieldOfServices = new HashSet<SubfieldOfService>();
            Subservices = new HashSet<Subservice>();
            TechAndServices = new HashSet<TechAndService>();
        }

        [Key]
        public int Id { get; set; }
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
        [StringLength(100)]
        public string FirstPicture { get; set; }
        [StringLength(100)]
        public string SubservicesHeader { get; set; }
        public string SubservicesDescription { get; set; }
        [StringLength(100)]
        public string TechnologiesHeader { get; set; }
        [StringLength(200)]
        public string TechnologiesDescription { get; set; }
        [StringLength(100)]
        public string SecondPicture { get; set; }
        [StringLength(100)]
        public string ApplicationHeader { get; set; }
        [StringLength(500)]
        public string ApplicationDescription { get; set; }
        [Required]
        [StringLength(100)]
        public string ProjectsHeader { get; set; }
        [StringLength(100)]
        public string CoverPicture { get; set; }
        [StringLength(50)]
        public string Icon { get; set; }
        [StringLength(100)]
        public string ContactHeader { get; set; }
        [StringLength(500)]
        public string ContactDescription { get; set; }

        [InverseProperty(nameof(ServiceAndIndustry.Service))]
        public virtual ICollection<ServiceAndIndustry> ServiceAndIndustries { get; set; }
        [InverseProperty(nameof(ServiceFile.Service))]
        public virtual ICollection<ServiceFile> ServiceFiles { get; set; }
        [InverseProperty(nameof(SubfieldOfService.Service))]
        public virtual ICollection<SubfieldOfService> SubfieldOfServices { get; set; }
        [InverseProperty(nameof(Subservice.Service))]
        public virtual ICollection<Subservice> Subservices { get; set; }
        [InverseProperty(nameof(TechAndService.Service))]
        public virtual ICollection<TechAndService> TechAndServices { get; set; }
    }
}
