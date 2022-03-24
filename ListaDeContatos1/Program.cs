using ListaDeContatos1.Data;
using ListaDeContatos1.Repositories;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Configuracao de conexao com MySql
var connectionString = "server=localhost; user=root; password=root; database=DB_TreinoAsp";
var serverVersion = ServerVersion.AutoDetect(connectionString);

builder.Services.AddDbContext<AppDbContext>(dbContextOptions =>
    dbContextOptions.UseMySql(connectionString, serverVersion));

//injeção de dependencia
builder.Services.AddScoped<IContatoRepository, ContatoRepository>(); 

// Add services to the container.
builder.Services.AddControllersWithViews();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
}
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
