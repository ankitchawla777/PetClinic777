using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Pet_Clinic.Models
{
    public class Doctor
    {
      
        public String dName { set; get; }
        [Key]
        public int dId { get; set; }
    }

    public class Customer
    {
        public String cName { get; set; }
        [Key]
        public int cId { get; set; }
        public String cAddress { get; set; }
    }
   

    public class Room
    {
        [Key]
        public int rNo { get; set; }
    }
    public class Appointments
    {
        [Key]
        public int aNo { get; set; }
        public int dId { get; set; }
        public int cId { get; set; }
        public int rNo { get; set; }
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:yyyy-MM-dd}", ApplyFormatInEditMode = true)]
        public DateTime aDate { get; set; }

    }
    public class PetDBContext : DbContext
    {
        public PetDBContext(): base("PetDbConnection")
        {}
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Appointments> Appointments { get; set; }
        public DbSet<Room> Rooms { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Doctor>().ToTable("Doctors");
            modelBuilder.Entity<Customer>().ToTable("customers");
            modelBuilder.Entity<Room>().ToTable("Rooms");
             modelBuilder.Entity<Appointments>().ToTable("Appointment");

            base.OnModelCreating(modelBuilder);
        }
    }

}