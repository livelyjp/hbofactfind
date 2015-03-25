using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations.Schema;
using System.Web.Mvc;
using HboFactFind.Domain.Enums;

namespace HboFactFind.ViewModels
{
    public class PageOneViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public long FactFindId { get; set; }

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

        [DisplayName("Title")]
        public TitleEnum ClientTwoTitle { get; set; }

        [DisplayName("Forenames")]
        public string ClientTwoForename { get; set; }

        [DisplayName("Surnames")]
        public string ClientTwoSurnames { get; set; }

        [DisplayName("Address Line One")]
        public string ClientTwoAddressLineOne { get; set; }

        [DisplayName("Address Line Two")]
        public string ClientTwoAddressLineTwo { get; set; }

        [DisplayName("Address Line Three")]
        public string ClientTwoAddressLineThree { get; set; }

        [DisplayName("County")]
        public string ClientTwoCounty { get; set; }

        [DisplayName("Post Code")]
        public string ClientTwoPostCode { get; set; }

        [DisplayName("Email Address")]
        public string ClientTwoEmailAddress { get; set; }

        [DisplayName("Home Telephone")]
        public string ClientTwoHomeTelephone { get; set; }

        [DisplayName("Mobile Telephone")]
        public string ClientTwoMobileTelephone { get; set; }

        [DisplayName("Date Of Birth")]

        [Column(TypeName = "DateTime2")]
        public DateTime ClientTwoDateOfBirth { get; set; }

        [DisplayName("Sex")]
        public SexEnum ClientTwoSex { get; set; }

        [DisplayName("Marital Status")]
        public MartialStatusEnum ClientTwoMartialStatus { get; set; }

        [DisplayName("Good Health")]
        public bool ClientTwoGoodHealth { get; set; }

        [DisplayName("Smoked")]
        public bool ClientTwoSmoked { get; set; }

        [DisplayName("National Insurance Number")]
        public string ClientTwoNationalInsuranceNumber { get; set; }

        [DisplayName("Nationality")]
        public string ClientTwoNationality { get; set; }

        [DisplayName("Country Of Birth")]
        public string ClientTwoCountryOfBirth { get; set; }

        [DisplayName("Country Of Residence")]
        public string ClientTwoCountryOfResidence { get; set; }

        [DisplayName("Domicile")]
        public string ClientTwoDomicile { get; set; }

        [DisplayName("Taxation Residency")]
        public string ClientTwoTaxationResidency { get; set; }

        [DisplayName("Extra Information")]
        public string ClientTwoExtraInformation { get; set; }
    }
}