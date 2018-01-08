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
    public class DoctorDBContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
    }

    public class Customer
    {
        public String cName { get; set; }
        [Key]
        public int cId { get; set; }
        public String cAddress { get; set; }
    }
    public class CustomerDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }

    public class Room
    {
        [Key]
        public int rNo { get; set; }
    }
    public class RoomDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<Pet_Clinic.Models.Room> Rooms { get; set; }
    }
    public class Appointments
    {
        [Key]
        public int aNo { get; set; }
        public int dId { get; set; }
        public int cId { get; set; }
        public int rNo { get; set; }
        public DateTime aDate { get; set; }

    }
    public class AppointmentDBContext : DbContext
    {
        public DbSet<Customer> Customers { get; set; }

        public System.Data.Entity.DbSet<Pet_Clinic.Models.Appointments> Appointments { get; set; }
    }

}