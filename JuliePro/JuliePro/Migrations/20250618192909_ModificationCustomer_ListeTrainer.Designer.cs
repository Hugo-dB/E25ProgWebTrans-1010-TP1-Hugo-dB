﻿// <auto-generated />
using System;
using JuliePro.Models.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace JuliePro.Migrations
{
    [DbContext(typeof(JulieProDbContext))]
    [Migration("20250618192909_ModificationCustomer_ListeTrainer")]
    partial class ModificationCustomer_ListeTrainer
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("CustomerTrainer", b =>
                {
                    b.Property<int>("CustomersId")
                        .HasColumnType("int");

                    b.Property<int>("TrainersId")
                        .HasColumnType("int");

                    b.HasKey("CustomersId", "TrainersId");

                    b.HasIndex("TrainersId");

                    b.ToTable("CustomerTrainer");
                });

            modelBuilder.Entity("JuliePro.Models.Customer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime>("BirthDate")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<double?>("StartWeight")
                        .HasColumnType("float");

                    b.HasKey("Id");

                    b.ToTable("Customer");
                });

            modelBuilder.Entity("JuliePro.Models.Objective", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<DateTime?>("AchievedDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("CustomerId")
                        .HasColumnType("int");

                    b.Property<double?>("DistanceKm")
                        .HasColumnType("float");

                    b.Property<double?>("LostWeightKg")
                        .HasColumnType("float");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(15)
                        .HasColumnType("nvarchar(15)");

                    b.HasKey("Id");

                    b.HasIndex("CustomerId");

                    b.ToTable("Objective");
                });

            modelBuilder.Entity("JuliePro.Models.Speciality", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(20)
                        .HasColumnType("nvarchar(20)");

                    b.HasKey("Id");

                    b.ToTable("Specialities");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "Perte de poids"
                        },
                        new
                        {
                            Id = 2,
                            Name = "Course"
                        },
                        new
                        {
                            Id = 3,
                            Name = "Halthérophilie"
                        },
                        new
                        {
                            Id = 4,
                            Name = "Réhabilitation"
                        });
                });

            modelBuilder.Entity("JuliePro.Models.Trainer", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(25)
                        .HasColumnType("nvarchar(25)");

                    b.Property<string>("Photo")
                        .HasMaxLength(40)
                        .HasColumnType("nvarchar(40)");

                    b.Property<int>("SpecialityId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("SpecialityId");

                    b.ToTable("Trainers");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Email = "Chrystal.lapierre@juliepro.ca",
                            FirstName = "Chrystal",
                            LastName = "Lapierre",
                            Photo = "Chrystal.png",
                            SpecialityId = 1
                        },
                        new
                        {
                            Id = 2,
                            Email = "Felix.trudeau@juliePro.ca",
                            FirstName = "Félix",
                            LastName = "Trudeau",
                            Photo = "Felix.png",
                            SpecialityId = 2
                        },
                        new
                        {
                            Id = 3,
                            Email = "Frank.StJohn@juliepro.ca",
                            FirstName = "François",
                            LastName = "Saint-John",
                            Photo = "Francois.png",
                            SpecialityId = 1
                        },
                        new
                        {
                            Id = 4,
                            Email = "JC.Bastien@juliepro.ca",
                            FirstName = "Jean-Claude",
                            LastName = "Bastien",
                            Photo = "JeanClaude.png",
                            SpecialityId = 4
                        },
                        new
                        {
                            Id = 5,
                            Email = "JinLee.godette@juliepro.ca",
                            FirstName = "Jin Lee",
                            LastName = "Godette",
                            Photo = "Jin Lee.png",
                            SpecialityId = 3
                        },
                        new
                        {
                            Id = 6,
                            Email = "Karine.Lachance@juliepro.ca",
                            FirstName = "Karine",
                            LastName = "Lachance",
                            Photo = "Karine.png",
                            SpecialityId = 2
                        },
                        new
                        {
                            Id = 7,
                            Email = "Ramone.Esteban@juliepro.ca",
                            FirstName = "Ramone",
                            LastName = "Esteban",
                            Photo = "Ramone.png",
                            SpecialityId = 3
                        });
                });

            modelBuilder.Entity("CustomerTrainer", b =>
                {
                    b.HasOne("JuliePro.Models.Customer", null)
                        .WithMany()
                        .HasForeignKey("CustomersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("JuliePro.Models.Trainer", null)
                        .WithMany()
                        .HasForeignKey("TrainersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("JuliePro.Models.Objective", b =>
                {
                    b.HasOne("JuliePro.Models.Customer", "Customer")
                        .WithMany("Objectives")
                        .HasForeignKey("CustomerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Customer");
                });

            modelBuilder.Entity("JuliePro.Models.Trainer", b =>
                {
                    b.HasOne("JuliePro.Models.Speciality", "Speciality")
                        .WithMany("Trainers")
                        .HasForeignKey("SpecialityId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Speciality");
                });

            modelBuilder.Entity("JuliePro.Models.Customer", b =>
                {
                    b.Navigation("Objectives");
                });

            modelBuilder.Entity("JuliePro.Models.Speciality", b =>
                {
                    b.Navigation("Trainers");
                });
#pragma warning restore 612, 618
        }
    }
}
