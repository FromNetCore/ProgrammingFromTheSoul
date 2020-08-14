using System;
using System.ComponentModel.DataAnnotations;

namespace Infrastructures.EntityAbstraction
{
    public class EntityBaseWithId : IEntityBase
    {
        [Key]
        public Guid Id { get; set; }
    }
}
