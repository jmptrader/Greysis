using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Greysis.Core.Services
{
    public partial class ServiceError : IServiceError
    {
        public int Code { get; private set; }
        public string Description { get; private set; }
        public object Data { get; set; }
        public Exception Exception { get; private set; }
        public ServiceError(int code, string description) : this(code, description, null) { }
        public ServiceError(int code, string description, Exception exception)
        {
            Code = code;
            Description = description;
            Exception = Exception;
        }
    }
}
