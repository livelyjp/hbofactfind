namespace HboFactFind.EF.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Correctedspellingmistake : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PageFives", "ClientOneGrossPrivatePensionIncome", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.PageFives", "ClientTwoGrossPrivatePensionIncome", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.PageFives", "ClientOneGroddPrivatePensionIncome");
            DropColumn("dbo.PageFives", "ClientTwoGroddPrivatePensionIncome");
        }
        
        public override void Down()
        {
            AddColumn("dbo.PageFives", "ClientTwoGroddPrivatePensionIncome", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            AddColumn("dbo.PageFives", "ClientOneGroddPrivatePensionIncome", c => c.Decimal(nullable: false, precision: 18, scale: 2));
            DropColumn("dbo.PageFives", "ClientTwoGrossPrivatePensionIncome");
            DropColumn("dbo.PageFives", "ClientOneGrossPrivatePensionIncome");
        }
    }
}
