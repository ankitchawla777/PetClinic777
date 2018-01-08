namespace Pet_Clinic.Migrations.Doctors
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<Pet_Clinic.Models.DoctorDBContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = true;
            MigrationsDirectory = @"Migrations\Doctors";
            ContextKey = "Pet_Clinic.Models.DoctorDBContext";
        }

        protected override void Seed(Pet_Clinic.Models.DoctorDBContext context)
        {
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data.
        }
    }
}
