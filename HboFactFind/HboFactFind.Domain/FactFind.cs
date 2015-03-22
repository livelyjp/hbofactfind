using System;
using HboFactFind.Domain.Pages;

namespace HboFactFind.Domain
{
    public class FactFind
    {
        public string ClientOneName { get; set; }
        public string ClientTwoName { get; set; }
        public long UserId { get; set; }
        public DateTime CompletionDateTime { get; set; }

        //PageOne
        public long PageOneClientOneId { get; set; }
        public long PageOneClientTwoId { get; set; }
        public virtual PageOne PageOneClientOne { get; set; }
        public virtual PageOne PageOneClientTwo { get; set; }

        //PageTwo
        public long PageTwoClientOneId { get; set; }
        public long PageTwoClientTwoId { get; set; }

        public virtual PageTwo PageTwoClientOne { get; set; }
        public virtual PageTwo PageTwoClientTwo { get; set; }

        //PageThree
        public long PageThreeClientOneId { get; set; }
        public long PageThreeClientTwoId { get; set; }

        public virtual PageThree PageThreeClientOne { get; set; }
        public virtual PageThree PageThreeClientTwo { get; set; }

        //PageFour
        public long PageFourClientOneId { get; set; }

        public virtual PageFour PageFourClientOne { get; set; }

        //PageFive
        public long PageFiveClientOneId { get; set; }
        public long PageFiveClientTwoId { get; set; }

        public virtual PageFive PageFiveClientOne { get; set; }
        public virtual PageFive PageFiveClientTwo { get; set; }

        //PageSix
        public long PageSixClientOneId { get; set; }
        public long PageSixClientTwoId { get; set; }

        public virtual PageSix PageSixClientOne { get; set; }
        public virtual PageSix PageSixClientTwo { get; set; }

        //Page Seven
        public long PageSevenClientOneId { get; set; }
        public long PageSevenClientTwoId { get; set; }

        public virtual PageSeven PageSevenClientOne { get; set; }
        public virtual PageSeven PageSevenClientTwo { get; set; }

        //Page 8
        public long PageEightClientOneId { get; set; }
        public long PageEightClientTwoId { get; set; }

        public virtual PageEight PageEightClientOne { get; set; }
        public virtual PageEight PageEightClientTwo { get; set; }


        //Page 9
        public long PageNineClientOneId { get; set; }
        public long PageNineClientTwoId { get; set; }

        public virtual PageNine PageNineClientOne { get; set; }
        public virtual PageNine PageNineClientTwo { get; set; }

        //Page Ten
        public long PageTenClientOneId { get; set; }
        public virtual PageTen PageTenClientOne { get; set; }
    }
}