using System.Data.Entity.Migrations;

namespace HboFactFind.EF.Migrations
{
    public partial class AddedJointfieldstoPageSeven : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.PageSevens", "JointHome", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSevens", "JointOtherProperty", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSevens", "JointCashDeposits", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSevens", "JointInvestmentBonds", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSevens", "JointPensionFunds", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSevens", "JointIsa", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSevens", "JointCollectives", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSevens", "JointShares", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSevens", "JointBuisnessAssets", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSevens", "JointOtherAssets", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSevens", "JointTotalAssets", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSevens", "JointMainMortgage", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSevens", "JointCreditCards", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSevens", "JointOverdraft", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSevens", "JointLoansHp", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSevens", "JointOtherMortgage", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSevens", "JointOtherLending", c => c.Decimal(false, 18, 2));
            AddColumn("dbo.PageSevens", "JointTotalDebt", c => c.Decimal(false, 18, 2));
        }

        public override void Down()
        {
            DropColumn("dbo.PageSevens", "JointTotalDebt");
            DropColumn("dbo.PageSevens", "JointOtherLending");
            DropColumn("dbo.PageSevens", "JointOtherMortgage");
            DropColumn("dbo.PageSevens", "JointLoansHp");
            DropColumn("dbo.PageSevens", "JointOverdraft");
            DropColumn("dbo.PageSevens", "JointCreditCards");
            DropColumn("dbo.PageSevens", "JointMainMortgage");
            DropColumn("dbo.PageSevens", "JointTotalAssets");
            DropColumn("dbo.PageSevens", "JointOtherAssets");
            DropColumn("dbo.PageSevens", "JointBuisnessAssets");
            DropColumn("dbo.PageSevens", "JointShares");
            DropColumn("dbo.PageSevens", "JointCollectives");
            DropColumn("dbo.PageSevens", "JointIsa");
            DropColumn("dbo.PageSevens", "JointPensionFunds");
            DropColumn("dbo.PageSevens", "JointInvestmentBonds");
            DropColumn("dbo.PageSevens", "JointCashDeposits");
            DropColumn("dbo.PageSevens", "JointOtherProperty");
            DropColumn("dbo.PageSevens", "JointHome");
        }
    }
}