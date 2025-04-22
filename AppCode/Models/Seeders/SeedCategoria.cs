using ApiPOS.AppCode.Models.Entities;

namespace ApiPOS.AppCode.Models.Seeders
{
    public static class SeedCategoria
    {
        public static void Seed(ApiPOS.AppCode.DBContext.DBContext context) 
        {
            if (!context.Categorias.Any())
            {
                var categorias = new List<Categoria> 
                {
                    new Categoria { Nombre = "Bebidas" },
                    new Categoria { Nombre = "Lácteos" },
                    new Categoria { Nombre = "Panadería" },
                    new Categoria { Nombre = "Carnes y Embutidos" },
                    new Categoria { Nombre = "Frutas y Verduras" },
                    new Categoria { Nombre = "Snacks" },
                    new Categoria { Nombre = "Abarrotes" },  // Ej: arroz, azúcar, pastas
                    new Categoria { Nombre = "Limpieza" },
                    new Categoria { Nombre = "Cuidado Personal" },
                    new Categoria { Nombre = "Farmacia" },
                    new Categoria { Nombre = "Electrónica" },
                    new Categoria { Nombre = "Ropa y Calzado" },
                    new Categoria { Nombre = "Accesorios" },
                    new Categoria { Nombre = "Juguetes" },
                    new Categoria { Nombre = "Ferretería" },
                    new Categoria { Nombre = "Papelería" },
                    new Categoria { Nombre = "Mascotas" },
                    new Categoria { Nombre = "Hogar" },
                    new Categoria { Nombre = "Herramientas" },
                    new Categoria { Nombre = "Bebidas Alcohólicas" },
                    new Categoria { Nombre = "Congelados" },
                    new Categoria { Nombre = "Cigarrillos y Tabaco" },
                    new Categoria { Nombre = "Recargas Electrónicas" },
                    new Categoria { Nombre = "Servicios" }
                };

                context.Categorias.AddRange(categorias);
                context.SaveChanges();
            }
        }
    }
}
