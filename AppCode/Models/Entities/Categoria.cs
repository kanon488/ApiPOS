using System.ComponentModel.DataAnnotations;

namespace ApiPOS.AppCode.Models.Entities
{
    public class Categoria
    {
        public int Id { get; set; }
        [Required]
        [MaxLength(150)]
        public string Nombre { get; set; }

        public ICollection<Producto> Productos { get; set; } = new List<Producto>();
    }
}
