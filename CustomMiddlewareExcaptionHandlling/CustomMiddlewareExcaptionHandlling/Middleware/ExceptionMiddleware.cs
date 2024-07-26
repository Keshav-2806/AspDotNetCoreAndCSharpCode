using CustomMiddlewareExcaptionHandlling.Model;
using Newtonsoft.Json;

namespace CustomMiddlewareExcaptionHandlling.Middleware
{
    public class ExceptionMiddleware
    {
        // Request Delegate will call the next middleware
        private readonly RequestDelegate _nextMidlleware;

        public ExceptionMiddleware(RequestDelegate nextMidlleware)
        {
            _nextMidlleware = nextMidlleware;
        }

        public async Task InvokeAsync(HttpContext context)
        {
            try
            {
                await _nextMidlleware(context);

            }
            catch 
            {
                context.Response.ContentType = "application/problem+json";
                context.Response.StatusCode = StatusCodes.Status500InternalServerError;
                var error = new Error
                {
                    Title = "Error during running the code",
                    Status = "internal Server Error"
                };

                var result = JsonConvert.SerializeObject(error);
                await context.Response.WriteAsync(result);
            }
        }
    }
}
