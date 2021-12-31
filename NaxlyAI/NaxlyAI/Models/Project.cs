using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Table("Project")]
    public partial class Project
    {
        public Project()
        {
            ProjectAndMembers = new HashSet<ProjectAndMember>();
            ProjectAndTeches = new HashSet<ProjectAndTech>();
            StepOfProjects = new HashSet<StepOfProject>();
        }

        [Key]
        public int Id { get; set; }
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
        [Required]
        [StringLength(100)]
        public string CoverPicture { get; set; }
        [StringLength(100)]
        public string PagePicture { get; set; }
        [StringLength(500)]
        public string ProcessDescription { get; set; }
        [StringLength(500)]
        public string ResultDescription { get; set; }

        [ForeignKey(nameof(ClientId))]
        [InverseProperty("Projects")]
        public virtual Client Client { get; set; }
        [ForeignKey(nameof(IndustyId))]
        [InverseProperty(nameof(Industry.Projects))]
        public virtual Industry Industy { get; set; }
        [InverseProperty(nameof(ProjectAndMember.Project))]
        public virtual ICollection<ProjectAndMember> ProjectAndMembers { get; set; }
        [InverseProperty(nameof(ProjectAndTech.Project))]
        public virtual ICollection<ProjectAndTech> ProjectAndTeches { get; set; }
        [InverseProperty(nameof(StepOfProject.Project))]
        public virtual ICollection<StepOfProject> StepOfProjects { get; set; }
    }
}
