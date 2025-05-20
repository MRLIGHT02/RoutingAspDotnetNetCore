var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    // add your own endpoint
    endpoints.Map("map1", async (context) =>
    {
        await context.Response.WriteAsync("Map 1");
    });
    endpoints.Map("map2", async (context) =>
    {
        await context.Response.WriteAsync("Welcome to Map 2");
    });

});

//app.Map("map1", async(HttpContext context) =>
//{
//    await context.Response.WriteAsync("Welcom to Map 1");
//});
app.MapGet("/", () => "Hello World!");

app.Run();
