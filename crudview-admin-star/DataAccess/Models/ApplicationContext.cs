using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace DataAccess.Core.Models
{
    public partial class ApplicationContext : DbContext
    {
        public ApplicationContext()
        {
        }

        public ApplicationContext(DbContextOptions<ApplicationContext> options)
            : base(options)
        {
        }

        public virtual DbSet<ActivityHistory> ActivityHistories { get; set; }
        public virtual DbSet<Advertisement> Advertisements { get; set; }
        public virtual DbSet<AdvertisementLocation> AdvertisementLocations { get; set; }
        public virtual DbSet<AdvertisementPage> AdvertisementPages { get; set; }
        public virtual DbSet<Category> Categories { get; set; }
        public virtual DbSet<Color> Colors { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyType> CompanyTypes { get; set; }
        public virtual DbSet<Manufacturer> Manufacturers { get; set; }
        public virtual DbSet<Product> Products { get; set; }
        public virtual DbSet<ProductFeature> ProductFeatures { get; set; }
        public virtual DbSet<Reference> References { get; set; }
        public virtual DbSet<Unit> Units { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ActivityHistory>(entity =>
            {
                entity.Property(e => e.Uid).ValueGeneratedNever();

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Advertisement>(entity =>
            {
                entity.Property(e => e.Uid).ValueGeneratedNever();

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<AdvertisementLocation>(entity =>
            {
                entity.Property(e => e.Uid).ValueGeneratedNever();

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<AdvertisementPage>(entity =>
            {
                entity.Property(e => e.Uid).ValueGeneratedNever();

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Category>(entity =>
            {
                entity.Property(e => e.Uid).ValueGeneratedNever();

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Color>(entity =>
            {
                entity.Property(e => e.Uid).ValueGeneratedNever();

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.Property(e => e.Uid).ValueGeneratedNever();
            });

            modelBuilder.Entity<CompanyType>(entity =>
            {
                entity.Property(e => e.Uid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Manufacturer>(entity =>
            {
                entity.Property(e => e.Uid).ValueGeneratedNever();

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<Product>(entity =>
            {
                entity.Property(e => e.Uid).ValueGeneratedNever();

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            modelBuilder.Entity<ProductFeature>(entity =>
            {
                entity.Property(e => e.Uid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Reference>(entity =>
            {
                entity.Property(e => e.Uid).ValueGeneratedNever();
            });

            modelBuilder.Entity<Unit>(entity =>
            {
                entity.Property(e => e.Uid).ValueGeneratedNever();

                entity.Property(e => e.RowVersion)
                    .IsRowVersion()
                    .IsConcurrencyToken();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
