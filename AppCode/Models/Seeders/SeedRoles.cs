using ApiPOS.AppCode.Models.Entities;

namespace ApiPOS.AppCode.Models.Seeders
{
    public static class SeedRoles
    {
        public static void Seed(ApiPOS.AppCode.DBContext.AppDBContext context)
        {
            if (!context.Roles.Any()) 
            {
                var roles = new List<Rol>
                {
                    new Rol { Nombre = "Administrador" },
                    new Rol { Nombre = "Usuario" },
                    new Rol { Nombre = "Cliente" }
                };

                context.Roles.AddRange(roles);
                context.SaveChanges();
            }
        }
    }
}
