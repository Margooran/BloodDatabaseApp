
using Microsoft.EntityFrameworkCore;
using System.Reflection.Emit;

namespace BloodDatabaseApp;

public class BloodDbContext : DbContext
{
    public BloodDbContext()
    {
        Database.EnsureCreated();
        //Database.EnsureDeleted();
    }

    public DbSet<RecordEntity> Records { get; set; }
    public DbSet<PatientEntity> Patients { get; set; }
    public DbSet<BloodTypeEntity> BloodTypes { get; set; }

    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.ApplyConfiguration(new RecordConfiguration());
        modelBuilder.ApplyConfiguration(new PatientConfiguration());
        modelBuilder.ApplyConfiguration(new BloodTypeConfiguration());

        base.OnModelCreating(modelBuilder);
        BloodEntityGeneration(modelBuilder);
        PatientEntityGeneration(modelBuilder);
    }

    private void BloodEntityGeneration(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<BloodTypeEntity>().HasData(
            new BloodTypeEntity { BloodTypeID = 1, BloodTypeName = "1-", ABO = "0", Resus = false },
            new BloodTypeEntity { BloodTypeID = 2, BloodTypeName = "1+", ABO = "0", Resus = true },
            new BloodTypeEntity { BloodTypeID = 3, BloodTypeName = "2-", ABO = "A", Resus = false },
            new BloodTypeEntity { BloodTypeID = 4, BloodTypeName = "2+", ABO = "A", Resus = true },
            new BloodTypeEntity { BloodTypeID = 5, BloodTypeName = "3-", ABO = "B", Resus = false },
            new BloodTypeEntity { BloodTypeID = 6, BloodTypeName = "3+", ABO = "B", Resus = true },
            new BloodTypeEntity { BloodTypeID = 7, BloodTypeName = "4-", ABO = "AB", Resus = false },
            new BloodTypeEntity { BloodTypeID = 8, BloodTypeName = "4+", ABO = "AB", Resus = true }
        );
    }

    private void PatientEntityGeneration(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<PatientEntity>().HasData(
            new PatientEntity { PatientID = 1, PatientName = "Alex Smith", PatientGender = "Male", BloodTypeID = 1 },
            new PatientEntity { PatientID = 2, PatientName = "Jenna Johnson", PatientGender = "Female", BloodTypeID = 2 },
            new PatientEntity { PatientID = 3, PatientName = "Hanna Williams", PatientGender = "Female", BloodTypeID = 1 },
            new PatientEntity { PatientID = 4, PatientName = "Mike Brown", PatientGender = "Male", BloodTypeID = 7 },
            new PatientEntity { PatientID = 5, PatientName = "Will Brown", PatientGender = "Male", BloodTypeID = 8 },
            new PatientEntity { PatientID = 6, PatientName = "Emily Davis", PatientGender = "Female", BloodTypeID = 3 },
            new PatientEntity { PatientID = 7, PatientName = "James Wilson", PatientGender = "Male", BloodTypeID = 5 },
            new PatientEntity { PatientID = 8, PatientName = "Sophia Miller", PatientGender = "Female", BloodTypeID = 4 },
            new PatientEntity { PatientID = 9, PatientName = "Daniel Garcia", PatientGender = "Male", BloodTypeID = 6 },
            new PatientEntity { PatientID = 10, PatientName = "Mia Martinez", PatientGender = "Female", BloodTypeID = 2 },
            new PatientEntity { PatientID = 11, PatientName = "Ethan Taylor", PatientGender = "Male", BloodTypeID = 1 },
            new PatientEntity { PatientID = 12, PatientName = "Isabella Anderson", PatientGender = "Female", BloodTypeID = 7 },
            new PatientEntity { PatientID = 13, PatientName = "Michael Thomas", PatientGender = "Male", BloodTypeID = 8 },
            new PatientEntity { PatientID = 14, PatientName = "Olivia Lee", PatientGender = "Female", BloodTypeID = 3 },
            new PatientEntity { PatientID = 15, PatientName = "Benjamin Harris", PatientGender = "Male", BloodTypeID = 5 }
        );
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        optionsBuilder
            .UseSqlite("Data Source=BloodDatabase.db")
            .LogTo(Console.WriteLine, Microsoft.Extensions.Logging.LogLevel.Information);
        base.OnConfiguring(optionsBuilder);
    }
}