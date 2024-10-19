# EntityDatabase

![image](https://github.com/user-attachments/assets/19b783bc-672c-4ffd-b659-e9d4de75b1ce)


# MusicOfHeartDbContextDB

## Overview

MusicOfHeartDbContextDB is a .NET 8 application that utilizes Entity Framework Core to manage a music database. The database includes tables for instruments, musicians, and bands. This project aims to provide an easy-to-use interface for managing music-related data.

## Technologies Used

- **.NET 8**: The latest version of the .NET framework.
- **Entity Framework Core**: An Object-Relational Mapper (ORM) for .NET that enables developers to work with a database using .NET objects.

## Database Schema

The database consists of the following tables:

1. **Instruments**
   - Represents musical instruments.
   - Fields: `Id`, `InstrumentName`, etc.

2. **Musicians**
   - Represents individual musicians.
   - Fields: `Id`, `FirstName`, `LastName`, `origin`, etc.

3. **Bands**
   - Represents musical bands.
   - Fields: `Id`, `FirstName`,etc.
  
3. **Database sql Img *
![image](https://github.com/user-attachments/assets/9d4f9d4f-9e6d-4063-baae-1b68da901556)

## Database Seeding Example

The following code demonstrates how seed data is added to the database in the `OnModelCreating` method in `MusicOfHeartDbContext`.

```csharp
protected override void OnModelCreating(ModelBuilder modelBuilder)
{
    // Seed data for bands
    List<Band> bands = new()
    {
        new Band() { BandId = 1, FirstName = "Coke Studio 5", Country = "India" },
        new Band() { BandId = 2, FirstName = "Veps spiders", Country = "Latin America" },
        new Band() { BandId = 3, FirstName = "Ola Nordman band", Country = "Norway" }
    };

    // Seed data for instruments
    List<Instrument> instruments = new()
    {
        new () { InstrumentId = 1, InstrumentName = "Piano", Description = "Black color piano" },
        new () { InstrumentId = 2, InstrumentName = "Sitar", Description = "Indian traditional sitar" },
        new () { InstrumentId = 3, InstrumentName = "Guitar", Description = "Electric guitar" }
    };

    // Seed data for musicians
    List<Musician> musicians = new()
    {
        new () { MusicianId = 1, FirstName = "Raju", LastName = "Kumar", Origin = "Indian musician", BandId = 1, InstrumentId = 2 },
        new () { MusicianId = 2, FirstName = "Vinod", LastName = "Srivastav", Origin = "American Indian musician", BandId = 2, InstrumentId = 3 },
        new () { MusicianId = 3, FirstName = "Ram", LastName = "Gopal", Origin = "British Indian musician", BandId = 2, InstrumentId = 1 }
    };

    // Applying seed data
    modelBuilder.Entity<Band>().HasData(bands);
    modelBuilder.Entity<Instrument>().HasData(instruments);
    modelBuilder.Entity<Musician>().HasData(musicians);
}
```
