using System.ComponentModel.DataAnnotations;

namespace HboFactFind.Domain.Enums
{
    public enum TaxRateEnum
    {
        [Display(Name = "Nil Rate")]
        NilRate,
        [Display(Name = "Basic Rate")]
        BasicRate,
        [Display(Name = "Higher Rate")]
        HigherRate,
        [Display(Name = "Additional Rate")]
        AdditionRate
    }
}