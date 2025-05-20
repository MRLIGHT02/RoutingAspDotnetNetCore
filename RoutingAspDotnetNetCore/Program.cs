var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    endpoints.Map("/map1", async (HttpContext context, RequestDelegate next) =>
    {
        await context.Response.WriteAsync("hello world");
    });

});
app.MapGet("/", () => "Hello World!");

app.Run();
