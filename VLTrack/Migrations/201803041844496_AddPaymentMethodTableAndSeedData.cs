namespace VLTrack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPaymentMethodTableAndSeedData : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.PaymentMethods",
                c => new
                    {
                        PaymentMethodId = c.Int(nullable: false, identity: true),
                        PymentMethodTitle = c.String(),
                        PymentMethodDesc = c.String(),
                        IsCard = c.Boolean(nullable: false),
                        CardType = c.String(),
                    })
                .PrimaryKey(t => t.PaymentMethodId);

            Sql("Insert into PaymentMethods values ('Cash','Cash',0,null)");
            Sql("Insert into PaymentMethods values ('Check','Check',0,null)");
            Sql("Insert into PaymentMethods values ('Credit Card','Credit Card',1,'VISA')");
            Sql("Insert into PaymentMethods values ('Credit Card','Credit Card',1,'MASTER CARD')");
            Sql("Insert into PaymentMethods values ('American Express','American Express',1,'VISA')");
            Sql("Insert into PaymentMethods values ('Debit Card','Debit Card',1,'VISA')");
        }
        
        public override void Down()
        {
            DropTable("dbo.PaymentMethods");
        }
    }
}
