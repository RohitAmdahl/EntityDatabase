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
            optionsBuilder.UseSqlServer(@"Data Source=ROHIT\SQLEXPRESS;Initial Catalog=MusicOfHeartDbContextDB;Integrated Security=True;TrustServerCertificate=True;");
        }

        // seeding data 
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // create seed data 
            List<Band> bands = new()
            {
                new Band() { BandId = 1, FirstName = "Coke Studio 5", Country ="India"},
                new Band() { BandId = 2, FirstName = "Veps spiders", Country ="Latin America"},
                new Band() { BandId = 3, FirstName = "Ola Nordman band", Country ="Norway"}
            };


            List<Instrument> instruments = new()
            {
                new () { InstrumentId = 1, InstrumentName = "Piano", Description = "Black color piano" },
                new () {InstrumentId = 2, InstrumentName = "Sitar", Description = "Indian traditional sitar" },
                new () {InstrumentId = 3, InstrumentName = "Gitar", Description = "Electric gitar"}

            };
            List<Musician> musicians = new()
            {
                new () { MusicianId = 1, FirstName = "Raju" , LastName = "Kumar", Origin = "Indian musician", BandId = 1, InstrumentId = 2 },
                new () { MusicianId = 2, FirstName = "Vinod" , LastName = "Srivastav", Origin = "American indian musician", BandId = 2, InstrumentId = 3 },
                new () { MusicianId = 3, FirstName = "Ram" , LastName = "Gopal", Origin = "British Indian musician", BandId = 2, InstrumentId = 1 }
            };


            modelBuilder.Entity<Band>().HasData(bands);
            modelBuilder.Entity<Instrument>().HasData(instruments);
            modelBuilder.Entity<Musician>().HasData(musicians);

        }




    }
}
