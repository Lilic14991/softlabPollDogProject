using System.Net;
using Microsoft.Data.SqlClient;

namespace PollDog.API.SqlExceptions
{
    public static class ExceptionStatusCodes
    {
        private static Dictionary<Type, HttpStatusCode> exceptionStatusCodes = new Dictionary<Type, HttpStatusCode>
        {
            { typeof(HttpStatusCode), HttpStatusCode.BadRequest },
            { typeof(HttpStatusCode), HttpStatusCode.Forbidden }
        };

        public static HttpStatusCode GetExceptionStatusCode(SqlException exception)
        {
            bool exceptionFound = exceptionStatusCodes.TryGetValue(exception.GetType(), out HttpStatusCode statusCode);
            return exceptionFound ? statusCode : HttpStatusCode.InternalServerError;
        }
    }
}
