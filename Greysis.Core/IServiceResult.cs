using Greysis.Core;
using System.Collections.Generic;

namespace Greysis.Services
{

    public interface IServiceResult
    {
        bool IsSuccess { get; }
        List<IServiceError> Errors { get; }
    }
    public interface IServiceResult<TResult> : IServiceResult
    {
        TResult Result { get; set; }
    }
}
