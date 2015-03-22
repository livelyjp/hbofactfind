using System;
using HboFactFind.Domain.Enums;
using HboFactFind.Domain.Pages.Abstracts;

namespace HboFactFind.Domain.Pages
{
    public class PageOne : Page
    {
        //Page One
        public TitleEnum Title { get; set; }
        public string Forename { get; set; }
        public string Surnames { get; set; }
        public string AddressLineOne { get; set; }
        public string AddressLineTwo { get; set; }
        public string AddressLineThree { get; set; }
        public string County { get; set; }
        public string PostCode { get; set; }
        public string EmailAddress { get; set; }
        public string HomeTelephone { get; set; }
        public string MobileTelephone { get; set; }
        public DateTime DateOfBirth { get; set; }
        public SexEnum Sex { get; set; }
        public MartialStatusEnum MartialStatus { get; set; }
        public bool GoodHealth { get; set; }
        public bool Smoked { get; set; }
        public string NationalInsuranceNumber { get; set; }
        public string Nationality { get; set; }
        public string CountryOfBirth { get; set; }
        public string CountryOfResidence { get; set; }
        public string Domicile { get; set; }
        public string TaxationResidency { get; set; }
        public string ExtraInformation { get; set; }
    }
}