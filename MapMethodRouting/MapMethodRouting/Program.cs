using Microsoft.Extensions.Hosting;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();
app.UseRouting();

//app.MapGet("/", () => "Hello World!");
//app.Map("/Home", () =>"Hello World!");
//app.MapGet("/Home", () =>"Hello World! - Get");
//app.MapPost("/Home", () =>"Hello World! - Post");
//app.MapPut("/ Home", () =>"Hello World! - Put");
//app.MapDelete(" Home", () =>"Hello World! - Delete");

app.UseEndpoints(endpoints =>
{
	endpoints.MapGet("/Home", async (context) =>
	{
		await context.Response.WriteAsync("This is Home Page..GET");
	});
	endpoints.MapPost("/ Home", async (context) =>
	{
		await context.Response.WriteAsync("This is Home Page..POST");
	});
	endpoints.MapPut("/ Home", async (context) =>
	{
		await context.Response.WriteAsync("This is Home Page..PUT");
	});
	endpoints.MapDelete("/ Home", async (context) =>
	{
		await context.Response.WriteAsync("This is Home Page..DELETE");
	});
});


app.Run();
