namespace VLTrack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddServiceTableAndSeedData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Services",
                c => new
                    {
                        ServiceId = c.Int(nullable: false, identity: true),
                        ServiceTitle = c.String(),
                        ServiceDesc = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.ServiceId);
            //Tourism visa, Work visa, Student visa, Company Incorporation,
            //Nationality facilitation, ...etc
            Sql("Insert into Services values ('Tourism visa','Tourism visa',null)");
            Sql("Insert into Services values ('Work visa','Work visa',null)");
            Sql("Insert into Services values ('Student visa','Student visa',null)");
            Sql("Insert into Services values ('Company Incorporation','Company Incorporation',null)");
            Sql("Insert into Services values ('Nationality facilitation','Nationality facilitation',null)");
        }
        
        public override void Down()
        {
            DropTable("dbo.Services");
        }
    }
}
