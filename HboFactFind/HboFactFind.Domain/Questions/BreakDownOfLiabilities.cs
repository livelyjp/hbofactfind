using System;
using HboFactFind.Domain.AbstractEntities;

namespace HboFactFind.Domain.Questions
{
    public class BreakDownOfLiabilities : BaseEntity
    {
        public long FactFindId { get; set; }
        public string MoregateLoadCreditOwner { get; set; }
        public string Lender { get; set; }
        public string Amount { get; set; }
        public string RepaymentType { get; set; }
        public DateTime RepaymentDate { get; set; }

        public virtual FactFind FactFind { get; set; }
    }
}