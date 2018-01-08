namespace Pet_Clinic.Migrations.Doctors
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Doctors",
                c => new
                    {
                        dId = c.Int(nullable: false, identity: true),
                        dName = c.String(),
                    })
                .PrimaryKey(t => t.dId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Doctors");
        }
    }
}
