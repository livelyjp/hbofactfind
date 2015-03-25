using System.Collections.Generic;
using HboFactFind.Domain.Pages.Abstracts;
using HboFactFind.Domain.Questions;

namespace HboFactFind.Domain.Pages
{
    public class PageSeven : Page
    {
        public decimal ClientOneHome { get; set; }
        public decimal ClientOneOtherProperty { get; set; }
        public decimal ClientOneCashDeposits { get; set; }
        public decimal ClientOneInvestmentBonds { get; set; }
        public decimal ClientOnePensionFunds { get; set; }
        public decimal ClientOneIsa { get; set; }
        public decimal ClientOneCollectives { get; set; }
        public decimal ClientOneShares { get; set; }
        public decimal ClientOneBuisnessAssets { get; set; }
        public decimal ClientOneOtherAssets { get; set; }
        public decimal ClientOneTotalAssets { get; set; }

        public decimal ClientOneMainMortgage { get; set; }
        public decimal ClientOneCreditCards { get; set; }
        public decimal ClientOneOverdraft { get; set; }
        public decimal ClientOneLoansHp { get; set; }
        public decimal ClientOneOtherMortgage { get; set; }
        public decimal ClientOneOtherLending { get; set; }
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


        public virtual List<BreakDownOfLiabilities> BreakDownOfLiabilitieses { get; set; }
        public string AssetsNotes { get; set; }

        public PageSeven()
        {
            BreakDownOfLiabilitieses = new List<BreakDownOfLiabilities>();
        }
    }
}