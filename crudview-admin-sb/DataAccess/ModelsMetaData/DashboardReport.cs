using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Core.Models
{
    public class DashboardReport
    {
        public int Products { get; set; }
        public decimal Sales { get; set; }
        public decimal Discount { get; set; }
        public decimal ReceivedPayment { get; set; }
        public decimal DuePayment { get; set; }
    }
}
