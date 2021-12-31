using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Table("ServiceAndIndustry")]
    public partial class ServiceAndIndustry
    {
        [Key]
        public int Id { get; set; }
        public int ServiceId { get; set; }
        public int IndustryId { get; set; }

        [ForeignKey(nameof(IndustryId))]
        [InverseProperty("ServiceAndIndustries")]
        public virtual Industry Industry { get; set; }
        [ForeignKey(nameof(ServiceId))]
        [InverseProperty("ServiceAndIndustries")]
        public virtual Service Service { get; set; }
    }
}
