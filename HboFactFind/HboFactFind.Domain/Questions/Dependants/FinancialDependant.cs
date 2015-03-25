﻿using System;
using System.ComponentModel.DataAnnotations.Schema;
using HboFactFind.Domain.AbstractEntities;
using HboFactFind.Domain.Pages;

namespace HboFactFind.Domain.Questions.Dependants
{
    public class FinancialDependant : BaseEntity
    {
        public long PageFourId { get; set; }
        public string DependantName { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime DateOfBirth { get; set; }
        public string DependantOn { get; set; }
        public string AgeOfIndependance { get; set; }
        public string RelationshipAndReason { get; set; }

        public virtual PageFour PageFour { get; set; }
    }
}