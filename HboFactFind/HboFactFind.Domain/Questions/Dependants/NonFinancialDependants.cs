using System;
using HboFactFind.Domain.AbstractEntities;
using HboFactFind.Domain.Pages;

namespace HboFactFind.Domain.Questions.Dependants
{
    public class NonFinancialDependants : BaseEntity
    {
        public long PageFourId { get; set; }
        public string Name { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Relationship { get; set; }
        public string Notes { get; set; }

        public virtual PageFour PageFour { get; set; }
    }
}