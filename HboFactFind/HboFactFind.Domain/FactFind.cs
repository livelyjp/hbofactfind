using System;
using HboFactFind.Domain.AbstractEntities;
using HboFactFind.Domain.Pages;

namespace HboFactFind.Domain
{
    public class FactFind : BaseEntity
    {
        public string ClientOneName { get; set; }
        public string ClientTwoName { get; set; }
        public long UserId { get; set; }
        public DateTime CompletionDateTime { get; set; }

        //PageOne
        public long PageOneClientOneId { get; set; }
        public virtual PageOne PageOneClientOne { get; set; }

        //PageTwo
        public long PageTwoClientOneId { get; set; }

        public virtual PageTwo PageTwoClientOne { get; set; }

        //PageThree
        public long PageThreeClientOneId { get; set; }

        public virtual PageThree PageThreeClientOne { get; set; }

        //PageFour
        public long PageFourClientOneId { get; set; }

        public virtual PageFour PageFourClientOne { get; set; }

        //PageFive
        public long PageFiveClientOneId { get; set; }

        public virtual PageFive PageFiveClientOne { get; set; }

        //PageSix
        public long PageSixClientOneId { get; set; }

        public virtual PageSix PageSixClientOne { get; set; }

        //Page Seven
        public long PageSevenClientOneId { get; set; }

        public virtual PageSeven PageSevenClientOne { get; set; }

        //Page 8
        public long PageEightClientOneId { get; set; }

        public virtual PageEight PageEightClientOne { get; set; }


        //Page 9
        public long PageNineClientOneId { get; set; }

        public virtual PageNine PageNineClientOne { get; set; }

        //Page Ten
        public long PageTenClientOneId { get; set; }
        public virtual PageTen PageTenClientOne { get; set; }
    }
}