using System.ComponentModel;
using HboFactFind.Domain.Pages.Abstracts;

namespace HboFactFind.Domain.Pages
{
    public class PageNine : Page
    {
        [DisplayName("Personal Protection")]
        public int ClientOnePersonalProtectionPriority { get; set; }
        [DisplayName("Pension Planning")]
        public int ClientOnePensionPlanningPriority { get; set; }
        [DisplayName("Options At Retirement")]
        public int ClientOneOptionsAtRetirementPriority { get; set; }
        [DisplayName("Savings And Investments")]
        public int ClientOneSavingsAndInvestmentsPriority { get; set; }
        [DisplayName("Estate Planning")]
        public int ClientOneEstatePlanningPriority { get; set; }
        [DisplayName("Mortgage Needs")]
        public int ClientOneMortgageNeedsPriority { get; set; }
        [DisplayName("Equity Release")]
        public int ClientOneEquityReleasePriority { get; set; }
        [DisplayName("Long Term Care")]
        public int ClientOneLongTermCarePriority { get; set; }
        [DisplayName("Generate Insurance Needs")]
        public int ClientOneGeneralInsuranceNeedsPriority { get; set; }
        [DisplayName("Notes")]
        public string Notes { get; set; }

        public int ClientTwoPersonalProtectionPriority { get; set; }
        public int ClientTwoPensionPlanningPriority { get; set; }
        public int ClientTwoOptionsAtRetirementPriority { get; set; }
        public int ClientTwoSavingsAndInvestmentsPriority { get; set; }
        public int ClientTwoEstatePlanningPriority { get; set; }
        public int ClientTwoMortgageNeedsPriority { get; set; }
        public int ClientTwoEquityReleasePriority { get; set; }
        public int ClientTwoLongTermCarePriority { get; set; }
        public int ClientTwoGeneralInsuranceNeedsPriority { get; set; }
    }
}