namespace Middleware.CustomMiddleware
{
    public class MyCustomMiddleware : IMiddleware
    {
        public async Task InvokeAsync(HttpContext context, RequestDelegate next)
        {
            await context.Response.WriteAsync("My Custom Midlleware - Starts !");
            await context.Response.WriteAsync("My Custom Midlleware - Ends !");
        }
    }
}
