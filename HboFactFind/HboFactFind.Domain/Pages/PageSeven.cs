using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using HboFactFind.Domain.Pages.Abstracts;
using HboFactFind.Domain.Questions;

namespace HboFactFind.Domain.Pages
{
    public class PageSeven : Page
    {
        public PageSeven()
        {
            BreakDownOfLiabilitieses = new List<BreakDownOfLiabilities>();
        }

        [DisplayName("Home")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientOneHome { get; set; }

        [DisplayName("Other Property")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientOneOtherProperty { get; set; }

        [DisplayName("Cash/Deposits")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientOneCashDeposits { get; set; }

        [DisplayName("Investment Bonds")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientOneInvestmentBonds { get; set; }

        [DisplayName("Pension Funds")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientOnePensionFunds { get; set; }

        [DisplayName("ISA")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientOneIsa { get; set; }

        [DisplayName("Collectives*")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientOneCollectives { get; set; }

        [DisplayName("Shares")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientOneShares { get; set; }

        [DisplayName("Buisness Assets")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientOneBuisnessAssets { get; set; }

        [DisplayName("Other Assets")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientOneOtherAssets { get; set; }

        [DisplayName("Total Assests")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientOneTotalAssets { get; set; }

        [DisplayName("Main Mortgage")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientOneMainMortgage { get; set; }

        [DisplayName("Credit Cards")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientOneCreditCards { get; set; }

        [DisplayName("Overdraft")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientOneOverdraft { get; set; }

        [DisplayName("Loans/HP")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientOneLoansHp { get; set; }

        [DisplayName("Mortgage (Other Property")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientOneOtherMortgage { get; set; }

        [DisplayName("Any Other Lending")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientOneOtherLending { get; set; }

        [DisplayName("Total Debt")]
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientOneTotalDebt { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoHome { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoOtherProperty { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoCashDeposits { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoInvestmentBonds { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoPensionFunds { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoIsa { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoCollectives { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoShares { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoBuisnessAssets { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoOtherAssets { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoTotalAssets { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoMainMortgage { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoCreditCards { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoOverdraft { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoLoansHp { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoOtherMortgage { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoOtherLending { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoTotalDebt { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointHome { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointOtherProperty { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointCashDeposits { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointInvestmentBonds { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointPensionFunds { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointIsa { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointCollectives { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointShares { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointBuisnessAssets { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointOtherAssets { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointTotalAssets { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointMainMortgage { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointCreditCards { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointOverdraft { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointLoansHp { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointOtherMortgage { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointOtherLending { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointTotalDebt { get; set; }

        public virtual List<BreakDownOfLiabilities> BreakDownOfLiabilitieses { get; set; }

        [DisplayName("Notes")]
        public string AssetsNotes { get; set; }
    }
}