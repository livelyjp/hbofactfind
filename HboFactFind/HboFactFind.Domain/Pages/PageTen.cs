using System.Collections.Generic;
using HboFactFind.Domain.Pages.Abstracts;
using HboFactFind.Domain.Questions.ExistingPlans;

namespace HboFactFind.Domain.Pages
{
    public class PageTen : Page
    {
        public List<ProtectionAndInsurancePolicies> ProtectionAndInsurancePolicies { get; set; }
        public List<PensionPolicies> PensionPolicieses { get; set; }
        public List<SavingsAndInvestmentPolicies> SavingsAndInvestmentPolicieses { get; set; }
        public string ExistingPlansNotes { get; set; }
    }
}