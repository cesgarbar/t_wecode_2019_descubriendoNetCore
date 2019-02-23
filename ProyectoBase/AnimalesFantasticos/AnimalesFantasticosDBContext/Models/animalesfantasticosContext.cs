using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.Extensions.Configuration;

namespace AnimalesFantasticosDBContext.Models
{
    public partial class animalesfantasticosContext : DbContext
    {
        public animalesfantasticosContext()
        {
        }

        public animalesfantasticosContext(DbContextOptions<animalesfantasticosContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Animales> Animales { get; set; }
        public virtual DbSet<Magos> Magos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                IConfigurationRoot configuration = new ConfigurationBuilder()
                    .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
                    .AddJsonFile("appsettings.json")
                    .Build();
                optionsBuilder.UseMySql(configuration.GetConnectionString("conexionDatabase"));
            }

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Animales>(entity =>
            {
                entity.ToTable("animales");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Edad).HasColumnType("int(11)");

                entity.Property(e => e.Especie).HasColumnType("varchar(255)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(255)");
            });

            modelBuilder.Entity<Magos>(entity =>
            {
                entity.ToTable("magos");

                entity.Property(e => e.Id)
                    .HasColumnName("ID")
                    .HasColumnType("int(11)");

                entity.Property(e => e.Apellido).HasColumnType("varchar(255)");

                entity.Property(e => e.Edad).HasColumnType("int(11)");

                entity.Property(e => e.Nombre)
                    .IsRequired()
                    .HasColumnType("varchar(255)");
            });
        }
    }
}
