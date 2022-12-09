//#define userun
//#define mapmapwhen
//#define middlewareclass

using MiddlewareExamples.Middlewares;
using System.Diagnostics;
using System.Security;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}



app.UseHttpsRedirection();

app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();




#if middlewareclass
app.UseMonMiddleWare();
#endif


/*app.Use(async (context, next) =>
{
    //Zonne des requêtes avant le next();
    
    Debug.WriteLine($"Le chemin vers la requête: {context.Request.Path}");   
   
    await next();

    //Zonne des réponses avant le next();
    Debug.WriteLine($"Le status de la réponse: {context.Response.StatusCode}");
});*/

#region suite d'appels des middleware
#if userun
app.Use(async (context, next) =>
{
    
    Debug.WriteLine($"Appel de middleware 1 pendant la requête");
    await next();
    Debug.WriteLine($"Appel de middleware 1 pendant la réponse");
});

app.Use(async (context, next) =>
{
    Debug.WriteLine($"Appel de middleware 2 pendant la requête");
    await next();
    Debug.WriteLine($"Appel de middleware 2 pendant la réponse");
});

app.Use(async (context, next) =>
{
    Debug.WriteLine($"Appel de middleware 3 pendant la requête");
    await next();
    Debug.WriteLine($"Appel de middleware 3 pendant la réponse");
});

app.Run(async context =>
{
    Debug.WriteLine($"Terminus");
});

app.Use(async (context, next) =>
{
    Debug.WriteLine($"Appel de middleware 4 pendant la requête");
    await next();
    Debug.WriteLine($"Appel de middleware 4 pendant la réponse");
});
#endif

#endregion


#region map & mapwhen 

#if mapmapwhen 

app.Map("/machin", mid => mid.Use(async(context, next)=>{
    
    Debug.WriteLine($"Le middle ware est lancé pendant la requête à {DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond}");
    await next();
    context.Response.Redirect("Home/Error");
}));

int x = 2; //x = 3

app.MapWhen(context => (x==2), mid => mid.Use(async (context, next) => {
    Debug.WriteLine($"Le middle ware est lancé pendant la requête à {DateTime.Now.Minute}:{DateTime.Now.Second}:{DateTime.Now.Millisecond}");
    await next();
    
}));

#endif

#endregion






app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
