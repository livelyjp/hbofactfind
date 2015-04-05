using System.ComponentModel.DataAnnotations;
using HboFactFind.Domain.Questions.ExistingPlans.AbstractExistingPlan;

namespace HboFactFind.Domain.Questions.ExistingPlans
{
    public class ProtectionAndInsurancePolicies : Policy
    {
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal GrossPremium { get; set; }
        public string PremiumFrequency { get; set; }
        public bool Waiver { get; set; }
        public bool InTrust { get; set; }
        public string Term { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal LifeCover { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal CICCover { get; set; }
    }
}