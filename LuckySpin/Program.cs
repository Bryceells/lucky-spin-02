using LuckySpin.Models;
var builder = WebApplication.CreateBuilder(args);

/* Install Services using the builder.Services methods */
// use the AddMvc Service to enable MVC for this application
builder.Services.AddMvc();


//DIJ Part 1: Register the TextTranform class as available for DIJ using th AddTransient Service;
builder.Services.AddTransient<TextTransform>();

var app = builder.Build();


/* Add Middleware to the HTTP Request-Response Pipeline */
app.UseStaticFiles();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller}/{action}/{luck:range(1,9)}",
    defaults: new {
        controller = "Spinner",
        action = "Index",
        luck = 7
    });

/* Start the app */
app.Run();

