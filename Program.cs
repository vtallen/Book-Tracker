using BookTracker.Components;
using BookTracker.OpenLibraryAPI;
/*
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
*/
OpenLibraryAPI testAPI = new("BookTracker", 1.0, "vincent@vtallen.com");
var searchResults = await testAPI.Search("the lord of the rings");
foreach (var result in searchResults)
{
    Console.WriteLine(result);
    Console.WriteLine();
}