
using ApiPOS.AppCode.Models.Entities;

namespace ApiPOS.AppCode.Models.Seeders
{
    public static class SeedAlmacenes
    {
        public static void Seed(ApiPOS.AppCode.DBContext.DBContext context)
        {
            if (!context.Almacenes.Any()) 
            {
                var almacenes = new List<Almacen>
                {
                    new Almacen { Nombre = "Almacen Puerto", Locacion = "Xalapa, Veracruz"},
                    new Almacen { Nombre = "Almacen Central", Locacion = "Ciudad de México"},
                    new Almacen { Nombre = "Almacen Noroeste", Locacion = "Guadalajara, Jalisco"},
                    new Almacen { Nombre = "Almacen Noreste", Locacion = "Monterrey, Nuevo Leon"}

                };

                context.Almacenes.AddRange(almacenes);
                context.SaveChanges();
            }
        }
    }
}
