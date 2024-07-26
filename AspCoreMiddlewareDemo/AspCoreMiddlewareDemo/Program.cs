var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

//app.MapGet("/", () => "Hello World!");

//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Welecome to ASP.NET Core 6");
//});
//app.Run(async (context) =>
//{
//    await context.Response.WriteAsync("Hello to ASP.NET Core 6");
//});
app.Use(async (context, next) =>
{
    await context.Response.WriteAsync("Welcome to cognizant.");
    await next(context);
});

app.Use(async (context,next) =>
{
    await context.Response.WriteAsync("hello to asp.net core 6");
    await next(context);
});

app.Run();
