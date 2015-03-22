using System;

namespace HboFactFind.Domain
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDateTime = DateTime.UtcNow;
        }

        public long Id { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}