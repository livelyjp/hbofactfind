namespace HboFactFind.Domain.Questions.ExistingPlans.AbstractExistingPlan
{
    public abstract class Policy
    {
        public long FactFindId { get; set; }
        public string Owner { get; set; }
        public string Provider { get; set; }
        public string PolicyNumber { get; set; }
        public string ProductPlanType { get; set; }
        public bool InForce { get; set; }

        public virtual FactFind FactFind { get; set; }
    }
}