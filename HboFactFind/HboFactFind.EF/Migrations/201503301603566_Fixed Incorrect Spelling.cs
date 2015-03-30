namespace HboFactFind.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class FixedIncorrectSpelling : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PageEights", "JointPlannedExpenditure", c => c.String());
            DropColumn("dbo.PageEights", "JointlannedExpenditure");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PageEights", "JointlannedExpenditure", c => c.String());
            DropColumn("dbo.PageEights", "JointPlannedExpenditure");
        }
    }
}
