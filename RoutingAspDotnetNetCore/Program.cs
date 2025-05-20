var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

app.UseRouting();
app.UseEndpoints(endpoints =>
{
    // add your own endpoint
    endpoints.Map("map1", async (context) =>
    {
        await context.Response.WriteAsync("mr light");
    });

});
app.MapGet("/", () => "Hello World!");

app.Run();
