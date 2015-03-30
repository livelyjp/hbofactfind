using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using HboFactFind.Domain.Pages.Abstracts;

namespace HboFactFind.Domain.Pages
{
    public class PageSix : Page
    {
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Mortgage/Rent")]
        public decimal ClientOneMortageRent { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Council Tax")]
        public decimal ClientOneCouncilTax { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Utilites")]
        public decimal ClientOneUtilities { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Food Shopping")]
        public decimal ClientOneFoodShopping { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Tv/Satelite/Cable/Internet")]
        public decimal ClientOneTvSateliteCableInternet { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Phone")]
        public decimal ClientOnePhone { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Transportation Costs")]
        public decimal ClientOneTransportation { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Financials")]
        public decimal ClientOneFinancials { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Loans/Credit/Store Card Repayments")]
        public decimal ClientOneLoansCreditStoreCardRepayments { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Savings")]
        public decimal ClientOneSavings { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Insurance")]
        public decimal ClientOneInsurance { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Pension Contributions")]
        public decimal ClientOnePensionContributions { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Miscellaneous")]
        public decimal ClientOneMiscellaneious { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Holidays")]
        public decimal ClientOneHolidays { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Regular Subscriptions")]
        public decimal ClientOneRegularSubscriptions { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Clothing")]
        public decimal ClientOneClothing { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Other*")]
        public decimal ClientOneOther { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Total Outgoings")]
        public decimal ClientOneTotalOutgoings { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Surplus Income")]
        public decimal ClientOneSurplusIncome { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("How Much Would You Like To Commit To Your Financial Goals")]
        public decimal ClientOneFinancialGoalCommitment { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoMortageRent { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoCouncilTax { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoUtilities { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoFoodShopping { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoTvSateliteCableInternet { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoPhone { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoTransportation { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoFinancials { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoLoansCreditStoreCardRepayments { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoSavings { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoInsurance { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoPensionContributions { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoMiscellaneious { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoHolidays { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoRegularSubscriptions { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoClothing { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoOther { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoTotalOutgoings { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoSurplusIncome { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoFinancialGoalCommitment { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointMortageRent { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointCouncilTax { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointUtilities { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointFoodShopping { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointTvSateliteCableInternet { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointPhone { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointTransportation { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointFinancials { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointLoansCreditStoreCardRepayments { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointSavings { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointInsurance { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointPensionContributions { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointMiscellaneious { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointHolidays { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointRegularSubscriptions { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointClothing { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointOther { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointTotalOutgoings { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointSurplusIncome { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal JointFinancialGoalCommitment { get; set; }

        [DisplayName("Notes")]
        [DataType(DataType.MultilineText)]
        public string OutGoingsNotes { get; set; }
    }
}