var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// GetEndPointMethod


// enable routing
app.UseRouting();

app.UseEndpoints(endpoints =>
{


});




app.Run(async context =>
{
    await context.Response.WriteAsync($"Request recieved  at {context.Request.Path}");
});
app.MapGet("/", () => "Hello World!");

app.Run();
