namespace HboFactFind.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedUnneededclienttwonotesfromPageEight : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PageEights", "Notes", c => c.String());
            DropColumn("dbo.PageEights", "ClientOneWillNotes");
            DropColumn("dbo.PageEights", "ClientTwoWillNotes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PageEights", "ClientTwoWillNotes", c => c.String());
            AddColumn("dbo.PageEights", "ClientOneWillNotes", c => c.String());
            DropColumn("dbo.PageEights", "Notes");
        }
    }
}
