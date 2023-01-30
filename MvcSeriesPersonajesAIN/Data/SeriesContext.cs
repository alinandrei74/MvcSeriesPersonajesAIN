using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using MvcSeriesPersonajesAIN.Models;

namespace MvcSeriesPersonajesAIN.Data
{
    public class SeriesContext : DbContext
    {
        private readonly IConfiguration _config;

        public SeriesContext(DbContextOptions<SeriesContext> options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        public DbSet<Serie> Series { get; set; }
        public DbSet<Personaje> Personajes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_config.GetConnectionString("sqlseries"));
        }
    }
}



