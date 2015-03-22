using HboFactFind.Domain.Pages.Abstracts;

namespace HboFactFind.Domain.Pages
{
    public class PageEight : Page
    {
        public string RequiredEmergancyFund { get; set; }
        public string PlannedExpenditure { get; set; }
        public bool MadeAWill { get; set; }
        public string WillNotes { get; set; }
    }
}