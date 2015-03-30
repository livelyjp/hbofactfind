namespace HboFactFind.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddedJointFieldsToPageEight : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PageEights", "JointRequiredEmergancyFund", c => c.String());
            AddColumn("dbo.PageEights", "JointPlannedExpenditure", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.PageEights", "JointPlannedExpenditure");
            DropColumn("dbo.PageEights", "JointRequiredEmergancyFund");
        }
    }
}
