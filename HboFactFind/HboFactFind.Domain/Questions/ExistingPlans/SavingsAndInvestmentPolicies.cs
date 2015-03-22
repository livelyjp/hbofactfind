using HboFactFind.Domain.Questions.ExistingPlans.AbstractExistingPlan;

namespace HboFactFind.Domain.Questions.ExistingPlans
{
    public class SavingsAndInvestmentPolicies : Policy
    {
        public decimal Contrbution { get; set; }
        public string Frequency { get; set; }
        public bool InTrust { get; set; }
        public decimal LastValuation { get; set; }
    }
}