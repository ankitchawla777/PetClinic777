namespace Pet_Clinic.Migrations.Customers
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        cId = c.Int(nullable: false, identity: true),
                        cName = c.String(),
                        cAddress = c.String(),
                    })
                .PrimaryKey(t => t.cId);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Customers");
        }
    }
}
