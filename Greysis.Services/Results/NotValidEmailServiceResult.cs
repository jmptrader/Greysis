using Greysis.Core.Extensions;
using Greysis.Core.Services;
using Greysis.Services.Const;
using Greysis.Services.Extensions;

namespace Greysis.Services.Results
{
    public class NotValidEmailServiceResult : ServiceResult
    {
        public NotValidEmailServiceResult(string email)
        {
            if (string.IsNullOrEmpty(email))
                Errors.Add(ServiceErrors.InvalidRequest, "Email is null");

            if (!email.IsValidMailAddress())
                Errors.Add(ServiceErrors.InvalidRequest, "Invalid email");
        }
    }   
}
