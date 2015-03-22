using HboFactFind.Domain.AbstractEntities;

namespace HboFactFind.Domain.Pages.Abstracts
{
    public abstract class Page : BaseEntity
    {
        public long FactFindId { get; set; }
        public virtual FactFind FactFind { get; set; }
    }
}