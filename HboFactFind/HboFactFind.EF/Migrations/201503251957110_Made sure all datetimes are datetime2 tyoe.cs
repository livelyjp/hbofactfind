using System.Data.Entity.Migrations;

namespace HboFactFind.EF.Migrations
{
    public partial class Madesurealldatetimesaredatetime2tyoe : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.BreakDownOfLiabilities", "RepaymentDate", c => c.DateTime(false, 7, storeType: "datetime2"));
            AlterColumn("dbo.FinancialDependants", "DateOfBirth", c => c.DateTime(false, 7, storeType: "datetime2"));
            AlterColumn("dbo.NonFinancialDependants", "DateOfBirth", c => c.DateTime(false, 7, storeType: "datetime2"));
            AlterColumn("dbo.PageOnes", "ClientOneDateOfBirth", c => c.DateTime(false, 7, storeType: "datetime2"));
            AlterColumn("dbo.PageOnes", "ClientTwoDateOfBirth", c => c.DateTime(false, 7, storeType: "datetime2"));
            AlterColumn("dbo.PageTwoes", "ClientOneEmploymentStartDate",
                c => c.DateTime(false, 7, storeType: "datetime2"));
            AlterColumn("dbo.PageTwoes", "ClientTwoEmploymentStartDate",
                c => c.DateTime(false, 7, storeType: "datetime2"));
        }

        public override void Down()
        {
            AlterColumn("dbo.PageTwoes", "ClientTwoEmploymentStartDate", c => c.DateTime(false));
            AlterColumn("dbo.PageTwoes", "ClientOneEmploymentStartDate", c => c.DateTime(false));
            AlterColumn("dbo.PageOnes", "ClientTwoDateOfBirth", c => c.DateTime(false));
            AlterColumn("dbo.PageOnes", "ClientOneDateOfBirth", c => c.DateTime(false));
            AlterColumn("dbo.NonFinancialDependants", "DateOfBirth", c => c.DateTime(false));
            AlterColumn("dbo.FinancialDependants", "DateOfBirth", c => c.DateTime(false));
            AlterColumn("dbo.BreakDownOfLiabilities", "RepaymentDate", c => c.DateTime(false));
        }
    }
}