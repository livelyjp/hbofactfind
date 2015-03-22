using System;
using HboFactFind.Domain.AbstractEntities;

namespace HboFactFind.Domain.Questions.Dependants
{
    public class FinancialDependant : BaseEntity
    {
        public long FactFindId { get; set; }
        public string DependantName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string DependantOn { get; set; }
        public string AgeOfIndependance { get; set; }
        public string RelationshipAndReason { get; set; }

        public virtual FactFind FactFind { get; set; }
    }
}