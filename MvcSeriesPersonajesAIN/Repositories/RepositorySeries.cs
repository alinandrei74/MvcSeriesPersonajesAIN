using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MvcSeriesPersonajesAIN.Models;

namespace MvcSeriesPersonajesAIN.Repositories
{
    public class SeriesContext : DbContext
    {
        public SeriesContext(DbContextOptions<SeriesContext> options)
            : base(options)
        {
        }

        public DbSet<Serie> Series { get; set; }
        public DbSet<Personaje> Personajes { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Serie>().ToTable("SERIES");
            modelBuilder.Entity<Serie>().HasKey(c => c.IdSerie);
            modelBuilder.Entity<Serie>().Property(c => c.IdSerie).HasColumnName("IDERSERIE");
            modelBuilder.Entity<Serie>().Property(c => c.Nombre).HasColumnName("NOMBRE");
            modelBuilder.Entity<Serie>().Property(c => c.Imagen).HasColumnName("IMAGEN");
            modelBuilder.Entity<Serie>().Property(c => c.Anyo).HasColumnName("ANYO");

            modelBuilder.Entity<Personaje>().ToTable("PERSONAJES");
            modelBuilder.Entity<Personaje>().HasKey(c => c.IdPersonaje);
            modelBuilder.Entity<Personaje>().Property(c => c.IdPersonaje).HasColumnName("IDPERSONAJE");
            modelBuilder.Entity<Personaje>().Property(c => c.Nombre).HasColumnName("NOMBRE");
            modelBuilder.Entity<Personaje>().Property(c => c.Imagen).HasColumnName("IMAGEN");
            modelBuilder.Entity<Personaje>().Property(c => c.IdSerie).HasColumnName("IDERSERIE");
        }
    }
}














namespace MvcSeriesPersonajesAIN.Repositories
{
    public class RepositorySeries
    {
    }
}
