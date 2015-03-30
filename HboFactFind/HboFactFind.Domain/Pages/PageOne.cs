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
        //Page One
        [DisplayName("Title")]
        public TitleEnum ClientOneTitle { get; set; }

        [DisplayName("Forenames")]
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

        [DisplayName("Email Address")]
        public string ClientOneEmailAddress { get; set; }

        [DisplayName("Home Telephone")]
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

        [DisplayName("Good Health?")]
        public bool ClientOneGoodHealth { get; set; }

        [DisplayName("Smoked In The Last 12 Months?")]
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

        [DisplayName("Notes")]
        [DataType(DataType.MultilineText)]
        public string Notes { get; set; }

        [DisplayName("Client Two Title")]
        public TitleEnum ClientTwoTitle { get; set; }

        [DisplayName("Client Two Forename")]
        public string ClientTwoForename { get; set; }

        [DisplayName("Client Two Surnames")]
        public string ClientTwoSurnames { get; set; }

        [DisplayName("Clietn Two Address Line")]
        public string ClientTwoAddressLineOne { get; set; }

        [DisplayName("Client Two Address Line Two")]
        public string ClientTwoAddressLineTwo { get; set; }

        [DisplayName("Client Two Address Line Three")]
        public string ClientTwoAddressLineThree { get; set; }

        [DisplayName("Client Two County")]
        public string ClientTwoCounty { get; set; }

        [DisplayName("Client Two Post Code")]
        public string ClientTwoPostCode { get; set; }

        [DisplayName("Client Two Email Address")]
        public string ClientTwoEmailAddress { get; set; }

        [DisplayName("Client Two Home Telephone")]
        public string ClientTwoHomeTelephone { get; set; }

        [DisplayName("Client Two Mobile Telephone")]
        public string ClientTwoMobileTelephone { get; set; }

        [Column(TypeName = "DateTime2")]
        [DisplayName("Client Two Date Of Birth")]
        public DateTime ClientTwoDateOfBirth { get; set; }

        [DisplayName("Client Two Sex")]
        public SexEnum ClientTwoSex { get; set; }

        [DisplayName("Client Two Marital Status")]
        public MartialStatusEnum ClientTwoMartialStatus { get; set; }

        [DisplayName("Client Two Good Health")]
        public bool ClientTwoGoodHealth { get; set; }

        [DisplayName("Client Two Smoked")]
        public bool ClientTwoSmoked { get; set; }

        [DisplayName("Client Two National Insurance Number")]
        public string ClientTwoNationalInsuranceNumber { get; set; }

        [DisplayName("Client Two Nationality")]
        public string ClientTwoNationality { get; set; }

        [DisplayName("Client Two Country Of Birth")]
        public string ClientTwoCountryOfBirth { get; set; }

        [DisplayName("Client Two Country Of Residence")]
        public string ClientTwoCountryOfResidence { get; set; }

        [DisplayName("Client Two Domicile")]
        public string ClientTwoDomicile { get; set; }

        [DisplayName("Client Two Taxation Residency")]
        public string ClientTwoTaxationResidency { get; set; }

        [DisplayName("Client Two Extra Information")]
        public string ClientTwoExtraInformation { get; set; }
    }
}