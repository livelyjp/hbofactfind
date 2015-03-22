using HboFactFind.Domain.Pages.Abstracts;

namespace HboFactFind.Domain.Pages
{
    public class PageSix : Page
    {
        public decimal MortageRent { get; set; }
        public decimal CouncilTax { get; set; }
        public decimal Utilities { get; set; }
        public decimal FoodShopping { get; set; }
        public decimal TvSateliteCableInternet { get; set; }
        public decimal Phone { get; set; }
        public decimal Transportation { get; set; }
        public decimal Financials { get; set; }
        public decimal LoansCreditStoreCardRepayments { get; set; }
        public decimal Savings { get; set; }
        public decimal Insurance { get; set; }
        public decimal PensionContributions { get; set; }
        public decimal Miscellaneious { get; set; }
        public decimal Holidays { get; set; }
        public decimal RegularSubscriptions { get; set; }
        public decimal Clothing { get; set; }
        public decimal Other { get; set; }
        public decimal TotalOutgoings { get; set; }
        public decimal SurplusIncome { get; set; }
        public decimal FinancialGoalCommitment { get; set; }
        public string OutGoingsNotes { get; set; }
    }
}