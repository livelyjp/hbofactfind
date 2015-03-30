using System.ComponentModel;
using HboFactFind.Domain.Pages.Abstracts;

namespace HboFactFind.Domain.Pages
{
    public class PageThree : Page
    {
        [DisplayName("Solicitor")]
        public string ClientOneSolicitor { get; set; }
        [DisplayName("Accountant")]
        public string ClientOneAccountant { get; set; }
        [DisplayName("Other")]
        public string ClientOneAdviserOther { get; set; }

        public string ClientTwoSolicitor { get; set; }
        public string ClientTwoAccountant { get; set; }
        public string ClientTwoAdviserOther { get; set; }
    }
}