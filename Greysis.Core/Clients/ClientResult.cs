using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greysis.Core.Clients
{
    public class ClientResult : IClientResult
    {
        public virtual bool IsSuccess { get; set; }
        public virtual int Code { get; set; }
    }
    public class ClientDataResult : ClientResult, IClientDataResult
    {
        public virtual object Data { get; set; }
    }
}
