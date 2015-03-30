using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using HboFactFind.Domain.Enums;
using HboFactFind.Domain.Pages.Abstracts;

namespace HboFactFind.Domain.Pages
{
    public class PageFive : Page
    {
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Gross Employment Income(Pa)")]
        public decimal ClientOneGrossEmploymentIncome { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Gross Income From Self Employment")]
        public decimal ClientOneGrossSelfEmploymentIncome { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Gross Private Pension Income (Pa)")]
        public decimal ClientOneGrossPrivatePensionIncome { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Gross State Pension (Pa")]
        public decimal ClientOneGrossStatePension { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Any Additional Received")]
        public decimal ClientOneAdditionalIncome { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Total Annual Income (Gross)")]
        public decimal ClientOneTotalAnnualIncome { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Total Montly Income (Gross)")]
        public decimal ClientOneTotalGrossMonthlyIncome { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Total Monthly Income (Net)")]
        public decimal ClientOneTotalNetMonthlyIncome { get; set; }
        [DisplayName("Highest Rate Of Tax Paid")]
        public TaxRateEnum ClientOneTaxRate { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Any Changes In Income Or Employment Status?")]
        public bool ClientOneAnyChangesToIncome { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        [DisplayName("Any Changes To Tax Status In Future")]
        public bool ClientOneAnyChangesToTax { get; set; }
        [DisplayName("Notes")]
        [DataType(DataType.MultilineText)]
        public string IncomeNotes { get; set; }

        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoGrossEmploymentIncome { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoGrossSelfEmploymentIncome { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoGrossPrivatePensionIncome { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoGrossStatePension { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoAdditionalIncome { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoTotalAnnualIncome { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoTotalGrossMonthlyIncome { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal ClientTwoTotalNetMonthlyIncome { get; set; }
        public TaxRateEnum ClientTwoTaxRate { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public bool ClientTwoAnyChangesToIncome { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public bool ClientTwoAnyChangesToTax { get; set; }
    }
}