using Microsoft.EntityFrameworkCore;

namespace JuliePro.Models.Data
{
    public class JulieProDbContext : DbContext
    {
        public JulieProDbContext(DbContextOptions<JulieProDbContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            #region Speciality

            builder.Entity<Speciality>().HasData(new Speciality() { Id = 1, Name = "Perte de poids" });
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 2, Name = "Course" });
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 3, Name = "Halthérophilie" });
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 4, Name = "Réhabilitation" });

            #endregion

            #region Trainer

            builder.Entity<Trainer>().HasData(new Trainer() { Id = 1, FirstName = "Chrystal", LastName = "Lapierre", Email = "Chrystal.lapierre@juliepro.ca", SpecialityId = 1, Photo = "Chrystal.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 2, FirstName = "Félix", LastName = "Trudeau", Email = "Felix.trudeau@juliePro.ca", SpecialityId = 2, Photo = "Felix.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 3, FirstName = "François", LastName = "Saint-John", Email = "Frank.StJohn@juliepro.ca", SpecialityId = 1, Photo = "Francois.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 4, FirstName = "Jean-Claude", LastName = "Bastien", Email = "JC.Bastien@juliepro.ca", SpecialityId = 4, Photo = "JeanClaude.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 5, FirstName = "Jin Lee", LastName = "Godette", Email = "JinLee.godette@juliepro.ca", SpecialityId = 3, Photo = "Jin Lee.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 6, FirstName = "Karine", LastName = "Lachance", Email = "Karine.Lachance@juliepro.ca", SpecialityId = 2, Photo = "Karine.png" });
            builder.Entity<Trainer>().HasData(new Trainer() { Id = 7, FirstName = "Ramone", LastName = "Esteban", Email = "Ramone.Esteban@juliepro.ca", SpecialityId = 3, Photo = "Ramone.png" });

            #endregion

            #region Customer

            builder.Entity<Customer>().HasData(new Customer() { Id = 1, FirstName = "Thomas", LastName = "Bergeron", Email = "ThoBerger@gmail.com", BirthDate = new DateTime(1998, 02, 12), StartWeight = 205, TrainerId = 1 });
            builder.Entity<Customer>().HasData(new Customer() { Id = 2, FirstName = "Alexis", LastName = "Plante", Email = "AlexCool@gmail.com", BirthDate = new DateTime(1978, 06, 1), StartWeight = 228, TrainerId = 1});
            builder.Entity<Customer>().HasData(new Customer() { Id = 3, FirstName = "Léa", LastName = "Boucher", Email = "BouLe@gmail.com", BirthDate = new DateTime(2000, 11, 11), StartWeight = 192, TrainerId = 1 });
            builder.Entity<Customer>().HasData(new Customer() { Id = 4, FirstName = "Mathis", LastName = "Courtier", Email = "LECourtier@gmail.com", BirthDate = new DateTime(1980, 05, 30), StartWeight = 199, TrainerId = 2 });

            #endregion

            #region Objective

            builder.Entity<Objective>().HasData(new Objective() { Id = 1, Name = "Marathon", DistanceKm = 42.2, AchievedDate = new DateTime(2020, 04, 15), CustomerId = 1});
            builder.Entity<Objective>().HasData(new Objective() { Id = 2, Name = "AllerAuGym", LostWeightKg = 10, AchievedDate = new DateTime(2018, 01, 23), CustomerId = 1});
            builder.Entity<Objective>().HasData(new Objective() { Id = 3, Name = "ExerciceQuot", LostWeightKg = 3.4, CustomerId = 1});
            builder.Entity<Objective>().HasData(new Objective() { Id = 4, Name = "DemiMarathon", DistanceKm = 21.1, AchievedDate = new DateTime(2019, 03, 16), CustomerId = 1 });
            builder.Entity<Objective>().HasData(new Objective() { Id = 5, Name = "GlowUp",DistanceKm = 15.7 , CustomerId = 2 });
            builder.Entity<Objective>().HasData(new Objective() { Id = 6, Name = "PrepCourse",DistanceKm = 12.5 , CustomerId = 2 });
            builder.Entity<Objective>().HasData(new Objective() { Id = 7, Name = "Triathlon", DistanceKm = 45, AchievedDate = new DateTime(2021, 07, 04), CustomerId = 3 });
            builder.Entity<Objective>().HasData(new Objective() { Id = 8, Name = "BodyBuilding", LostWeightKg = 2, AchievedDate = new DateTime(2023, 12, 12), CustomerId = 3 });
            builder.Entity<Objective>().HasData(new Objective() { Id = 9, Name = "SummerBody", LostWeightKg = 10,CustomerId = 4 });
            builder.Entity<Objective>().HasData(new Objective() { Id = 10, Name = "NatationRapide", DistanceKm = 2, AchievedDate = new DateTime(2012, 09, 02), CustomerId = 4 });

            #endregion
        }

        public DbSet<Speciality> Specialities { get; set; }
        public DbSet<Trainer> Trainers { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Objective> Objectives { get; set; }
    }
}
