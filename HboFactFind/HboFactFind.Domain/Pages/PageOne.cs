using System;
using HboFactFind.Domain.Enums;
using HboFactFind.Domain.Pages.Abstracts;

namespace HboFactFind.Domain.Pages
{
    public class PageOne : Page
    {
        //Page One
        public TitleEnum ClientOneTitle { get; set; }
        public string ClientOneForename { get; set; }
        public string ClientOneSurnames { get; set; }
        public string ClientOneAddressLineOne { get; set; }
        public string ClientOneAddressLineTwo { get; set; }
        public string ClientOneAddressLineThree { get; set; }
        public string ClientOneCounty { get; set; }
        public string ClientOnePostCode { get; set; }
        public string ClientOneEmailAddress { get; set; }
        public string ClientOneHomeTelephone { get; set; }
        public string ClientOneMobileTelephone { get; set; }
        public DateTime ClientOneDateOfBirth { get; set; }
        public SexEnum ClientOneSex { get; set; }
        public MartialStatusEnum ClientOneMartialStatus { get; set; }
        public bool ClientOneGoodHealth { get; set; }
        public bool ClientOneSmoked { get; set; }
        public string ClientOneNationalInsuranceNumber { get; set; }
        public string ClientOneNationality { get; set; }
        public string ClientOneCountryOfBirth { get; set; }
        public string ClientOneCountryOfResidence { get; set; }
        public string ClientOneDomicile { get; set; }
        public string ClientOneTaxationResidency { get; set; }
        public string ClientOneExtraInformation { get; set; }

        public TitleEnum ClientTwoTitle { get; set; }
        public string ClientTwoForename { get; set; }
        public string ClientTwoSurnames { get; set; }
        public string ClientTwoAddressLineOne { get; set; }
        public string ClientTwoAddressLineTwo { get; set; }
        public string ClientTwoAddressLineThree { get; set; }
        public string ClientTwoCounty { get; set; }
        public string ClientTwoPostCode { get; set; }
        public string ClientTwoEmailAddress { get; set; }
        public string ClientTwoHomeTelephone { get; set; }
        public string ClientTwoMobileTelephone { get; set; }
        public DateTime ClientTwoDateOfBirth { get; set; }
        public SexEnum ClientTwoSex { get; set; }
        public MartialStatusEnum ClientTwoMartialStatus { get; set; }
        public bool ClientTwoGoodHealth { get; set; }
        public bool ClientTwoSmoked { get; set; }
        public string ClientTwoNationalInsuranceNumber { get; set; }
        public string ClientTwoNationality { get; set; }
        public string ClientTwoCountryOfBirth { get; set; }
        public string ClientTwoCountryOfResidence { get; set; }
        public string ClientTwoDomicile { get; set; }
        public string ClientTwoTaxationResidency { get; set; }
        public string ClientTwoExtraInformation { get; set; }
    }
}