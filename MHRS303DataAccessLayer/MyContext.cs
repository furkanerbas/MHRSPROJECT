using MHRS303EntityLayer.IdentityModels;
using MHRS303EntityLayer.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MHRS303DataAccessLayer
{
    public class MyContext : IdentityDbContext<AppUser, AppRole, string>
    {
        public MyContext(DbContextOptions<MyContext> options) : base(options)
        {

        }

        public virtual DbSet<City> Cities { get; set; }
        public virtual DbSet<Clinic> Clinics { get; set; }
        public virtual DbSet<District> Districts { get; set; }
        public virtual DbSet<Hospital> Hospitals { get; set; }
        public virtual DbSet<HospitalClinic> HospitalClinic { get; set; }
        public virtual DbSet<Appointment> Appointment { get; set; }
        public virtual DbSet<AppointmentHour> AppointmentHours { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            //builder.Entity<City>()
            //    .HasIndex(c => new { c.PlateCode })
            //    .IsUnique(true);

            //builder.Entity<District>()
            //    .HasOne(d=>d.City)
            //    .WithMany(c=>c.Districts)
            //    .HasForeignKey(d=>d.CityId)
            //    .OnDelete(DeleteBehavior.NoAction);




            base.OnModelCreating(builder);
        }
    }
}