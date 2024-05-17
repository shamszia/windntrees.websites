using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Core.Models
{
    [Table("ActivityHistory")]
    public partial class ActivityHistory
    {
        [Key]
        [Column("UID")]
        public Guid Uid { get; set; }
        [StringLength(100)]
        public string Activity { get; set; }
        public DateTime? ActivityTime { get; set; }
        [Column("IPAddress")]
        public string Ipaddress { get; set; }
        [StringLength(2048)]
        public string Request { get; set; }
        public byte[] RowVersion { get; set; }
        [Column("UserID")]
        public string UserId { get; set; }
    }
}
