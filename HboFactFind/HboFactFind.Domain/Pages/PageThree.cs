using HboFactFind.Domain.Pages.Abstracts;

namespace HboFactFind.Domain.Pages
{
    public class PageThree : Page
    {
        public string ClientOneSolicitor { get; set; }
        public string ClientOneAccountant { get; set; }
        public string ClientOneAdviserOther { get; set; }

        public string ClientTwoSolicitor { get; set; }
        public string ClientTwoAccountant { get; set; }
        public string ClientTwoAdviserOther { get; set; }
    }
}