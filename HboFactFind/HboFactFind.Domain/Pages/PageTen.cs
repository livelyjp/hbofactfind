using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using HboFactFind.Domain.Pages.Abstracts;
using HboFactFind.Domain.Questions.ExistingPlans;

namespace HboFactFind.Domain.Pages
{
    public class PageTen : Page
    {
        [DisplayName("Protection And General Insurance Policies")]
        public List<ProtectionAndInsurancePolicies> ProtectionAndInsurancePolicies { get; set; }
        [DisplayName("Pension Policies")]
        public List<PensionPolicies> PensionPolicieses { get; set; }
        [DisplayName("Savings And Investment Policies")]
        public List<SavingsAndInvestmentPolicies> SavingsAndInvestmentPolicieses { get; set; }
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        public PageTen()
        {
            ProtectionAndInsurancePolicies = new List<ProtectionAndInsurancePolicies>();
            PensionPolicieses = new List<PensionPolicies>();
            SavingsAndInvestmentPolicieses = new List<SavingsAndInvestmentPolicies>();
        }
    }
}