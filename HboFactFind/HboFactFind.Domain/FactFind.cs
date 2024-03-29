﻿using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using HboFactFind.Domain.AbstractEntities;
using HboFactFind.Domain.Pages;

namespace HboFactFind.Domain
{
    public class FactFind : BaseEntity
    {
        [DisplayName("Client One")]
        public string ClientOneName { get; set; }

        [DisplayName("Client Two")]
        public string ClientTwoName { get; set; }

        [DisplayName("Adviser")]
        public long UserId { get; set; }

        public virtual User User { get; set; }

        [Column(TypeName = "DateTime2")]
        [DataType(DataType.Date)]
        [DisplayFormat(DataFormatString = "{0:dd.MM.yyyy}", ApplyFormatInEditMode = true)]
        [DisplayName("Date Of Completion")]
        public DateTime? CompletionDateTime { get; set; }

        //PageOne
        [ForeignKey("PageOne")]
        public long PageOneId { get; set; }

        [ForeignKey("PageOneId")]
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