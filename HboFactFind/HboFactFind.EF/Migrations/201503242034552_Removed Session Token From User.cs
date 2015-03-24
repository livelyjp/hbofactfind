namespace HboFactFind.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemovedSessionTokenFromUser : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.Users", "SessionToken");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Users", "SessionToken", c => c.String());
        }
    }
}
