using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HboFactFind.Domain.AbstractEntities;
using HboFactFind.Domain.Pages;

namespace HboFactFind.Domain.Questions.Dependants
{
    public class NonFinancialDependants : BaseEntity
    {
        public long PageFourId { get; set; }
        public string Name { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "DateTime2")]
        [DisplayName("DOB")]
        public DateTime DateOfBirth { get; set; }
        public string Relationship { get; set; }
        public string Notes { get; set; }

        public virtual PageFour PageFour { get; set; }
    }
}