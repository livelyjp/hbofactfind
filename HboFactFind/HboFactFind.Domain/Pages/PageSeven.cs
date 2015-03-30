using System.Collections.Generic;
using System.ComponentModel;
using HboFactFind.Domain.Pages.Abstracts;
using HboFactFind.Domain.Questions;

namespace HboFactFind.Domain.Pages
{
    public class PageSeven : Page
    {
        [DisplayName("Home")]
        public decimal ClientOneHome { get; set; }
        [DisplayName("Other Property")]
        public decimal ClientOneOtherProperty { get; set; }
        [DisplayName("Cash/Deposits")]
        public decimal ClientOneCashDeposits { get; set; }
        [DisplayName("Investment Bonds")]
        public decimal ClientOneInvestmentBonds { get; set; }
        [DisplayName("Pension Funds")]
        public decimal ClientOnePensionFunds { get; set; }
        [DisplayName("ISA")]
        public decimal ClientOneIsa { get; set; }
        [DisplayName("Collectives*")]
        public decimal ClientOneCollectives { get; set; }
        [DisplayName("Shares")]
        public decimal ClientOneShares { get; set; }
        [DisplayName("Buisness Assets")]
        public decimal ClientOneBuisnessAssets { get; set; }
        [DisplayName("Other Assets")]
        public decimal ClientOneOtherAssets { get; set; }
        [DisplayName("Total Assests")]
        public decimal ClientOneTotalAssets { get; set; }

        [DisplayName("Main Mortgage")]
        public decimal ClientOneMainMortgage { get; set; }
        [DisplayName("Credit Cards")]
        public decimal ClientOneCreditCards { get; set; }
        [DisplayName("Overdraft")]
        public decimal ClientOneOverdraft { get; set; }
        [DisplayName("Loans/HP")]
        public decimal ClientOneLoansHp { get; set; }
        [DisplayName("Mortgage (Other Property")]
        public decimal ClientOneOtherMortgage { get; set; }
        [DisplayName("Any Other Lending")]
        public decimal ClientOneOtherLending { get; set; }
        [DisplayName("Total Debt")]
        public decimal ClientOneTotalDebt { get; set; }

        public decimal ClientTwoHome { get; set; }
        public decimal ClientTwoOtherProperty { get; set; }
        public decimal ClientTwoCashDeposits { get; set; }
        public decimal ClientTwoInvestmentBonds { get; set; }
        public decimal ClientTwoPensionFunds { get; set; }
        public decimal ClientTwoIsa { get; set; }
        public decimal ClientTwoCollectives { get; set; }
        public decimal ClientTwoShares { get; set; }
        public decimal ClientTwoBuisnessAssets { get; set; }
        public decimal ClientTwoOtherAssets { get; set; }
        public decimal ClientTwoTotalAssets { get; set; }

        public decimal ClientTwoMainMortgage { get; set; }
        public decimal ClientTwoCreditCards { get; set; }
        public decimal ClientTwoOverdraft { get; set; }
        public decimal ClientTwoLoansHp { get; set; }
        public decimal ClientTwoOtherMortgage { get; set; }
        public decimal ClientTwoOtherLending { get; set; }
        public decimal ClientTwoTotalDebt { get; set; }


        public decimal JointHome { get; set; }
        public decimal JointOtherProperty { get; set; }
        public decimal JointCashDeposits { get; set; }
        public decimal JointInvestmentBonds { get; set; }
        public decimal JointPensionFunds { get; set; }
        public decimal JointIsa { get; set; }
        public decimal JointCollectives { get; set; }
        public decimal JointShares { get; set; }
        public decimal JointBuisnessAssets { get; set; }
        public decimal JointOtherAssets { get; set; }
        public decimal JointTotalAssets { get; set; }

        public decimal JointMainMortgage { get; set; }
        public decimal JointCreditCards { get; set; }
        public decimal JointOverdraft { get; set; }
        public decimal JointLoansHp { get; set; }
        public decimal JointOtherMortgage { get; set; }
        public decimal JointOtherLending { get; set; }
        public decimal JointTotalDebt { get; set; }

        public virtual List<BreakDownOfLiabilities> BreakDownOfLiabilitieses { get; set; }
        [DisplayName("Notes")]
        public string AssetsNotes { get; set; }

        public PageSeven()
        {
            BreakDownOfLiabilitieses = new List<BreakDownOfLiabilities>();
        }
    }
}