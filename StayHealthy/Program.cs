var builder = WebApplication.CreateBuilder(args);

// Registra los servicios de Razor Pages
builder.Services.AddRazorPages();

var app = builder.Build();

// Configuración del pipeline HTTP.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles(); // Habilita el uso de archivos en wwwroot

app.UseRouting();
app.UseAuthorization();

app.MapRazorPages();

app.Run();
