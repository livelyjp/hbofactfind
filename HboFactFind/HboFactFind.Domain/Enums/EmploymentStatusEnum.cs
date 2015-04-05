using System.ComponentModel.DataAnnotations;

namespace HboFactFind.Domain.Enums
{
    public enum EmploymentStatusEnum
    {
        Employed,
        [Display(Name = "Self Employed")]
        SelfEmployed,
        Unemployed,
        Student
    }
}