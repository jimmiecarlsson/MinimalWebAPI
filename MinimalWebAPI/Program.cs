

// Create a builder with a instance of WebApplication
var builder = WebApplication.CreateBuilder(args);
builder.Services.AddRazorPages();

var app = builder.Build();
app.UseStaticFiles();
app.MapRazorPages();

// Routes for the endpoints

//app.MapGet("/", () => );
//app.MapGet("/about", () => "About page");
//app.MapGet("/contact", () => "Contact page");
//app.MapGet("/products/{category}", (string category) => $"Product is of category: {category}");
//app.MapGet("/products/{category}/items/{id:int}", (string category, int id) => $"Product is of category: {category} with id: {id}");
//app.MapGet("/{random}", (string random) => $"The page {random} does not exist." );

app.MapGet("/", () => Results.Redirect("/Index"));

// Run the application
app.Run();
