using ApiPOS.AppCode.Models.Entities;

namespace ApiPOS.AppCode.Models.Seeders
{
    public static class SeedRolpermiso
    {
        public static void Seed(ApiPOS.AppCode.DBContext.AppDBContext context)
        {
            if (!context.RolPermisos.Any())
            {
                var rolPermisos = new List<RolPermiso>
                {
                    // Permisos para Administrador (todos)
                    new RolPermiso { RolId = 1, PermisoId = 1 },
                    new RolPermiso { RolId = 1, PermisoId = 2 },
                    new RolPermiso { RolId = 1, PermisoId = 3 },
                    new RolPermiso { RolId = 1, PermisoId = 4 },
                    new RolPermiso { RolId = 1, PermisoId = 5 },
                    new RolPermiso { RolId = 1, PermisoId = 6 },
                    new RolPermiso { RolId = 1, PermisoId = 7 },
                    new RolPermiso { RolId = 1, PermisoId = 8 },
                    new RolPermiso { RolId = 1, PermisoId = 9 },

                    // Permisos para Usuario (solo ver usuarios y reportes)
                    new RolPermiso { RolId = 2, PermisoId = 1 },
                    new RolPermiso { RolId = 2, PermisoId = 5 },

                    //Cliente
                    new RolPermiso { RolId = 3, PermisoId = 5 },

                };

                context.RolPermisos.AddRange(rolPermisos);
                context.SaveChanges();
            }
        }
    }
}
