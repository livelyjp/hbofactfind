using System;
using HboFactFind.Domain.AbstractEntities;

namespace HboFactFind.Domain.Questions.Dependants
{
    public class NonFinancialDependants : BaseEntity
    {
        public long FactFindId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Relationship { get; set; }
        public string Notes { get; set; }

        public virtual FactFind FactFind { get; set; }
    }
}