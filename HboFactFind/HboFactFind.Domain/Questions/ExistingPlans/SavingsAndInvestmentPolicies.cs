using System.ComponentModel.DataAnnotations;
using HboFactFind.Domain.Questions.ExistingPlans.AbstractExistingPlan;

namespace HboFactFind.Domain.Questions.ExistingPlans
{
    public class SavingsAndInvestmentPolicies : Policy
    {
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Contrbution { get; set; }
        public string Frequency { get; set; }
        public bool InTrust { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal LastValuation { get; set; }
    }
}