namespace PollDog.API.Middlewares
{
    using Microsoft.Data.SqlClient;
    using PollDog.API.SqlExceptions;

    /// <summary>Middleware Extensions class.</summary>
    public static class MiddlewareExtensions
    {
        /// <summary>Uses the exception middleware.</summary>
        /// <param name="builder">The builder.</param>
        /// <returns>Returns a class that provides the mechanisms to configure an application's request pipeline.</returns>
        public static IApplicationBuilder UseExceptionMiddleware(this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<ExceptionMiddleware>();
        }
    }
}
