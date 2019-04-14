using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace ImportExample.Models
{
    public partial class citiesContext : DbContext
    {
        public citiesContext()
        {
        }

        public citiesContext(DbContextOptions<citiesContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Cities> Cities { get; set; }
        public virtual DbSet<Facts> Facts { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=ms-sql-9.in-solve.ru;Database=1gb_academics;Trusted_Connection=False;User Id=1gb_elizarovsa;Password=za5d8f88aa");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("ProductVersion", "2.2.4-servicing-10062");

            modelBuilder.Entity<Cities>(entity =>
            {
                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasMaxLength(1024);
            });

            modelBuilder.Entity<Facts>(entity =>
            {
                entity.Property(e => e.Date).HasColumnType("datetime");

                entity.HasOne(d => d.City)
                    .WithMany(p => p.Facts)
                    .HasForeignKey(d => d.CityId)
                    .HasConstraintName("FK_dbo.Facts_dbo.Cities_CityId");
            });
        }
    }
}
