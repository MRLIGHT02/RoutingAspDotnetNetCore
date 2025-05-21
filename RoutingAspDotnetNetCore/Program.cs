var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// GetEndPointMethod


// enable routing
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    endpoints.Map("files/{filename}.{extension}", async context =>
    {
        await context.Response.WriteAsync("In files");
    });

});


//app.Map("map1", async(HttpContext context) =>
//{
//    await context.Response.WriteAsync("Welcom to Map 1");
//});
app.Run(async context =>
{
    await context.Response.WriteAsync($"Request recieved  at {context.Request.Path}");
});
app.MapGet("/", () => "Hello World!");

app.Run();
