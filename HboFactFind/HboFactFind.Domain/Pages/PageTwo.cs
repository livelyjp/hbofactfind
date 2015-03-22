using System;
using HboFactFind.Domain.Enums;
using HboFactFind.Domain.Pages.Abstracts;

namespace HboFactFind.Domain.Pages
{
    public class PageTwo : Page
    {
        //PageTwo
        public EmploymentStatus EmploymentStatus { get; set; }
        public string Occupation { get; set; }
        public string DetailsOfEmployer { get; set; }
        public DateTime EmploymentStartDate { get; set; }
        public int IntendedRetirementAge { get; set; }
    }
}