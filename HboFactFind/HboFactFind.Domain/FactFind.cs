using System;
using System.ComponentModel.DataAnnotations.Schema;
using HboFactFind.Domain.AbstractEntities;
using HboFactFind.Domain.Pages;

namespace HboFactFind.Domain
{
    public class FactFind : BaseEntity
    {
        public FactFind()
        {
            PageOne = new PageOne();
            PageTwo = new PageTwo();
            PageThree = new PageThree();
            PageFour = new PageFour();
            PageFive = new PageFive();
            PageSix = new PageSix();
            PageSeven = new PageSeven();
            PageEight = new PageEight();
            PageNine = new PageNine();
            PageTen = new PageTen();
        }

        public string ClientOneName { get; set; }
        public string ClientTwoName { get; set; }
        public long UserId { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime? CompletionDateTime { get; set; }

        //PageOne
        public long PageOneId { get; set; }
        public virtual PageOne PageOne { get; set; }

        //PageTwo
        public long PageTwoId { get; set; }

        public virtual PageTwo PageTwo { get; set; }

        //PageThree
        public long PageThreeId { get; set; }

        public virtual PageThree PageThree { get; set; }

        //PageFour
        public long PageFourId { get; set; }

        public virtual PageFour PageFour { get; set; }

        //PageFive
        public long PageFiveId { get; set; }

        public virtual PageFive PageFive { get; set; }

        //PageSix
        public long PageSixId { get; set; }

        public virtual PageSix PageSix { get; set; }

        //Page Seven
        public long PageSevenId { get; set; }

        public virtual PageSeven PageSeven { get; set; }

        //Page 8
        public long PageEightId { get; set; }

        public virtual PageEight PageEight { get; set; }


        //Page 9
        public long PageNineId { get; set; }

        public virtual PageNine PageNine { get; set; }

        //Page Ten
        public long PageTenId { get; set; }
        public virtual PageTen PageTen { get; set; }
    }
}