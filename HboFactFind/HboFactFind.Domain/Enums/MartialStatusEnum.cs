using System.ComponentModel.DataAnnotations;

namespace HboFactFind.Domain.Enums
{
    public enum MartialStatusEnum
    {
        [Display(Name = "Single")]
        Single,
        [Display(Name = "Married")]
        Married,
        [Display(Name = "Widowed")]
        Widowed,
        [Display(Name = "Divorced")]
        Divorced,
        [Display(Name = "Cohabiting")]
        CoHabiting,
        [Display(Name = "Civil Partnership")]
        CivilPartership,
        [Display(Name = "Seperated")]
        Seperated
    }
}