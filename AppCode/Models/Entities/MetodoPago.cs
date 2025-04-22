using System.ComponentModel.DataAnnotations;

namespace ApiPOS.AppCode.Models.Entities
{
    public class MetodoPago
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public int Nombre { get; set; }
        public bool Activo { get; set; } = true;
    }
}
