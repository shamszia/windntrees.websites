using System;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Linq;
using System.Text;
using Application.Core;

namespace DataAccess.Core.Models
{
    public partial class LocalAppContext : ApplicationContext
    {
        private string ConnectionString { get; set; }
        public LocalAppContext(string connectionString)
        {
            this.ConnectionString = connectionString;
        }
        public LocalAppContext()
        {
            
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer(Startup.Configuration.GetConnectionString("ApplicationConnection"));
                base.OnConfiguring(optionsBuilder);
            }
        }
    }
}
