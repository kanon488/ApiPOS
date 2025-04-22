using System.ComponentModel.DataAnnotations;
using System.Numerics;

namespace ApiPOS.AppCode.Models.Entities
{
    public class Almacen
    {
        public int Id { get; set;}
        [Required]
        [MaxLength(100)]
        public string Nombre { get; set; } = string.Empty;
        public string Locacion { get; set; } = string.Empty;

        public ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}
