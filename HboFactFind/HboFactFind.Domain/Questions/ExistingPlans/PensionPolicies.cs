using HboFactFind.Domain.Questions.ExistingPlans.AbstractExistingPlan;

namespace HboFactFind.Domain.Questions.ExistingPlans
{
    public class PensionPolicies : Policy
    {
        public decimal Contribution { get; set; }
        public string Frequency { get; set; }
        public bool Pci { get; set; }
        public decimal AdditionalLifeCover { get; set; }
        public decimal LastValuation { get; set; }
    }
}