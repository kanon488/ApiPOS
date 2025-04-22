using System.ComponentModel.DataAnnotations;

namespace ApiPOS.AppCode.Models.Entities
{
    public class Permiso
    {
        public int Id { get; set; }
        [Required, MaxLength(50)]
        public String Nombre { get; set; }

        public ICollection<RolPermiso> RolPermisos { get; set; } = new List<RolPermiso>();
        
    }
}
