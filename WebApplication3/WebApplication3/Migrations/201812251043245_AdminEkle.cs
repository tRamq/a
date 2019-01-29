namespace WebApplication3.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AdminEkle : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Uyeler", "Admin", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Uyeler", "Admin");
        }
    }
}
