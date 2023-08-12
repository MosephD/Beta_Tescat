using Microsoft.EntityFrameworkCore;
using Beta_Tescat_0._1.Persistence;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddHttpClient();


builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor();

//Registering the DbContext as a service
builder.Services.AddDbContext<TescatContext>(
    opt => opt.UseSqlServer(
       builder.Configuration.GetConnectionString("TescatDb")));



var app = builder.Build();



// Applying the Migrations at Runtime 
// Not for production, just for development
/*await EnsureDatabaseIsMigrated(app.Services);

async Task EnsureDatabaseIsMigrated(IServiceProvider services)
{
    using var scope = services.CreateScope();
    using var ctx = scope.ServiceProvider.GetService<TescatContext>();
    if (ctx is not null)
    {
        await ctx.Database.MigrateAsync();
    }
}*/




// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{

}
else
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
