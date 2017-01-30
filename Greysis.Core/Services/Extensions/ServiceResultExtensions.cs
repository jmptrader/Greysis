using Greysis.Core;
using Greysis.Core.Services;
using System;
using System.Linq;

namespace Greysis.Services.Extensions
{
    public static class ServiceResultExtensions
    {
        public static T ToClientResult<T>(this IServiceResult serviceResult) where T : IClientResult, new()
        {
            var client = Activator.CreateInstance<T>();
            client.IsSuccess = serviceResult.IsSuccess;
            if (serviceResult.Errors.Count > 0)
            {
                var firstError = serviceResult.Errors.FirstOrDefault();
                client.Code = firstError.Code;
                if (client is IClientDataResult)
                    ((IClientDataResult)client).Data = firstError.Data;
            }
            return client;
        }
        public static IServiceResult<TResult> ToResult<TResult>(this IServiceResult serviceResult)
        {
            var result = new ServiceResult<TResult>();
            result.Errors.AddRange(serviceResult.Errors);
            return result;
        }
        public static IServiceResult<TResult> ToResult<TResult>(this IServiceResult serviceResult, TResult result)
        {
            var resultTo = new ServiceResult<TResult>(result);
            resultTo.Errors.AddRange(serviceResult.Errors);
            return resultTo;
        }

    }
}
