using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace BloodDatabaseApp;

public class RecordConfiguration : IEntityTypeConfiguration<RecordEntity>
{
    public void Configure(EntityTypeBuilder<RecordEntity> builder)
    {
        builder.HasKey(b => b.RecordID);

        builder.HasOne(b => b.Patient).WithMany(a => a.Records).HasForeignKey(b => b.PatientID).OnDelete(DeleteBehavior.Restrict);

        builder.Property(b => b.RecordID).ValueGeneratedOnAdd();
    }
}

public class PatientConfiguration : IEntityTypeConfiguration<PatientEntity>
{
    public void Configure(EntityTypeBuilder<PatientEntity> builder)
    {
        builder.HasKey(a => a.PatientID);

        builder.HasOne(a => a.BloodType).WithMany(c => c.Patients).HasForeignKey(a => a.BloodTypeID).OnDelete(DeleteBehavior.Restrict);

        builder.Property(a => a.PatientID)
       .ValueGeneratedOnAdd();

        builder.HasMany(a => a.Records).WithOne(b => b.Patient);
    }
}

public class BloodTypeConfiguration : IEntityTypeConfiguration<BloodTypeEntity>
{
    public void Configure(EntityTypeBuilder<BloodTypeEntity> builder)
    {
        builder.HasKey(c => c.BloodTypeID);

        builder.Property(c => c.BloodTypeID)
               .ValueGeneratedOnAdd();

        builder.HasMany(a => a.Patients).WithOne(c => c.BloodType);
    }
}