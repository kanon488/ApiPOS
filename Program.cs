using ApiPOS.AppCode.DBContext;
using ApiPOS.AppCode.Models.Seeders;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

using (var scope = app.Services.CreateScope()) 
{
    using var dbContext = new DBContext();
    //SeedAlmacenes.Seed(dbContext);
    //SeedCategoria.Seed(dbContext);
    //SeedProductos.Seed(dbContext);
    //SeedPermisos.Seed(dbContext);
    //SeedRoles.Seed(dbContext);
    //SeedRolpermiso.Seed(dbContext);
}

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.Run();


