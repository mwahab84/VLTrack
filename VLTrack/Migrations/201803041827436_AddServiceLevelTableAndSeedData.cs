namespace VLTrack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddServiceLevelTableAndSeedData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServiceLevels",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceLevelTitle = c.String(),
                        ServiceLevelDesc = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            //Standard, VIP, Others
            Sql("Insert into ServiceLevels values ('Standard','Standard',null)");
            Sql("Insert into ServiceLevels values ('VIP','VIP',null)");
            Sql("Insert into ServiceLevels values ('Others','Others',null)");
        }
        
        public override void Down()
        {
            DropTable("dbo.ServiceLevels");
        }
    }
}
