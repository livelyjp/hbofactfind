using System.ComponentModel.DataAnnotations;
using HboFactFind.Domain.Questions.ExistingPlans.AbstractExistingPlan;

namespace HboFactFind.Domain.Questions.ExistingPlans
{
    public class PensionPolicies : Policy
    {
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal Contribution { get; set; }
        public string Frequency { get; set; }
        public bool Pci { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal AdditionalLifeCover { get; set; }
        [DisplayFormat(DataFormatString = "{0:c}")]
        public decimal LastValuation { get; set; }
    }
}