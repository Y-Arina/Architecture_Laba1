using Laba45.Models.Entity;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Laba45.Models
{
    public class DataContext : DbContext
    {
        public DbSet<Hospital> Hospitals { get; set; }
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Nurse> Nurses { get; set; }
        public DbSet<Patient>Patients { get; set; }
        public DbSet<Medical_Record> MedRecords { get; set; }
        public DbSet<Reception> Receptions { get; set; }
        public DbSet<Sick_List> SickLists { get; set; }
        public DataContext(DbContextOptions<DataContext> options):base(options)
        {
            Database.EnsureCreated();
        }
    }
}
