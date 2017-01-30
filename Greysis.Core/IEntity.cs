using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Greysis.Core
{
    public interface IEntity
    {

    }
    public interface IEntity<T> : IEntity
    {
        T ID { get; set; }
    }
}
