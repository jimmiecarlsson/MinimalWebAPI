
// WebApplication example for .NET 9.0
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



// Routes for the endpoint
app.MapGet("/", () => "Home page");
app.MapGet("/about", () => "About page");
app.MapGet("/contact", () => "Contact page");


// Run the application
app.Run();
