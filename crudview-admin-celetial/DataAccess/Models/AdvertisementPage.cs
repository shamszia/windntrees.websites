﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Core.Models
{
    [Table("AdvertisementPage")]
    public partial class AdvertisementPage
    {
        [Key]
        [Column("UID")]
        public Guid Uid { get; set; }
        [Required]
        [StringLength(255)]
        public string Description { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public byte[] RowVersion { get; set; }
    }
}
