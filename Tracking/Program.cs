using Microsoft.EntityFrameworkCore;
using Tracking.Data;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddDbContext<IssueDbContext>(o => o.UseInMemoryDatabase("Issues"));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}
app.UseFileServer();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
