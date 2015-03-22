using HboFactFind.Domain.Questions.ExistingPlans.AbstractExistingPlan;

namespace HboFactFind.Domain.Questions.ExistingPlans
{
    public class ProtectionAndInsurancePolicies : Policy
    {
        public decimal GrossPremium { get; set; }
        public string PremiumFrequency { get; set; }
        public bool Waiver { get; set; }
        public bool InTrust { get; set; }
        public string Term { get; set; }
        public decimal LifeCover { get; set; }
        public decimal CICCover { get; set; }
    }
}