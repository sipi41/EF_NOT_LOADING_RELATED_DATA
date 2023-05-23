using AppIdentity;
using ITT_OneTeam.Data;
using ITT_OneTeam.Identity;
using Microsoft.AspNetCore.Components;
using Microsoft.AspNetCore.Components.Authorization;
using Microsoft.AspNetCore.Components.Web;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using Syncfusion.Blazor;
using System.Security.Principal;

var builder = WebApplication.CreateBuilder(args);



builder.Services.AddRazorPages();
builder.Services.AddServerSideBlazor()
    .AddCircuitOptions(options => { 
        options.DetailedErrors = true;
    });


builder.Services.AddControllersWithViews(options => {   });

builder.Services.AddDbContextFactory<TSMC_ODS_DbContext>(options =>
{
    options.EnableDetailedErrors(true);
    options.EnableSensitiveDataLogging(true);
    options.UseSqlServer(builder.Configuration.GetConnectionString("SQLSRVRP6TSMC_ODS"));

}); 

//------------------------ ADDED LINES

builder.Services.AddScoped<TSMC_ODS_DbContext>(p => p.GetRequiredService<IDbContextFactory<TSMC_ODS_DbContext>>().CreateDbContext());

builder.Services.AddDefaultIdentity<AppIdentityUser>(options => { 
    options.User.AllowedUserNameCharacters = "abcdefghijklmnopqrstuvwxyzABCDEFGHIJKLMNOPQRSTUVWXYZ0123456789 ";
})
    .AddRoles<IdentityRole>()
    .AddEntityFrameworkStores<TSMC_ODS_DbContext>();

//builder.Services.AddScoped<AuthenticationStateProvider, RevalidatingIdentityAuthenticationStateProvider<AppIdentityUser>>();

//------------------------ ADDED LINES


builder.Services.AddSyncfusionBlazor();


builder.Services.AddSignalR(options => {
    options.MaximumReceiveMessageSize = 60 * 1024 * 60; //loading big data from Browser Storage require increase in message sizes...
});





var app = builder.Build();

Syncfusion.Licensing.SyncfusionLicenseProvider.RegisterLicense("MTk1Nzc5OUAzMjMxMmUzMjJlMzNNbytiZHZ1SEM1RmU1SHpzZHlKQytlN0d5SjVKK3JMVnVQRWNtWFUzUGNvPQ==");

if (!app.Environment.IsDevelopment())
{
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization(); //------------------------ ADDED LINES


app.MapControllers();

app.MapBlazorHub();
app.MapFallbackToPage("/_Host");

app.Run();
