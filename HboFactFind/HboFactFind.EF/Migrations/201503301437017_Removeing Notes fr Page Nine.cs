namespace HboFactFind.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveingNotesfrPageNine : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PageNines", "Notes", c => c.String());
            AddColumn("dbo.PageTens", "Notes", c => c.String());
            DropColumn("dbo.PageNines", "ClientOnePrioritiesNotes");
            DropColumn("dbo.PageNines", "ClientTwoPrioritiesNotes");
            DropColumn("dbo.PageTens", "ExistingPlansNotes");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PageTens", "ExistingPlansNotes", c => c.String());
            AddColumn("dbo.PageNines", "ClientTwoPrioritiesNotes", c => c.String());
            AddColumn("dbo.PageNines", "ClientOnePrioritiesNotes", c => c.String());
            DropColumn("dbo.PageTens", "Notes");
            DropColumn("dbo.PageNines", "Notes");
        }
    }
}
