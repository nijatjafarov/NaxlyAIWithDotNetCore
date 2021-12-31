using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace NaxlyAI.Models
{
    [Index(nameof(Icon), Name = "UQ__ReasonFo__B03D5134B2BD240E", IsUnique = true)]
    [Index(nameof(Header), Name = "UQ__ReasonFo__EB3211CECF7247E8", IsUnique = true)]
    public partial class ReasonForChoosingU
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(250)]
        public string Icon { get; set; }
        [Required]
        [StringLength(100)]
        public string Header { get; set; }
        [Required]
        [StringLength(300)]
        public string Descrioption { get; set; }
    }
}
