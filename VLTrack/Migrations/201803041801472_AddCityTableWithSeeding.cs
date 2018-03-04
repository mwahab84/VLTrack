namespace VLTrack.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddCityTableWithSeeding : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        CountryId = c.Int(nullable: false),
                        PlateNum = c.Int(nullable: false),
                        CityTitle = c.String(),
                        CityDesc = c.String(),
                        Notes = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Countries", t => t.CountryId, cascadeDelete: true)
                .Index(t => t.CountryId);

            //Seeding the Cities of Turkey
            Sql("Insert into Cities values ('225','1',N'adana','','')");
            Sql("Insert into Cities values ('225','2',N'adıyaman','','')");
            Sql("Insert into Cities values ('225','3',N'afyonkarahisar','','')");
            Sql("Insert into Cities values ('225','4',N'ağrı','','')");
            Sql("Insert into Cities values ('225','5',N'amasya','','')");
            Sql("Insert into Cities values ('225','6',N'ankara','','')");
            Sql("Insert into Cities values ('225','7',N'antalya','','')");
            Sql("Insert into Cities values ('225','8',N'artvin','','')");
            Sql("Insert into Cities values ('225','9',N'aydın','','')");
            Sql("Insert into Cities values ('225','10',N'balıkesir','','')");
            Sql("Insert into Cities values ('225','11',N'bilecik','','')");
            Sql("Insert into Cities values ('225','12',N'bingöl','','')");
            Sql("Insert into Cities values ('225','13',N'bitlis','','')");
            Sql("Insert into Cities values ('225','14',N'bolu','','')");
            Sql("Insert into Cities values ('225','15',N'burdur','','')");
            Sql("Insert into Cities values ('225','16',N'bursa','','')");
            Sql("Insert into Cities values ('225','17',N'çanakkale','','')");
            Sql("Insert into Cities values ('225','18',N'çankırı','','')");
            Sql("Insert into Cities values ('225','19',N'çorum','','')");
            Sql("Insert into Cities values ('225','20',N'denizli','','')");
            Sql("Insert into Cities values ('225','21',N'diyarbakır','','')");
            Sql("Insert into Cities values ('225','22',N'edirne','','')");
            Sql("Insert into Cities values ('225','23',N'elazığ','','')");
            Sql("Insert into Cities values ('225','24',N'erzincan','','')");
            Sql("Insert into Cities values ('225','25',N'erzurum','','')");
            Sql("Insert into Cities values ('225','26',N'eskişehir','','')");
            Sql("Insert into Cities values ('225','27',N'gaziantep','','')");
            Sql("Insert into Cities values ('225','28',N'giresun','','')");
            Sql("Insert into Cities values ('225','29',N'gümüşhane','','')");
            Sql("Insert into Cities values ('225','30',N'hakkari','','')");
            Sql("Insert into Cities values ('225','31',N'hatay','','')");
            Sql("Insert into Cities values ('225','32',N'ısparta','','')");
            Sql("Insert into Cities values ('225','33',N'mersin','','')");
            Sql("Insert into Cities values ('225','34',N'istanbul','','')");
            Sql("Insert into Cities values ('225','35',N'izmir','','')");
            Sql("Insert into Cities values ('225','36',N'kars','','')");
            Sql("Insert into Cities values ('225','37',N'kastamonu','','')");
            Sql("Insert into Cities values ('225','38',N'kayseri','','')");
            Sql("Insert into Cities values ('225','39',N'kırklareli','','')");
            Sql("Insert into Cities values ('225','40',N'kırşehir','','')");
            Sql("Insert into Cities values ('225','41',N'kocaeli','','')");
            Sql("Insert into Cities values ('225','42',N'konya','','')");
            Sql("Insert into Cities values ('225','43',N'kütahya','','')");
            Sql("Insert into Cities values ('225','44',N'malatya','','')");
            Sql("Insert into Cities values ('225','45',N'manisa','','')");
            Sql("Insert into Cities values ('225','46',N'kahramanmaraş','','')");
            Sql("Insert into Cities values ('225','47',N'mardin','','')");
            Sql("Insert into Cities values ('225','48',N'muğla','','')");
            Sql("Insert into Cities values ('225','49',N'muş','','')");
            Sql("Insert into Cities values ('225','50',N'nevşehir','','')");
            Sql("Insert into Cities values ('225','51',N'niğde','','')");
            Sql("Insert into Cities values ('225','52',N'ordu','','')");
            Sql("Insert into Cities values ('225','53',N'rize','','')");
            Sql("Insert into Cities values ('225','54',N'sakarya','','')");
            Sql("Insert into Cities values ('225','55',N'samsun','','')");
            Sql("Insert into Cities values ('225','56',N'siirt','','')");
            Sql("Insert into Cities values ('225','57',N'sinop','','')");
            Sql("Insert into Cities values ('225','58',N'sivas','','')");
            Sql("Insert into Cities values ('225','59',N'tekirdağ','','')");
            Sql("Insert into Cities values ('225','60',N'tokat','','')");
            Sql("Insert into Cities values ('225','61',N'trabzon','','')");
            Sql("Insert into Cities values ('225','62',N'tunceli','','')");
            Sql("Insert into Cities values ('225','63',N'şanlıurfa','','')");
            Sql("Insert into Cities values ('225','64',N'uşak','','')");
            Sql("Insert into Cities values ('225','65',N'van','','')");
            Sql("Insert into Cities values ('225','66',N'yozgat','','')");
            Sql("Insert into Cities values ('225','67',N'zonguldak','','')");
            Sql("Insert into Cities values ('225','68',N'aksaray','','')");
            Sql("Insert into Cities values ('225','69',N'bayburt','','')");
            Sql("Insert into Cities values ('225','70',N'karaman','','')");
            Sql("Insert into Cities values ('225','71',N'kırıkkale','','')");
            Sql("Insert into Cities values ('225','72',N'batman','','')");
            Sql("Insert into Cities values ('225','73',N'şırnak','','')");
            Sql("Insert into Cities values ('225','74',N'bartın','','')");
            Sql("Insert into Cities values ('225','75',N'ardahan','','')");
            Sql("Insert into Cities values ('225','76',N'ığdır','','')");
            Sql("Insert into Cities values ('225','77',N'yalova','','')");
            Sql("Insert into Cities values ('225','78',N'karabük','','')");
            Sql("Insert into Cities values ('225','79',N'kilis','','')");
            Sql("Insert into Cities values ('225','80',N'osmaniye','','')");
            Sql("Insert into Cities values ('225','81',N'düzce','','')");

        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cities", "CountryId", "dbo.Countries");
            DropIndex("dbo.Cities", new[] { "CountryId" });
            DropTable("dbo.Cities");
        }
    }
}
