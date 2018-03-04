namespace VLTrack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTransactionTableAndSeedData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Transactions",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransactionTitle = c.String(),
                        TransactionDesc = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id);

            //Order Placed, Under Review, Initiated, ...etc
            Sql("Insert into Transactions values ('Order Placed','Order Placed',null)");
            Sql("Insert into Transactions values ('Under Review','Under Review',null)");
            Sql("Insert into Transactions values ('Initiated','Initiated',null)");
            Sql("Insert into Transactions values ('Under Processing','Under Processing',null)");

        }
        
        public override void Down()
        {
            DropTable("dbo.Transactions");
        }
    }
}
