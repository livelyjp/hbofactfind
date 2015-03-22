using HboFactFind.Domain.Pages.Abstracts;

namespace HboFactFind.Domain.Pages
{
    public class PageNine : Page
    {
        public int PersonalProtectionPriority { get; set; }
        public int PensionPlanningPriority { get; set; }
        public int OptionsAtRetirementPriority { get; set; }
        public int SavingsAndInvestmentsPriority { get; set; }
        public int EstatePlanningPriority { get; set; }
        public int MortgageNeedsPriority { get; set; }
        public int EquityReleasePriority { get; set; }
        public int LongTermCarePriority { get; set; }
        public int GeneralInsuranceNeedsPriority { get; set; }
        public string PrioritiesNotes { get; set; }
    }
}