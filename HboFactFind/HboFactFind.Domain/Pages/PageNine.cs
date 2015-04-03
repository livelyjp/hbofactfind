using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using HboFactFind.Domain.Pages.Abstracts;

namespace HboFactFind.Domain.Pages
{
    public class PageNine : Page
    {
        [Range(0,5)]
        [DisplayName("Personal Protection")]
        public int ClientOnePersonalProtectionPriority { get; set; }
        [Range(0, 5)]
        [DisplayName("Pension Planning")]
        public int ClientOnePensionPlanningPriority { get; set; }
        [Range(0, 5)]
        [DisplayName("Options At Retirement")]
        public int ClientOneOptionsAtRetirementPriority { get; set; }
        [Range(0, 5)]
        [DisplayName("Savings And Investments")]
        public int ClientOneSavingsAndInvestmentsPriority { get; set; }
        [Range(0,5)]
        [DisplayName("Estate Planning")]
        public int ClientOneEstatePlanningPriority { get; set; }
        [Range(0, 5)]
        [DisplayName("Mortgage Needs")]
        public int ClientOneMortgageNeedsPriority { get; set; }
        [Range(0, 5)]
        [DisplayName("Equity Release")]
        public int ClientOneEquityReleasePriority { get; set; }
        [Range(0, 5)]
        [DisplayName("Long Term Care")]
        public int ClientOneLongTermCarePriority { get; set; }
        [Range(0, 5)]
        [DisplayName("Generate Insurance Needs")]
        public int ClientOneGeneralInsuranceNeedsPriority { get; set; }
        [DisplayName("Notes")]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        [Range(0, 5)]
        public int ClientTwoPersonalProtectionPriority { get; set; }
        [Range(0, 5)]
        public int ClientTwoPensionPlanningPriority { get; set; }
        [Range(0, 5)]
        public int ClientTwoOptionsAtRetirementPriority { get; set; }
        [Range(0, 5)]
        public int ClientTwoSavingsAndInvestmentsPriority { get; set; }
        [Range(0, 5)]
        public int ClientTwoEstatePlanningPriority { get; set; }
        [Range(0, 5)]
        public int ClientTwoMortgageNeedsPriority { get; set; }
        [Range(0, 5)]
        public int ClientTwoEquityReleasePriority { get; set; }
        [Range(0, 5)]
        public int ClientTwoLongTermCarePriority { get; set; }
        [Range(0, 5)]
        public int ClientTwoGeneralInsuranceNeedsPriority { get; set; }
    }
}