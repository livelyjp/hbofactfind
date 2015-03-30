namespace HboFactFind.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddednotesforPageOne : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PageOnes", "Notes", c => c.String());
            DropColumn("dbo.PageOnes", "ClientOneExtraInformation");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PageOnes", "ClientOneExtraInformation", c => c.String());
            DropColumn("dbo.PageOnes", "Notes");
        }
    }
}
