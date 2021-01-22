using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

#nullable disable

namespace SubscriberSystem.Models
{
    public partial class SubscriberDBContext : DbContext
    {
        public SubscriberDBContext()
        {
        }

        public SubscriberDBContext(DbContextOptions<SubscriberDBContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Subscriber> Subscribers { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Subscriber>(entity =>
            {
                entity.HasKey(e => e.Id)
                    .HasName("PK_tbl_subscribers");

                entity.ToTable("tbl_subscriber");

                entity.Property(e => e.Id).HasColumnName("sub_id");

                entity.Property(e => e.Adress)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("sub_adress");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("sub_city");

                entity.Property(e => e.FirstName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("sub_firstName");

                entity.Property(e => e.LastName)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("sub_lastName");

                entity.Property(e => e.PersonNo)
                    .IsRequired()
                    .HasMaxLength(100)
                    .HasColumnName("sub_personNo");

                entity.Property(e => e.ZipCode)
                    .HasColumnName("sub_zipCode");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
