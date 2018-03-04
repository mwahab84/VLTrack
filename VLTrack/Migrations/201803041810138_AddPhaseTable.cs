namespace VLTrack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPhaseTable : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Phases",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PhaseTitle = c.String(),
                        PhaseDesc = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            //Complete Profile, Setting Appointment, Interview, Delivery
            Sql("Insert into Phases values ('Complete Profile','Complete Profile',null)");
            Sql("Insert into Phases values ('Setting Appointment','Setting Appointment',null)");
            Sql("Insert into Phases values ('Interview','Interview',null)");
            Sql("Insert into Phases values ('Delivery','Delivery',null)");
        }
        
        public override void Down()
        {
            DropTable("dbo.Phases");
        }
    }
}
