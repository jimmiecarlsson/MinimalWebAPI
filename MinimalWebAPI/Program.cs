
// WebApplication example for .NET 9.0
var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



// Routes for the endpoint
app.MapGet("/", () => "Hello World!");



// Run the application
app.Run();
