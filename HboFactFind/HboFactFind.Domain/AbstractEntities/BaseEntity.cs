using System;
using System.ComponentModel.DataAnnotations;

namespace HboFactFind.Domain.AbstractEntities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDateTime = DateTime.UtcNow;
        }

        [Key]
        public long Id { get; set; }
        public DateTime CreatedDateTime { get; set; }
    }
}