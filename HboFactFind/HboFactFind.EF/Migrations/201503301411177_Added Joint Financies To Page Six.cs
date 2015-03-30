using System.Data.Entity.Migrations;

namespace HboFactFind.EF.Migrations
{
    public partial class AddedJointFinanciesToPageSix : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PageFives", "IncomeNotes", c => c.String());
            AddColumn("dbo.PageSixes", "JointMortageRent", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSixes", "JointCouncilTax", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSixes", "JointUtilities", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSixes", "JointFoodShopping", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSixes", "JointTvSateliteCableInternet", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSixes", "JointPhone", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSixes", "JointTransportation", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSixes", "JointFinancials", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSixes", "JointLoansCreditStoreCardRepayments", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSixes", "JointSavings", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSixes", "JointInsurance", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSixes", "JointPensionContributions", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSixes", "JointMiscellaneious", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSixes", "JointHolidays", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSixes", "JointRegularSubscriptions", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSixes", "JointClothing", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSixes", "JointOther", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSixes", "JointTotalOutgoings", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSixes", "JointSurplusIncome", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSixes", "JointFinancialGoalCommitment", c => c.Decimal(false, 18, 2));
            DropColumn("dbo.PageFives", "ClientOneIncomeNotes");
            DropColumn("dbo.PageFives", "ClientTwoIncomeNotes");
        }

        public override void Down()
        {
            AddColumn("dbo.PageFives", "ClientTwoIncomeNotes", c => c.String());
            AddColumn("dbo.PageFives", "ClientOneIncomeNotes", c => c.String());
            DropColumn("dbo.PageSixes", "JointFinancialGoalCommitment");
            DropColumn("dbo.PageSixes", "JointSurplusIncome");
            DropColumn("dbo.PageSixes", "JointTotalOutgoings");
            DropColumn("dbo.PageSixes", "JointOther");
            DropColumn("dbo.PageSixes", "JointClothing");
            DropColumn("dbo.PageSixes", "JointRegularSubscriptions");
            DropColumn("dbo.PageSixes", "JointHolidays");
            DropColumn("dbo.PageSixes", "JointMiscellaneious");
            DropColumn("dbo.PageSixes", "JointPensionContributions");
            DropColumn("dbo.PageSixes", "JointInsurance");
            DropColumn("dbo.PageSixes", "JointSavings");
            DropColumn("dbo.PageSixes", "JointLoansCreditStoreCardRepayments");
            DropColumn("dbo.PageSixes", "JointFinancials");
            DropColumn("dbo.PageSixes", "JointTransportation");
            DropColumn("dbo.PageSixes", "JointPhone");
            DropColumn("dbo.PageSixes", "JointTvSateliteCableInternet");
            DropColumn("dbo.PageSixes", "JointFoodShopping");
            DropColumn("dbo.PageSixes", "JointUtilities");
            DropColumn("dbo.PageSixes", "JointCouncilTax");
            DropColumn("dbo.PageSixes", "JointMortageRent");
            DropColumn("dbo.PageFives", "IncomeNotes");
        }
    }
}