using HboFactFind.Domain.Enums;
using HboFactFind.Domain.Pages.Abstracts;

namespace HboFactFind.Domain.Pages
{
    public class PageFive : Page
    {
        public decimal ClientOneGrossEmploymentIncome { get; set; }
        public decimal ClientOneGrossSelfEmploymentIncome { get; set; }
        public decimal ClientOneGrossPrivatePensionIncome { get; set; }
        public decimal ClientOneGrossStatePension { get; set; }
        public decimal ClientOneAdditionalIncome { get; set; }
        public decimal ClientOneTotalAnnualIncome { get; set; }
        public decimal ClientOneTotalGrossMonthlyIncome { get; set; }
        public decimal ClientOneTotalNetMonthlyIncome { get; set; }
        public TaxRateEnum ClientOneTaxRate { get; set; }
        public bool ClientOneAnyChangesToIncome { get; set; }
        public bool ClientOneAnyChangesToTax { get; set; }
        public string ClientOneIncomeNotes { get; set; }

        public decimal ClientTwoGrossEmploymentIncome { get; set; }
        public decimal ClientTwoGrossSelfEmploymentIncome { get; set; }
        public decimal ClientTwoGrossPrivatePensionIncome { get; set; }
        public decimal ClientTwoGrossStatePension { get; set; }
        public decimal ClientTwoAdditionalIncome { get; set; }
        public decimal ClientTwoTotalAnnualIncome { get; set; }
        public decimal ClientTwoTotalGrossMonthlyIncome { get; set; }
        public decimal ClientTwoTotalNetMonthlyIncome { get; set; }
        public TaxRateEnum ClientTwoTaxRate { get; set; }
        public bool ClientTwoAnyChangesToIncome { get; set; }
        public bool ClientTwoAnyChangesToTax { get; set; }
        public string ClientTwoIncomeNotes { get; set; }
    }
}