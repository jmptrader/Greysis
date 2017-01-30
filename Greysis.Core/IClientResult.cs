using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Greysis.Core
{
    public interface IClientResult
    {
        bool IsSuccess { get; set; }
        int Code { get; set; }
    }
    public interface IClientDataResult : IClientResult
    {
        object Data { get; set; }
    }
}
