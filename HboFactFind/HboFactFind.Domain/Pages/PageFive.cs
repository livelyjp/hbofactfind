using System.ComponentModel;
using HboFactFind.Domain.Enums;
using HboFactFind.Domain.Pages.Abstracts;

namespace HboFactFind.Domain.Pages
{
    public class PageFive : Page
    {
        [DisplayName("Gross Employment Income(Pa)")]
        public decimal ClientOneGrossEmploymentIncome { get; set; }
        [DisplayName("Gross Income From Self Employment")]
        public decimal ClientOneGrossSelfEmploymentIncome { get; set; }
        [DisplayName("Gross Private Pension Income (Pa)")]
        public decimal ClientOneGrossPrivatePensionIncome { get; set; }
        [DisplayName("Gross State Pension (Pa")]
        public decimal ClientOneGrossStatePension { get; set; }
        [DisplayName("Any Additional Received")]
        public decimal ClientOneAdditionalIncome { get; set; }
        [DisplayName("Total Annual Income (Gross)")]
        public decimal ClientOneTotalAnnualIncome { get; set; }
        [DisplayName("Total Montly Income (Gross)")]
        public decimal ClientOneTotalGrossMonthlyIncome { get; set; }
        [DisplayName("Total Monthly Income (Net)")]
        public decimal ClientOneTotalNetMonthlyIncome { get; set; }
        [DisplayName("Highest Rate Of Tax Paid")]
        public TaxRateEnum ClientOneTaxRate { get; set; }
        [DisplayName("Any Changes In Income Or Employment Status?")]
        public bool ClientOneAnyChangesToIncome { get; set; }
        [DisplayName("Any Changes To Tax Status In Future")]
        public bool ClientOneAnyChangesToTax { get; set; }
        [DisplayName("Notes")]
        public string IncomeNotes { get; set; }

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
    }
}