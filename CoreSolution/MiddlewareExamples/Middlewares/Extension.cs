namespace MiddlewareExamples.Middlewares
{
    public static class MyCustomMiddlewareExtensions
    {
        public static IApplicationBuilder UseMonMiddleWare(
            this IApplicationBuilder builder)
        {
            return builder.UseMiddleware<MonMiddleware>();
        }
    }
}
