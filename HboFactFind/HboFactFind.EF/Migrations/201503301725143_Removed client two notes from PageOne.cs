using System.Data.Entity.Migrations;

namespace HboFactFind.EF.Migrations
{
    public partial class RemovedclienttwonotesfromPageOne : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.PageOnes", "ClientTwoExtraInformation");
        }

        public override void Down()
        {
            AddColumn("dbo.PageOnes", "ClientTwoExtraInformation", c => c.String());
        }
    }
}