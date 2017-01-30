using Greysis.Core;
using Greysis.Core.Services;
using System;
using System.Collections.Generic;
using System.Linq;

namespace Greysis.Services.Extensions
{
    public static class ServiceErrorExtensions
    {
        public static void Add(this List<IServiceError> list, int code, string description)
        {
            Add(list, code, description, null);
        }
        public static void Add(this List<IServiceError> list, string description)
        {
            Add(list, 0, description, null);
        }
        public static void Add(this List<IServiceError> list, int code, string description, Exception exception)
        {
            list.Add(new ServiceError(code, description, exception));
        }
        public static string JoinError(this IEnumerable<IServiceError> errors)
        {
            return string.Join(" ", errors.Select(e => e.Description));
        }
        public static bool HasError(this IEnumerable<IServiceError> errors, int code)
        {
            return errors.Any(e => e.Code.Equals(code));
        }
    }
}
