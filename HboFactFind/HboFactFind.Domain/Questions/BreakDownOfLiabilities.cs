using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HboFactFind.Domain.AbstractEntities;
using HboFactFind.Domain.Pages;

namespace HboFactFind.Domain.Questions
{
    public class BreakDownOfLiabilities : BaseEntity
    {
        public long PageSevenId { get; set; }
        public string MoregateLoadCreditOwner { get; set; }
        public string Lender { get; set; }
        public string Amount { get; set; }
        public string RepaymentType { get; set; }

        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "DateTime2")]
        public DateTime RepaymentDate { get; set; }

        public virtual PageSeven PageSeven { get; set; }
    }
}