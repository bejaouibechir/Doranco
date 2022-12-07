//#define technique1
//#define technique2
#define technique3

using MVCCore;
using MVCCore.Extensions;
using MVCCore.Services;
using System.Diagnostics;

#if technique1
ServiceDescriptor descriptor = new ServiceDescriptor(typeof(IEventLogService),
    typeof(EventLogService), ServiceLifetime.Singleton);
#endif

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

#if technique1
builder.Services.Add(descriptor); //Creation de service 
#endif

#if technique2
builder.Services.AddSingleton<IEventLogService, EventLogService>(); //Creation de service 
#endif

#if technique3
builder.Services.AddEventLogService();
#endif


//Ajouter le service de configuration
var currentConfig = builder.Configuration;

var app = builder.Build();

// Configure the HTTP request pipeline.
//if (!app.Environment.IsDevelopment())
//{
//    app.UseExceptionHandler("/Home/Error");
//    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
//    app.UseHsts();
//}

if(app.Environment.IsDevelopment())
{
    Debug.WriteLine("Nous sommes dans un contexte de développement");
}
else if (app.Environment.IsStaging()) //Test
{
    Debug.WriteLine("Nous sommes dans un contexte de test");
}
else if (app.Environment.IsProduction()) //Production
{
    var temp = DateTime.Now;
    EventLog.WriteEntry("Application",
        $"Nous sommes dans un contexte de production {temp.Hour}:{temp.Minute}"
        ,EventLogEntryType.Information);
}



app.UseXXX();

app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
