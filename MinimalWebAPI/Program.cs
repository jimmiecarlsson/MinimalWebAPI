
// WebApplication example for .NET 9.0
using System.Runtime.CompilerServices;

var builder = WebApplication.CreateBuilder(args);
var app = builder.Build();



// Routes for the endpoint
app.MapGet("/", () => "Home page");
app.MapGet("/about", () => "About page");
app.MapGet("/contact", () => "Contact page");
app.MapGet("/products/{category}", (string category) => $"Product is of category: {category}");
app.MapGet("/products/{category}/items/{id:int}", (string category, int id) => $"Product is of category: {category} with id: {id}");
app.MapGet("/{random}", (string random) => $"The page {random} does not exist." );

// Run the application
app.Run();
