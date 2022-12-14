namespace PollDog.API.Middlewares
{
    using Microsoft.Data.SqlClient;
    using PollDog.API.SqlExceptions;

    /// <summary>ExceptionMiddleware class.</summary>
    public class ExceptionMiddleware
    {
        /// <summary>The next</summary>
        private RequestDelegate next;

        /// <summary>Initializes a new instance of the <see cref="ExceptionMiddleware" /> class.</summary>
        /// <param name="next">The next.</param>
        public ExceptionMiddleware(RequestDelegate next)
        {
            this.next = next;
        }

        /// <summary>Invokes the asynchronous.</summary>
        /// <param name="httpContext">The HTTP context.</param>
        /// <returns>Returns task.</returns>
        public async Task InvokeAsync(HttpContext httpContext)
        {
            try
            {
                await this.next(httpContext);
            }
            catch (SqlException ex)
            {
                httpContext.Response.StatusCode = (int)ExceptionStatusCodes.GetExceptionStatusCode(ex);
                await httpContext.Response.WriteAsync(ex.Message);
            }
        }
    }
}
