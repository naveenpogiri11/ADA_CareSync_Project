using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;

namespace CareSync.Models.DataAccess
{
    public class CareSyncDbContext : DbContext
    {
        public CareSyncDbContext(DbContextOptions<CareSyncDbContext> options) : base(options)
        {
        }

        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Patient> Patients { get; set; }
        public DbSet<Appointment> Appointments { get; set; }
    }
}
