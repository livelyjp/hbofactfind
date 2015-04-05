namespace HboFactFind.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Smallnameschanged : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PageTwoes", "ClientOneEmploymentStatusEnum", c => c.Int(nullable: false));
            AddColumn("dbo.PageTwoes", "ClientTwoStatusEnumEmploymentStatusEnum", c => c.Int(nullable: false));
            DropColumn("dbo.PageTwoes", "ClientOneEmploymentStatus");
            DropColumn("dbo.PageTwoes", "ClientTwoStatusEmploymentStatus");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PageTwoes", "ClientTwoStatusEmploymentStatus", c => c.Int(nullable: false));
            AddColumn("dbo.PageTwoes", "ClientOneEmploymentStatus", c => c.Int(nullable: false));
            DropColumn("dbo.PageTwoes", "ClientTwoStatusEnumEmploymentStatusEnum");
            DropColumn("dbo.PageTwoes", "ClientOneEmploymentStatusEnum");
        }
    }
}
