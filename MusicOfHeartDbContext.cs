using EntityDatabase.Models;
using Microsoft.EntityFrameworkCore;

namespace EntityDatabase
{
    public class MusicOfHeartDbContext : DbContext
    {
        // properties for database
        public DbSet<Band> Bands { get; set; }
        public DbSet<Musician> Musicians { get; set; }
        public DbSet<Instrument> Instruments { get; set; }

        //Overrides
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Data Source=ROHIT\SQLEXPRESS;Initial Catalog=MusicOfHeartDbContextDB;Integrated Security=True;");

        }


    }
}
