using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HboFactFind.Domain.Enums;
using HboFactFind.Domain.Pages.Abstracts;

namespace HboFactFind.Domain.Pages
{
    public class PageOne : Page
    {
        public PageOne()
        {
        }

        //Page One
        [DisplayName("Title")]
        public TitleEnum ClientOneTitle { get; set; }

        [DisplayName("Forename")]
        public string ClientOneForename { get; set; }

        [DisplayName("Surname")]
        public string ClientOneSurnames { get; set; }

        [DisplayName("Address Line One")]
        public string ClientOneAddressLineOne { get; set; }

        [DisplayName("Address Line Two")]
        public string ClientOneAddressLineTwo { get; set; }

        [DisplayName("Address Line Three")]
        public string ClientOneAddressLineThree { get; set; }

        [DisplayName("County")]
        public string ClientOneCounty { get; set; }

        [DisplayName("Post Code")]
        public string ClientOnePostCode { get; set; }

        [DisplayName("Address")]
        public string ClientOneEmailAddress { get; set; }

        [DisplayName("Telephone")]
        public string ClientOneHomeTelephone { get; set; }

        [DisplayName("Mobile Telephone")]
        public string ClientOneMobileTelephone { get; set; }

        [DisplayName("Date Of Birth")]
        [Column(TypeName = "DateTime2")]
        public DateTime ClientOneDateOfBirth { get; set; }

        [DisplayName("Sex")]
        public SexEnum ClientOneSex { get; set; }

        [DisplayName("Marital Status")]
        public MartialStatusEnum ClientOneMartialStatus { get; set; }

        [DisplayName("Good Health")]
        public bool ClientOneGoodHealth { get; set; }

        [DisplayName("Smoked")]
        public bool ClientOneSmoked { get; set; }

        [DisplayName("National Insurance Number")]
        public string ClientOneNationalInsuranceNumber { get; set; }

        [DisplayName("Nationality")]
        public string ClientOneNationality { get; set; }

        [DisplayName("Country Of Birth")]
        public string ClientOneCountryOfBirth { get; set; }

        [DisplayName("Country Of Residence")]
        public string ClientOneCountryOfResidence { get; set; }

        [DisplayName("Domicile")]
        public string ClientOneDomicile { get; set; }

        [DisplayName("Taxation Residency")]
        public string ClientOneTaxationResidency { get; set; }

        [DisplayName("Extra Information")]
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

        [Column(TypeName = "DateTime2")]
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