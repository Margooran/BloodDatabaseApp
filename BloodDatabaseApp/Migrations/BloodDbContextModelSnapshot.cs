﻿// <auto-generated />
using System;
using BloodDatabaseApp;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace BloodDatabaseApp.Migrations
{
    [DbContext(typeof(BloodDbContext))]
    partial class BloodDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder.HasAnnotation("ProductVersion", "9.0.0");

            modelBuilder.Entity("BloodDatabaseApp.BloodTypeEntity", b =>
                {
                    b.Property<int>("BloodTypeID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<string>("ABO")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("BloodTypeName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<bool>("Resus")
                        .HasColumnType("INTEGER");

                    b.HasKey("BloodTypeID");

                    b.ToTable("BloodTypes");

                    b.HasData(
                        new
                        {
                            BloodTypeID = 1,
                            ABO = "0",
                            BloodTypeName = "1-",
                            Resus = false
                        },
                        new
                        {
                            BloodTypeID = 2,
                            ABO = "0",
                            BloodTypeName = "1+",
                            Resus = true
                        },
                        new
                        {
                            BloodTypeID = 3,
                            ABO = "A",
                            BloodTypeName = "2-",
                            Resus = false
                        },
                        new
                        {
                            BloodTypeID = 4,
                            ABO = "A",
                            BloodTypeName = "2+",
                            Resus = true
                        },
                        new
                        {
                            BloodTypeID = 5,
                            ABO = "B",
                            BloodTypeName = "3-",
                            Resus = false
                        },
                        new
                        {
                            BloodTypeID = 6,
                            ABO = "B",
                            BloodTypeName = "3+",
                            Resus = true
                        },
                        new
                        {
                            BloodTypeID = 7,
                            ABO = "AB",
                            BloodTypeName = "4-",
                            Resus = false
                        },
                        new
                        {
                            BloodTypeID = 8,
                            ABO = "AB",
                            BloodTypeName = "4+",
                            Resus = true
                        });
                });

            modelBuilder.Entity("BloodDatabaseApp.PatientEntity", b =>
                {
                    b.Property<int>("PatientID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<int>("BloodTypeID")
                        .HasColumnType("INTEGER");

                    b.Property<string>("PatientGender")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.Property<string>("PatientName")
                        .IsRequired()
                        .HasColumnType("TEXT");

                    b.HasKey("PatientID");

                    b.HasIndex("BloodTypeID");

                    b.ToTable("Patients");

                    b.HasData(
                        new
                        {
                            PatientID = 1,
                            BloodTypeID = 1,
                            PatientGender = "Male",
                            PatientName = "Alex Smith"
                        },
                        new
                        {
                            PatientID = 2,
                            BloodTypeID = 2,
                            PatientGender = "Female",
                            PatientName = "Jenna Johnson"
                        },
                        new
                        {
                            PatientID = 3,
                            BloodTypeID = 1,
                            PatientGender = "Female",
                            PatientName = "Hanna Williams"
                        },
                        new
                        {
                            PatientID = 4,
                            BloodTypeID = 7,
                            PatientGender = "Male",
                            PatientName = "Mike Brown"
                        });
                });

            modelBuilder.Entity("BloodDatabaseApp.RecordEntity", b =>
                {
                    b.Property<int>("RecordID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("INTEGER");

                    b.Property<DateTime>("DateTime")
                        .HasColumnType("TEXT");

                    b.Property<int>("PatientID")
                        .HasColumnType("INTEGER");

                    b.Property<int>("Quantity")
                        .HasColumnType("INTEGER");

                    b.HasKey("RecordID");

                    b.HasIndex("PatientID");

                    b.ToTable("Records");
                });

            modelBuilder.Entity("BloodDatabaseApp.PatientEntity", b =>
                {
                    b.HasOne("BloodDatabaseApp.BloodTypeEntity", "BloodType")
                        .WithMany("Patients")
                        .HasForeignKey("BloodTypeID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("BloodType");
                });

            modelBuilder.Entity("BloodDatabaseApp.RecordEntity", b =>
                {
                    b.HasOne("BloodDatabaseApp.PatientEntity", "Patient")
                        .WithMany("Records")
                        .HasForeignKey("PatientID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.Navigation("Patient");
                });

            modelBuilder.Entity("BloodDatabaseApp.BloodTypeEntity", b =>
                {
                    b.Navigation("Patients");
                });

            modelBuilder.Entity("BloodDatabaseApp.PatientEntity", b =>
                {
                    b.Navigation("Records");
                });
#pragma warning restore 612, 618
        }
    }
}
