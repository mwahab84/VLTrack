namespace VLTrack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddServicePhasesTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ServicePhases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ServiceId = c.Int(nullable: false),
                        PhaseId = c.Int(nullable: false),
                        ServicePhaseDesc = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Phases", t => t.PhaseId, cascadeDelete: true)
                .ForeignKey("dbo.Services", t => t.ServiceId, cascadeDelete: true)
                .Index(t => t.ServiceId)
                .Index(t => t.PhaseId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.ServicePhases", "ServiceId", "dbo.Services");
            DropForeignKey("dbo.ServicePhases", "PhaseId", "dbo.Phases");
            DropIndex("dbo.ServicePhases", new[] { "PhaseId" });
            DropIndex("dbo.ServicePhases", new[] { "ServiceId" });
            DropTable("dbo.ServicePhases");
        }
    }
}
