using aplicacionesMA.implementaciones;
using aplicacionesMA.interfaces;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllers();
builder.Services.AddScoped<IConexion, Conexion>();
builder.Services.AddScoped<IVehiculosAplicacion, VehiculosAplicacion>();

var app = builder.Build();

app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.MapGet("/", () => "");
app.Run();
