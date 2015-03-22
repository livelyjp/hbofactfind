using HboFactFind.Domain.Enums;
using HboFactFind.Domain.Pages.Abstracts;

namespace HboFactFind.Domain.Pages
{
    public class PageFive : Page
    {
        public decimal GrossEmploymentIncome { get; set; }
        public decimal GrossSelfEmploymentIncome { get; set; }
        public decimal GroddPrivatePensionIncome { get; set; }
        public decimal GrossStatePension { get; set; }
        public decimal AdditionalIncome { get; set; }
        public decimal TotalAnnualIncome { get; set; }
        public decimal TotalGrossMonthlyIncome { get; set; }
        public decimal TotalNetMonthlyIncome { get; set; }
        public TaxRateEnum TaxRate { get; set; }
        public bool AnyChangesToIncome { get; set; }
        public bool AnyChangesToTax { get; set; }
        public string IncomeNotes { get; set; }
    }
}