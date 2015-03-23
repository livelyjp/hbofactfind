﻿using System.Collections.Generic;
using HboFactFind.Domain.Pages.Abstracts;
using HboFactFind.Domain.Questions.Dependants;

namespace HboFactFind.Domain.Pages
{
    public class PageFour : Page
    {
        public bool AnyFinancialDependants { get; set; }
        public virtual List<FinancialDependant> FinancialDependants { get; set; }
        public virtual List<NonFinancialDependants> NonFinancialDependantses { get; set; }
    }
}