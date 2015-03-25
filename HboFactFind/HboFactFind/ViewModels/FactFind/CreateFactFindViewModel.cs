using System;
using System.Web.Mvc;

namespace HboFactFind.ViewModels.FactFind
{
    public class CreateFactFindViewModel
    {
        [HiddenInput(DisplayValue = false)]
        public long UserId { get; set; }

        public string ClientOneName { get; set; }
        public string ClientTwoName { get; set; }
        public DateTime CompletionDateTime { get; set; }
    }
}