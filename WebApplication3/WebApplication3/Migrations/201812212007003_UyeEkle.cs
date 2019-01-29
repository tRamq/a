namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UyeEkle : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Uye", "KalınacakZaman");
            DropColumn("dbo.Uye", "EvYurt");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Uye", "EvYurt", c => c.String(nullable: false));
            AddColumn("dbo.Uye", "KalınacakZaman", c => c.DateTime(nullable: false));
        }
    }
}
