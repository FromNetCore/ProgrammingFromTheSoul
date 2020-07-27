using System.ComponentModel.DataAnnotations;

namespace Infrastructures.EntityAbstraction
{
    public class EntityBase<T> : IEntityBase
    {
        [Key]
        public T Id { get; set; }
    }
}
