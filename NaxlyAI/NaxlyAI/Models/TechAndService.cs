using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Table("TechAndService")]
    public partial class TechAndService
    {
        [Key]
        public int Id { get; set; }
        public int TechId { get; set; }
        public int ServiceId { get; set; }
        public bool ShowPicture { get; set; }

        [ForeignKey(nameof(ServiceId))]
        [InverseProperty("TechAndServices")]
        public virtual Service Service { get; set; }
        [ForeignKey(nameof(TechId))]
        [InverseProperty(nameof(Technology.TechAndServices))]
        public virtual Technology Tech { get; set; }
    }
}
