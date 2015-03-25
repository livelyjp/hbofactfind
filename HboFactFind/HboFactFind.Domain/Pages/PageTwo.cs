using System;
using System.ComponentModel.DataAnnotations.Schema;
using HboFactFind.Domain.Enums;
using HboFactFind.Domain.Pages.Abstracts;

namespace HboFactFind.Domain.Pages
{
    public class PageTwo : Page
    {
        //PageTwo
        public EmploymentStatus ClientOneEmploymentStatus { get; set; }
        public string ClientOneOccupation { get; set; }
        public string ClientOneDetailsOfEmployer { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime ClientOneEmploymentStartDate { get; set; }
        public int ClientOneIntendedRetirementAge { get; set; }

        public EmploymentStatus ClientTwoStatusEmploymentStatus { get; set; }
        public string ClientTwoOccupation { get; set; }
        public string ClientTwoDetailsOfEmployer { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime ClientTwoEmploymentStartDate { get; set; }
        public int ClientTwoIntendedRetirementAge { get; set; }
    }
}