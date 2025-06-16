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
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 1, Name = "Perte de poids" });
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 2, Name = "Course" });
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 3, Name = "Halthérophilie" });
            builder.Entity<Speciality>().HasData(new Speciality() { Id = 4, Name = "Réhabilitation" });
        }

        public DbSet<Speciality> Specialities { get; set; }
    }
}
