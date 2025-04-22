using System.ComponentModel.DataAnnotations;

namespace ApiPOS.AppCode.Models.Entities
{
    public class Cliente
    {
       
        public int Id { get; set; }

        [Required, MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;

        [MaxLength(100)]
        public string Apellido { get; set; } = string.Empty;

        [MaxLength(150)]
        public string Email { get; set; } = string.Empty;

        [MaxLength(20)]
        public string Telefono { get; set; } = string.Empty;

        [MaxLength(250)]
        public string Direccion { get; set; } = string.Empty;

        public bool Activo { get; set; } = true;
    }
}
