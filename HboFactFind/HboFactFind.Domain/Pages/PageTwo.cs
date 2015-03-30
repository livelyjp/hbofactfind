using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using HboFactFind.Domain.Enums;
using HboFactFind.Domain.Pages.Abstracts;

namespace HboFactFind.Domain.Pages
{
    public class PageTwo : Page
    {
        //PageTwo
        [DisplayName("Employment Status")]
        public EmploymentStatus ClientOneEmploymentStatus { get; set; }
        [DisplayName("Occupation")]
        public string ClientOneOccupation { get; set; }
        [DisplayName("Details Of Employer")]
        public string ClientOneDetailsOfEmployer { get; set; }
        [Column(TypeName = "DateTime2")]
        [DisplayName("Employment Start Date")]
        public DateTime ClientOneEmploymentStartDate { get; set; }
        [DisplayName("Intended Retirement Age")]
        public int ClientOneIntendedRetirementAge { get; set; }

        public EmploymentStatus ClientTwoStatusEmploymentStatus { get; set; }
        public string ClientTwoOccupation { get; set; }
        public string ClientTwoDetailsOfEmployer { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime ClientTwoEmploymentStartDate { get; set; }
        public int ClientTwoIntendedRetirementAge { get; set; }
    }
}