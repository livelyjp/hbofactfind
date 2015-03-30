using System.ComponentModel;
using HboFactFind.Domain.Pages.Abstracts;

namespace HboFactFind.Domain.Pages
{
    public class PageEight : Page
    {
        [DisplayName("How Much Emergancy Fund Do You Require")]
        public string ClientOneRequiredEmergancyFund { get; set; }
        [DisplayName("Details Of Planned Expenditure")]
        public string ClientOnePlannedExpenditure { get; set; }
        [DisplayName("Have You Made A Will")]
        public bool ClientOneMadeAWill { get; set; }
        [DisplayName("Notes")]
        public string Notes { get; set; }

        public string ClientTwoRequiredEmergancyFund { get; set; }
        public string ClientTwoPlannedExpenditure { get; set; }
        public bool ClientTwoMadeAWill { get; set; }
    }
}