using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Greysis.Core
{
    public interface IServiceError
    {
        int Code { get; }
        string Description { get;}
        object Data { get; set; }
        Exception Exception { get;}
    }
}
