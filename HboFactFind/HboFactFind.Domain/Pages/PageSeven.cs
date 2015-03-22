using System.Collections.Generic;
using HboFactFind.Domain.Pages.Abstracts;
using HboFactFind.Domain.Questions;

namespace HboFactFind.Domain.Pages
{
    public class PageSeven : Page
    {
        public decimal Home { get; set; }
        public decimal OtherProperty { get; set; }
        public decimal CashDeposits { get; set; }
        public decimal InvestmentBonds { get; set; }
        public decimal PensionFunds { get; set; }
        public decimal Isa { get; set; }
        public decimal Collectives { get; set; }
        public decimal Shares { get; set; }
        public decimal BuisnessAssets { get; set; }
        public decimal OtherAssets { get; set; }
        public decimal TotalAssets { get; set; }

        public decimal MainMortgage { get; set; }
        public decimal CreditCards { get; set; }
        public decimal Overdraft { get; set; }
        public decimal LoansHp { get; set; }
        public decimal OtherMortgage { get; set; }
        public decimal OtherLending { get; set; }
        public decimal TotalDebt { get; set; }

        public virtual List<BreakDownOfLiabilities> BreakDownOfLiabilitieses { get; set; }
        public string AssetsNotes { get; set; }
    }
}