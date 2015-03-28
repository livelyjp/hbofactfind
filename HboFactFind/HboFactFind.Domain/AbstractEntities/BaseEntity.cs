using System;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace HboFactFind.Domain.AbstractEntities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreatedDateTime = DateTime.UtcNow;
        }

        [Key]
        //[DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public long Id { get; set; }
        [Column(TypeName = "DateTime2")]
        [DisplayName("Created Date")]
        public DateTime CreatedDateTime { get; set; }
    }
}