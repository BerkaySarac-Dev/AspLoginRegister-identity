using Middleware.CustomMiddleware;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddTransient<MyCustomMiddleware>();
var app = builder.Build();

app.MapGet("/", () => "Hello World!");
app.Use(async(HttpContext context,RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello");
    await next(context);
});
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("Hello again");
    await next(context);
});
app.UseMiddleware<MyCustomMiddleware>();
app.Use(async (HttpContext context, RequestDelegate next) =>
{
    await context.Response.WriteAsync("and Hello");
    await next(context);
});
app.Run(async (HttpContext context) =>
{
    await context.Response.WriteAsync("Hello Again");
});
app.Run();
