namespace Projekat_20_dec_v_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Baza1 : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Obrazac", "oznaka_tipa", c => c.String(nullable: false));
            AddColumn("dbo.Obrazac", "oznaka_tipa_mail", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Obrazac", "oznaka_tipa_mail");
            DropColumn("dbo.Obrazac", "oznaka_tipa");
        }
    }
}
