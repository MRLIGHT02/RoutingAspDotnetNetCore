using RoutingAspDotnetNetCore.CustomConstrains;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRouting(options =>
{
    options.ConstraintMap.Add("months"
    , typeof(MyCustomConstrain));
});
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
        await context.Response.WriteAsync("Welecome to file 1 :" + filename + "." + extension);
    });

    // passing default Value in route parameter
    endpoints.Map("sales-report/{year:int:min(1900)}/{month:months}", async (context) =>
    {
        string? month = Convert.ToString(context.Request.RouteValues["month"]);
        await context.Response.WriteAsync("Welcome to file: " + month);

    });

    endpoints.Map("data/{report:datetime}", async (context) =>
    {
        DateTime report = Convert.ToDateTime(context.Request.RouteValues["report"]);
        await context.Response.WriteAsync($"hello mr datetime {report}");
    });

    endpoints.Map("sales-report/2024/jan", async (context) =>
    {
        await context.Response.WriteAsync("sales report 2024 jan only");
    });

});




app.Run(async context =>
{
    await context.Response.WriteAsync($"Request recieved  at {context.Request.Path}");
});
app.MapGet("/", () => "Hello World!");

app.Run();
