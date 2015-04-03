using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HboFactFind.Domain.AbstractEntities;
using HboFactFind.Domain.Pages;

namespace HboFactFind.Domain.Questions
{
    public class BreakDownOfLiabilities : BaseEntity
    {
        public long PageSevenId { get; set; }
        [DisplayName("Mortgage/Load/Credit Owner")]
        public string MoregateLoadCreditOwner { get; set; }
        [DisplayName("Lender")]
        public string Lender { get; set; }
        [DisplayName("Amount")]
        public string Amount { get; set; }
        [DisplayName("Repayment Type")]
        public string RepaymentType { get; set; }
        [DisplayName("Repayment Date")]
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "DateTime2")]
        public DateTime RepaymentDate { get; set; }

        public virtual PageSeven PageSeven { get; set; }
    }
}