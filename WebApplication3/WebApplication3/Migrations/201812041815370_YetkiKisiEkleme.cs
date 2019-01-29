namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class YetkiKisiEkleme : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.IsImkanlari",
                c => new
                    {
                        IsImkanlariID = c.Int(nullable: false, identity: true),
                        Sehir = c.String(nullable: false, maxLength: 15),
                        SirketIsmi = c.String(nullable: false, maxLength: 50),
                        Bolum = c.Int(),
                    })
                .PrimaryKey(t => t.IsImkanlariID);
            
            CreateTable(
                "dbo.Uye",
                c => new
                    {
                        UyeID = c.Int(nullable: false, identity: true),
                        UniversiteID = c.Int(nullable: false),
                        KonaklamaID = c.Int(nullable: false),
                        IsImkanlariID = c.Int(nullable: false),
                        YetkiKisiID = c.Int(nullable: false),
                        Ad = c.String(nullable: false),
                        Soyad = c.String(nullable: false),
                        GidilecekSehir = c.String(nullable: false),
                        GidilecekUniversite = c.String(nullable: false),
                        KalınacakZaman = c.DateTime(nullable: false),
                        EvYurt = c.String(nullable: false),
                        Bolum = c.String(nullable: false),
                        IsImkani = c.String(nullable: false),
                        Email = c.String(nullable: false, maxLength: 50),
                        Sifre = c.String(nullable: false, maxLength: 50),
                        SifreTekrarı = c.String(maxLength: 50),
                    })
                .PrimaryKey(t => t.UyeID)
                .ForeignKey("dbo.IsImkanlari", t => t.IsImkanlariID, cascadeDelete: true)
                .ForeignKey("dbo.Konaklama", t => t.KonaklamaID, cascadeDelete: true)
                .ForeignKey("dbo.Universite", t => t.UniversiteID, cascadeDelete: true)
                .ForeignKey("dbo.YetkiKisi", t => t.YetkiKisiID, cascadeDelete: true)
                .Index(t => t.UniversiteID)
                .Index(t => t.KonaklamaID)
                .Index(t => t.IsImkanlariID)
                .Index(t => t.YetkiKisiID);
            
            CreateTable(
                "dbo.Konaklama",
                c => new
                    {
                        KonaklamaID = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 50),
                        Sehirler = c.String(nullable: false, maxLength: 15),
                        Fiyat = c.Double(nullable: false),
                        YurtmuEvmi = c.String(),
                        YakinlikUzaklik = c.Double(),
                        KızmıErkek = c.String(),
                        KisiSayısı = c.Int(),
                        Kaçoda = c.Int(),
                    })
                .PrimaryKey(t => t.KonaklamaID);
            
            CreateTable(
                "dbo.Universite",
                c => new
                    {
                        UniversiteID = c.Int(nullable: false, identity: true),
                        Ad = c.String(nullable: false, maxLength: 50),
                        Sehirler = c.String(nullable: false, maxLength: 15),
                        Bolum = c.String(maxLength: 25),
                    })
                .PrimaryKey(t => t.UniversiteID);
            
            CreateTable(
                "dbo.YetkiKisi",
                c => new
                    {
                        YetkiKisiID = c.Int(nullable: false),
                        YetkiAd = c.String(),
                    })
                .PrimaryKey(t => t.YetkiKisiID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Uye", "YetkiKisiID", "dbo.YetkiKisi");
            DropForeignKey("dbo.Uye", "UniversiteID", "dbo.Universite");
            DropForeignKey("dbo.Uye", "KonaklamaID", "dbo.Konaklama");
            DropForeignKey("dbo.Uye", "IsImkanlariID", "dbo.IsImkanlari");
            DropIndex("dbo.Uye", new[] { "YetkiKisiID" });
            DropIndex("dbo.Uye", new[] { "IsImkanlariID" });
            DropIndex("dbo.Uye", new[] { "KonaklamaID" });
            DropIndex("dbo.Uye", new[] { "UniversiteID" });
            DropTable("dbo.YetkiKisi");
            DropTable("dbo.Universite");
            DropTable("dbo.Konaklama");
            DropTable("dbo.Uye");
            DropTable("dbo.IsImkanlari");
        }
    }
}
