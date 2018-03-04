namespace VLTrack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddServiceRequirementTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServiceRequirements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RequirementId = c.Int(nullable: false),
                        ServiceId = c.Int(nullable: false),
                        Optional = c.Boolean(nullable: false),
                        DoneBy = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Requirements", t => t.RequirementId, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .Index(t => t.RequirementId)
                .Index(t => t.ServiceId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServiceRequirements", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.ServiceRequirements", "RequirementId", "dbo.Requirements");
            DropIndex("dbo.ServiceRequirements", new[] { "ServiceId" });
            DropIndex("dbo.ServiceRequirements", new[] { "RequirementId" });
            DropTable("dbo.ServiceRequirements");
        }
    }
}
