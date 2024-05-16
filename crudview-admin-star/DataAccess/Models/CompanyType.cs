using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Core.Models
{
    [Table("CompanyType")]
    public partial class CompanyType
    {
        [Key]
        [Column("UID")]
        public Guid Uid { get; set; }
        [StringLength(255)]
        public string Description { get; set; }
        [Required]
        [StringLength(100)]
        public string Name { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
