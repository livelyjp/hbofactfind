using System.Collections.Generic;
using HboFactFind.Domain.Pages.Abstracts;
using HboFactFind.Domain.Questions.Dependants;

namespace HboFactFind.Domain.Pages
{
    public class PageFour : Page
    {
        public PageFour()
        {
            FinancialDependants = new List<FinancialDependant>();
            NonFinancialDependantses = new List<NonFinancialDependants>();
        }

        public bool AnyFinancialDependants { get; set; }
        public virtual List<FinancialDependant> FinancialDependants { get; set; }
        public virtual List<NonFinancialDependants> NonFinancialDependantses { get; set; }
    }
}