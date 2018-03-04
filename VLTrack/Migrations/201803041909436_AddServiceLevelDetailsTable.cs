namespace VLTrack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddServiceLevelDetailsTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServiceLevelDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceId = c.Int(nullable: false),
                        ServiceLevelId = c.Int(nullable: false),
                        Duration = c.Short(nullable: false),
                        MinAge = c.Byte(nullable: false),
                        UnitPrice = c.Double(nullable: false),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .ForeignKey("dbo.ServiceLevels", t => t.ServiceLevelId, cascadeDelete: true)
                .Index(t => t.ServiceId)
                .Index(t => t.ServiceLevelId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceLevelDetails", "ServiceLevelId", "dbo.ServiceLevels");
            DropForeignKey("dbo.ServiceLevelDetails", "ServiceId", "dbo.Services");
            DropIndex("dbo.ServiceLevelDetails", new[] { "ServiceLevelId" });
            DropIndex("dbo.ServiceLevelDetails", new[] { "ServiceId" });
            DropTable("dbo.ServiceLevelDetails");
        }
    }
}
