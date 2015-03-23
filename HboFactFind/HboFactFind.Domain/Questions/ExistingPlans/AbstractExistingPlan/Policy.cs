using HboFactFind.Domain.AbstractEntities;
using HboFactFind.Domain.Pages;

namespace HboFactFind.Domain.Questions.ExistingPlans.AbstractExistingPlan
{
    public abstract class Policy : BaseEntity
    {
        public long PageTenId { get; set; }
        public string Owner { get; set; }
        public string Provider { get; set; }
        public string PolicyNumber { get; set; }
        public string ProductPlanType { get; set; }
        public bool InForce { get; set; }

        public virtual PageTen PageTen { get; set; }
    }
}