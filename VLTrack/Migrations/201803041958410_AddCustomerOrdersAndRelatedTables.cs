namespace VLTrack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCustomerOrdersAndRelatedTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Addresses",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CityId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        AddressTitle = c.String(),
                        AddressDesc = c.String(),
                        MainAddress = c.Boolean(nullable: false),
                        BillingAddress = c.Boolean(nullable: false),
                        ShippingAddress = c.Boolean(nullable: false),
                        AddressLatitude = c.Double(nullable: false),
                        AddressMagnitude = c.Double(nullable: false),
                        LinkOnMaps = c.String(),
                        ZipCode = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Cities", t => t.CityId, cascadeDelete: true)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CityId)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CustomerId = c.Int(nullable: false, identity: true),
                        CutomerName = c.String(),
                        CustomerEmail = c.String(),
                        DateOfBirth = c.DateTime(nullable: false),
                        MartialStatus = c.String(),
                        NationalityId = c.Int(nullable: false),
                        InternalCustomer = c.Boolean(nullable: false),
                        CustomerType = c.String(),
                        NumberOfDependants = c.Int(nullable: false),
                        IsDependant = c.Boolean(nullable: false),
                        RelationToParentCustomer = c.String(),
                        ParentCustomer = c.Int(),
                    })
                .PrimaryKey(t => t.CustomerId)
                .ForeignKey("dbo.Customers", t => t.ParentCustomer)
                .Index(t => t.ParentCustomer);
            
            CreateTable(
                "dbo.MediaFiles",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        MediaFileTitle = c.String(),
                        MediaFileDesc = c.String(),
                        MediaFileType = c.String(),
                        MediaFilePath = c.String(),
                        MediaFileWidth = c.Double(nullable: false),
                        MediaFileHeight = c.Double(nullable: false),
                        MediaFileSize = c.Double(nullable: false),
                        MediaFileCreationDate = c.DateTime(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.Orders",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        MainCustomer = c.Int(nullable: false),
                        OrderDesc = c.String(),
                        OrderDate = c.DateTime(nullable: false),
                        OrderTime = c.DateTime(nullable: false),
                        PaymentCompleted = c.Boolean(nullable: false),
                        TotalAmount = c.Double(nullable: false),
                        Discounted = c.Boolean(nullable: false),
                        TotalAmountAfterDiscount = c.Double(nullable: false),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.MainCustomer, cascadeDelete: true)
                .Index(t => t.MainCustomer);
            
            CreateTable(
                "dbo.OrderItems",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        CustomerId = c.Int(nullable: false),
                        ServiceLevelDetailId = c.Int(nullable: false),
                        OrderItemDesc = c.String(),
                        InitialTargetCity = c.Int(nullable: false),
                        FinalTargetCity = c.Int(nullable: false),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.Cities", t => t.FinalTargetCity, cascadeDelete: false)
                .ForeignKey("dbo.Cities", t => t.InitialTargetCity, cascadeDelete: false)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: false)
                .ForeignKey("dbo.ServiceLevelDetails", t => t.ServiceLevelDetailId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.CustomerId)
                .Index(t => t.ServiceLevelDetailId)
                .Index(t => t.InitialTargetCity)
                .Index(t => t.FinalTargetCity);
            
            CreateTable(
                "dbo.OrderItemTransactionHistory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TransactionId = c.Int(nullable: false),
                        OrderItemId = c.Int(nullable: false),
                        TransactionDesc = c.String(),
                        TransactionStarted = c.DateTime(nullable: false),
                        TransactionEnded = c.DateTime(nullable: false),
                        TransactionStatus = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.OrderItems", t => t.OrderItemId, cascadeDelete: true)
                .ForeignKey("dbo.Transactions", t => t.TransactionId, cascadeDelete: true)
                .Index(t => t.TransactionId)
                .Index(t => t.OrderItemId);
            
            CreateTable(
                "dbo.OrderPaymentHistory",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        OrderId = c.Int(nullable: false),
                        PaymentMethodId = c.Int(nullable: false),
                        AmountPaid = c.Double(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Orders", t => t.OrderId, cascadeDelete: true)
                .ForeignKey("dbo.PaymentMethods", t => t.PaymentMethodId, cascadeDelete: true)
                .Index(t => t.OrderId)
                .Index(t => t.PaymentMethodId);
            
            CreateTable(
                "dbo.PhoneNumbers",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        PhoneNumberTitle = c.String(),
                        PhoneNumberDesc = c.String(),
                        CustomerPhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .Index(t => t.CustomerId);
            
            CreateTable(
                "dbo.CustomerServiceRequirements",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CustomerId = c.Int(nullable: false),
                        ServiceRequirementId = c.Int(nullable: false),
                        ServicePhaseId = c.Int(nullable: false),
                        MediaFileId = c.Int(nullable: false),
                        Completed = c.Boolean(nullable: false),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Customers", t => t.CustomerId, cascadeDelete: true)
                .ForeignKey("dbo.MediaFiles", t => t.MediaFileId, cascadeDelete: false)
                .ForeignKey("dbo.ServicePhases", t => t.ServicePhaseId, cascadeDelete: true)
                .ForeignKey("dbo.ServiceRequirements", t => t.ServiceRequirementId, cascadeDelete: false)
                .Index(t => t.CustomerId)
                .Index(t => t.ServiceRequirementId)
                .Index(t => t.ServicePhaseId)
                .Index(t => t.MediaFileId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.CustomerServiceRequirements", "ServiceRequirementId", "dbo.ServiceRequirements");
            DropForeignKey("dbo.CustomerServiceRequirements", "ServicePhaseId", "dbo.ServicePhases");
            DropForeignKey("dbo.CustomerServiceRequirements", "MediaFileId", "dbo.MediaFiles");
            DropForeignKey("dbo.CustomerServiceRequirements", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.PhoneNumbers", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.OrderPaymentHistory", "PaymentMethodId", "dbo.PaymentMethods");
            DropForeignKey("dbo.OrderPaymentHistory", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderItemTransactionHistory", "TransactionId", "dbo.Transactions");
            DropForeignKey("dbo.OrderItemTransactionHistory", "OrderItemId", "dbo.OrderItems");
            DropForeignKey("dbo.OrderItems", "ServiceLevelDetailId", "dbo.ServiceLevelDetails");
            DropForeignKey("dbo.OrderItems", "OrderId", "dbo.Orders");
            DropForeignKey("dbo.OrderItems", "InitialTargetCity", "dbo.Cities");
            DropForeignKey("dbo.OrderItems", "FinalTargetCity", "dbo.Cities");
            DropForeignKey("dbo.OrderItems", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Orders", "MainCustomer", "dbo.Customers");
            DropForeignKey("dbo.MediaFiles", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Customers", "ParentCustomer", "dbo.Customers");
            DropForeignKey("dbo.Addresses", "CustomerId", "dbo.Customers");
            DropForeignKey("dbo.Addresses", "CityId", "dbo.Cities");
            DropIndex("dbo.CustomerServiceRequirements", new[] { "MediaFileId" });
            DropIndex("dbo.CustomerServiceRequirements", new[] { "ServicePhaseId" });
            DropIndex("dbo.CustomerServiceRequirements", new[] { "ServiceRequirementId" });
            DropIndex("dbo.CustomerServiceRequirements", new[] { "CustomerId" });
            DropIndex("dbo.PhoneNumbers", new[] { "CustomerId" });
            DropIndex("dbo.OrderPaymentHistory", new[] { "PaymentMethodId" });
            DropIndex("dbo.OrderPaymentHistory", new[] { "OrderId" });
            DropIndex("dbo.OrderItemTransactionHistory", new[] { "OrderItemId" });
            DropIndex("dbo.OrderItemTransactionHistory", new[] { "TransactionId" });
            DropIndex("dbo.OrderItems", new[] { "FinalTargetCity" });
            DropIndex("dbo.OrderItems", new[] { "InitialTargetCity" });
            DropIndex("dbo.OrderItems", new[] { "ServiceLevelDetailId" });
            DropIndex("dbo.OrderItems", new[] { "CustomerId" });
            DropIndex("dbo.OrderItems", new[] { "OrderId" });
            DropIndex("dbo.Orders", new[] { "MainCustomer" });
            DropIndex("dbo.MediaFiles", new[] { "CustomerId" });
            DropIndex("dbo.Customers", new[] { "ParentCustomer" });
            DropIndex("dbo.Addresses", new[] { "CustomerId" });
            DropIndex("dbo.Addresses", new[] { "CityId" });
            DropTable("dbo.CustomerServiceRequirements");
            DropTable("dbo.PhoneNumbers");
            DropTable("dbo.OrderPaymentHistory");
            DropTable("dbo.OrderItemTransactionHistory");
            DropTable("dbo.OrderItems");
            DropTable("dbo.Orders");
            DropTable("dbo.MediaFiles");
            DropTable("dbo.Customers");
            DropTable("dbo.Addresses");
        }
    }
}
