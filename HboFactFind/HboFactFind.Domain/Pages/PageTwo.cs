﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HboFactFind.Domain.Enums;
using HboFactFind.Domain.Pages.Abstracts;

namespace HboFactFind.Domain.Pages
{
    public class PageTwo : Page
    {
        //PageTwo
        [DisplayName("Employment Status")]
        public EmploymentStatusEnum ClientOneEmploymentStatusEnum { get; set; }
        [DisplayName("Occupation")]
        public string ClientOneOccupation { get; set; }
        [DisplayName("Details Of Employer")]
        public string ClientOneDetailsOfEmployer { get; set; }
        
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "DateTime2")]
        [DisplayName("Employment Start Date")]
        public DateTime ClientOneEmploymentStartDate { get; set; }
        [DisplayName("Intended Retirement Age")]
        public int ClientOneIntendedRetirementAge { get; set; }

        public EmploymentStatusEnum ClientTwoStatusEnumEmploymentStatusEnum { get; set; }
        public string ClientTwoOccupation { get; set; }
        public string ClientTwoDetailsOfEmployer { get; set; }
        [DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        [Column(TypeName = "DateTime2")]
        public DateTime ClientTwoEmploymentStartDate { get; set; }
        public int ClientTwoIntendedRetirementAge { get; set; }
    }
}