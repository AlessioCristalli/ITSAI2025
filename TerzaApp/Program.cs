
using TerzaApp.Components;
using TerzaApp.Dati;

WebApplicationBuilder builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder
    .Services
    .AddSingleton<Archivio>(i =>
    {   // nel momento in cui il singleton viene creato viene creato
        Archivio nuovo = new Archivio();
        nuovo.Recupera(); // lancio il recupero dell'archivio da disco
        return nuovo; // e lo restituisco al sistema che lo mette a disposizione
    })
    .AddRazorComponents()
    .AddInteractiveServerComponents();

WebApplication app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();

app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();
