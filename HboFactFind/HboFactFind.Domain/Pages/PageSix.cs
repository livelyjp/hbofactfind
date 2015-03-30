using System.ComponentModel;
using HboFactFind.Domain.Pages.Abstracts;

namespace HboFactFind.Domain.Pages
{
    public class PageSix : Page
    {
        [DisplayName("Mortgage/Rent")]
        public decimal ClientOneMortageRent { get; set; }
        [DisplayName("Council Tax")]
        public decimal ClientOneCouncilTax { get; set; }
        [DisplayName("Utilites")]
        public decimal ClientOneUtilities { get; set; }
        [DisplayName("Food Shopping")]
        public decimal ClientOneFoodShopping { get; set; }
        [DisplayName("Tv/Satelite/Cable/Internet")]
        public decimal ClientOneTvSateliteCableInternet { get; set; }
        [DisplayName("Phone")]
        public decimal ClientOnePhone { get; set; }
        [DisplayName("Transportation Costs")]
        public decimal ClientOneTransportation { get; set; }
        [DisplayName("Financials")]
        public decimal ClientOneFinancials { get; set; }
        [DisplayName("Loans/Credit/Store Card Repayments")]
        public decimal ClientOneLoansCreditStoreCardRepayments { get; set; }
        [DisplayName("Savings")]
        public decimal ClientOneSavings { get; set; }
        [DisplayName("Insurance")]
        public decimal ClientOneInsurance { get; set; }
        [DisplayName("Pension Contributions")]
        public decimal ClientOnePensionContributions { get; set; }
        [DisplayName("Miscellaneous")]
        public decimal ClientOneMiscellaneious { get; set; }
        [DisplayName("Holidays")]
        public decimal ClientOneHolidays { get; set; }
        [DisplayName("Regular Subscriptions")]
        public decimal ClientOneRegularSubscriptions { get; set; }
        [DisplayName("Clothing")]
        public decimal ClientOneClothing { get; set; }
        [DisplayName("Other*")]
        public decimal ClientOneOther { get; set; }
        [DisplayName("Total Outgoings")]
        public decimal ClientOneTotalOutgoings { get; set; }
        [DisplayName("Surplus Income")]
        public decimal ClientOneSurplusIncome { get; set; }
        [DisplayName("How Much Would You Like To Commit To Your Financial Goals")]
        public decimal ClientOneFinancialGoalCommitment { get; set; }

        public decimal ClientTwoMortageRent { get; set; }
        public decimal ClientTwoCouncilTax { get; set; }
        public decimal ClientTwoUtilities { get; set; }
        public decimal ClientTwoFoodShopping { get; set; }
        public decimal ClientTwoTvSateliteCableInternet { get; set; }
        public decimal ClientTwoPhone { get; set; }
        public decimal ClientTwoTransportation { get; set; }
        public decimal ClientTwoFinancials { get; set; }
        public decimal ClientTwoLoansCreditStoreCardRepayments { get; set; }
        public decimal ClientTwoSavings { get; set; }
        public decimal ClientTwoInsurance { get; set; }
        public decimal ClientTwoPensionContributions { get; set; }
        public decimal ClientTwoMiscellaneious { get; set; }
        public decimal ClientTwoHolidays { get; set; }
        public decimal ClientTwoRegularSubscriptions { get; set; }
        public decimal ClientTwoClothing { get; set; }
        public decimal ClientTwoOther { get; set; }
        public decimal ClientTwoTotalOutgoings { get; set; }
        public decimal ClientTwoSurplusIncome { get; set; }
        public decimal ClientTwoFinancialGoalCommitment { get; set; }

        public decimal JointMortageRent { get; set; }
        public decimal JointCouncilTax { get; set; }
        public decimal JointUtilities { get; set; }
        public decimal JointFoodShopping { get; set; }
        public decimal JointTvSateliteCableInternet { get; set; }
        public decimal JointPhone { get; set; }
        public decimal JointTransportation { get; set; }
        public decimal JointFinancials { get; set; }
        public decimal JointLoansCreditStoreCardRepayments { get; set; }
        public decimal JointSavings { get; set; }
        public decimal JointInsurance { get; set; }
        public decimal JointPensionContributions { get; set; }
        public decimal JointMiscellaneious { get; set; }
        public decimal JointHolidays { get; set; }
        public decimal JointRegularSubscriptions { get; set; }
        public decimal JointClothing { get; set; }
        public decimal JointOther { get; set; }
        public decimal JointTotalOutgoings { get; set; }
        public decimal JointSurplusIncome { get; set; }
        public decimal JointFinancialGoalCommitment { get; set; }

        [DisplayName("Notes")]
        public string OutGoingsNotes { get; set; }
    }
}