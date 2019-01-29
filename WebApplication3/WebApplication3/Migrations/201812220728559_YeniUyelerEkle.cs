namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YeniUyelerEkle : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Uyeler",
                c => new
                    {
                        UyeID = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false),
                        Soyad = c.String(nullable: false),
                        GidilecekSehir = c.String(nullable: false),
                        GidilecekUniversite = c.String(nullable: false),
                        Bolum = c.String(nullable: false),
                        IsImkani = c.String(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        Sifre = c.String(nullable: false, maxLength: 50),
                        SifreTekrarı = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.UyeID);
            
        }
        
        public override void Down()
        {
            DropTable("dbo.Uyeler");
        }
    }
}
