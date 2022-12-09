using System.Diagnostics;

namespace MiddlewareExamples.Middlewares
{
    public class MonMiddleware
    {
        RequestDelegate _next;

        public MonMiddleware(RequestDelegate next)
        {
            _next = next;
        }

        public async Task Invoke(HttpContext context)
        {
            Debug.WriteLine($"Le middle ware est lancé pendant la requête à {DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond}");
            await _next(context);
            context.Response.Redirect("http://www.google.com");
        }
    }
}
