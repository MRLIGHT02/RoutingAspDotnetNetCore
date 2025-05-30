var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();

// GetEndPointMethod


// enable routing
app.UseRouting();

app.UseEndpoints(endpoints =>
{
    // adding my endpoint
    endpoints.Map("file/data/{filename}.{extension}", async (context) =>
    {
        string? filename = Convert.ToString(context.Request.RouteValues["filename"]);
        string? extension = Convert.ToString(context.Request.RouteValues["extension"]);
        await context.Response.WriteAsync("Welecome to file 1 :"+filename+"."+extension);
    });

    // passing default Value in route parameter
    endpoints.Map("file/emp/{filenamedata=harsha}", async (context) => {
        string? filenamedata = Convert.ToString(context.Request.RouteValues["filenamedata"]);
        await context.Response.WriteAsync("Welcome to file: " + filenamedata);
    });

});




app.Run(async context =>
{
    await context.Response.WriteAsync($"Request recieved  at {context.Request.Path}");
});
app.MapGet("/", () => "Hello World!");

app.Run();
