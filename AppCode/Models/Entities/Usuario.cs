using System.ComponentModel.DataAnnotations;

namespace ApiPOS.AppCode.Models.Entities
{
    public class Usuario
    {
        public int Id { get; set; }
        [Required, MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;
        [Required, MaxLength(100)]
        public string Apellidos { get; set; } = string.Empty;
        [Required, MaxLength(150)]
        public string Email { get; set; } = string.Empty;
        [Required]
        public string PaswordHash { get; set; } = string.Empty;
        public bool Activo { get; set; } = true;

        public ICollection<UsuarioRol> UsuarioRoles { get; set; } = new List<UsuarioRol>();
    }
}
