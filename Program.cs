using ApiPOS.AppCode.DBContext;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var app = builder.Build();

builder.Services.AddDbContext<DBContext>(options => 
{
    if (builder.Configuration["AMBIENTE"] == "PROD")
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("CONEXION_PROD"));
    }
    else
    {
        options.UseSqlServer(builder.Configuration.GetConnectionString("CONEXION_DVLP"));
    }
});

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.Run();


