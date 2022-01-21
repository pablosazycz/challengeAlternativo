using Microsoft.EntityFrameworkCore;
using challengeAlternativo.Entities;

namespace challengeAlternativo.Context
{
    public class IconsContext : DbContext
    {
        public IconsContext(DbContextOptions<IconsContext> options) : base(options)
        { 
        }
        public DbSet<Continent> Continents { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<GeographicIcon> GeographicIcons { get; set; }


    }
}
