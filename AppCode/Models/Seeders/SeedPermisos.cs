using ApiPOS.AppCode.Models.Entities;

namespace ApiPOS.AppCode.Models.Seeders
{
    public static class SeedPermisos
    {

        public static void Seed(ApiPOS.AppCode.DBContext.DBContext context)
        {
            if (!context.Permisos.Any())
            {
                var permisos = new List<Permiso>
                {
                    new Permiso { Nombre = "VerUsuarios" },
                    new Permiso { Nombre = "CrearUsuarios" },
                    new Permiso { Nombre = "EditarUsuarios" },
                    new Permiso { Nombre = "EliminarUsuarios" },
                    new Permiso { Nombre = "VerProductos" },
                    new Permiso { Nombre = "EditarProductos" },
                    new Permiso { Nombre = "EliminarProductos" },
                    new Permiso { Nombre = "CrearProductos" },
                    new Permiso { Nombre = "ConfigurarSistema" }
                };

                context.Permisos.AddRange(permisos);
                context.SaveChanges();
            }
        }
    }
}
