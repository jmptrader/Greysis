using System.ComponentModel.DataAnnotations;

namespace Greysis.Core.Domains
{
    public abstract class EntityBase
    {

    }

    public abstract class Entity<T> : EntityBase, IEntity<T>
    {
        [Key]
        public virtual T ID { get; set; }
    }
}
