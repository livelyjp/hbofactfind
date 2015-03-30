using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using HboFactFind.Domain.AbstractEntities;
using HboFactFind.Domain.Pages;

namespace HboFactFind.Domain.Questions.Dependants
{
    public class FinancialDependant : BaseEntity
    {
        public long PageFourId { get; set; }
        [DisplayName("Dependant Name")]
        public string DependantName { get; set; }
        [DisplayName("DOB")]
        [Column(TypeName = "DateTime2")]
        public DateTime DateOfBirth { get; set; }
        [DisplayName("Dependant On")]
        public string DependantOn { get; set; }
        [DisplayName("Age Of Independance")]
        public string AgeOfIndependance { get; set; }
        [DisplayName("Relationship And Reason")]
        public string RelationshipAndReason { get; set; }

        public virtual PageFour PageFour { get; set; }
    }
}