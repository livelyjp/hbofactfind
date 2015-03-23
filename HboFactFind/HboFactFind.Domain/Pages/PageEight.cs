using HboFactFind.Domain.Pages.Abstracts;

namespace HboFactFind.Domain.Pages
{
    public class PageEight : Page
    {
        public string ClientOneRequiredEmergancyFund { get; set; }
        public string ClientOnePlannedExpenditure { get; set; }
        public bool ClientOneMadeAWill { get; set; }
        public string ClientOneWillNotes { get; set; }

        public string ClientTwoRequiredEmergancyFund { get; set; }
        public string ClientTwoPlannedExpenditure { get; set; }
        public bool ClientTwoMadeAWill { get; set; }
        public string ClientTwoWillNotes { get; set; }
    }
}