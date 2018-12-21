namespace Projekat_20_dec_v_2.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Baza2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Obrazac", "oznaka_tipa_mail", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Obrazac", "oznaka_tipa_mail", c => c.String(nullable: false));
        }
    }
}
