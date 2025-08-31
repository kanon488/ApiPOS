using ApiPOS.AppCode.DBContext;
using ApiPOS.AppCode.Models.Seeders;
using ApiPOS.AppCode.Repositories;
using ApiPOS.AppCode.Services;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.OpenApi.Models;
using System.Reflection;

var builder = WebApplication.CreateBuilder(args);

// Repositories
builder.Services.AddScoped<IProductRepository, ProductRepository>();

//Services
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddDbContext<AppDBContext>();

builder.Services.AddCors(options => 
    options.AddPolicy("*", builder =>
        builder.AllowAnyOrigin()
               .AllowAnyMethod()
               .AllowAnyHeader())
);


builder.Services.AddEndpointsApiExplorer();

builder.Services.AddControllers();

builder.Services.AddSwaggerGen(config =>
    {
    var groupName = "v1";

    config.SwaggerDoc(groupName, new OpenApiInfo
    {
        Title = "API_POS 2025",
        Version = groupName,
        Description = "API_POS"
    });

    var xmlFile = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    var xmlPath = Path.Combine(AppContext.BaseDirectory, xmlFile);
    config.IncludeXmlComments(xmlPath);
});


var app = builder.Build();

using (var scope = app.Services.CreateScope()) 
{
    using var dbContext = new AppDBContext();
    //SeedAlmacenes.Seed(dbContext);
    //SeedCategoria.Seed(dbContext);
    //SeedProductos.Seed(dbContext);
    //SeedPermisos.Seed(dbContext);
    //SeedRoles.Seed(dbContext);
    //SeedRolpermiso.Seed(dbContext);
}

// Configure the HTTP request pipeline.

if (app.Environment.IsDevelopment()) // Typically enabled only in Development
{
    app.UseSwagger();
    app.UseSwaggerUI(config =>{
        config.SwaggerEndpoint("v1/swagger.json", "API_POS 2025");
        
    });
}

app.UseHttpsRedirection();
app.UseRouting();
app.UseCors("*");
app.UseEndpoints(endpoints =>
{
    endpoints.MapControllers();
});
app.Run();


