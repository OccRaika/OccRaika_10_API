using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Raika_OCC_10_API.Entidades;
using Raika_OCC_10_API.Entidades.Perfil;
using Raika_OCC_10_API_10_API.Entidades;

var builder = WebApplication.CreateBuilder(args);

// Área de servicios

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

builder.Services.AddDbContext<OCCRaikaDbContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddIdentity<Perfil, IdentityRole<Guid>>(ptions =>
{
    //Configurar opciones de Identity
}).AddEntityFrameworkStores<OCCRaikaDbContext>()
  .AddDefaultTokenProviders()
  .AddClaimsPrincipalFactory<UserClaimsPrincipalFactory<Perfil, IdentityRole<Guid>>>()
  .AddSignInManager<SignInManager<Perfil>>();

var app = builder.Build();

// Área de middlewares
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
