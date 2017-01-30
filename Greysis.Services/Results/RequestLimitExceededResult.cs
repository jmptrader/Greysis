using Greysis.Core.Services;
using Greysis.Services.Const;
using System;

namespace Greysis.Services.Results
{
    public class RequestLimitExceededResult : ServiceResult
    {
        public RequestLimitExceededResult(DateTime lastRequestDate, int timeOutMinute)
        {
            Errors.Add(new ServiceError(ServiceErrors.MaximumRequestLimit, "Request limit exceeded")
            {
                Data = lastRequestDate.AddMinutes(timeOutMinute).Subtract(DateTime.Now).TotalSeconds
            });
        }
    }
}
