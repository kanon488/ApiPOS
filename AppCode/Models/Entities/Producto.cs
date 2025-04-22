using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ApiPOS.AppCode.Models.Entities
{
    public class Producto
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "El nombre es obligatorio.")]
        [StringLength(100, ErrorMessage = "El nombre no puede tener más de 100 caracteres.")]
        public string Nombre { get; set; }
        [StringLength(500, ErrorMessage = "La descripción no puede tener más de 500 caracteres.")]
        public string Descripcion { get; set; }
        //Precio máximo que un comprador puede pagar por un producto antes de cualquier descuento
        [Range(0, double.MaxValue, ErrorMessage = "El precio de lista debe ser un valor positivo.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioLista { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "El precio normal debe ser un valor positivo.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioNormal { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "El precio de venta debe ser un valor positivo.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioVenta { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "El precio sin impuesto debe ser un valor positivo.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioSinImpuesto { get; set; }
        [Range(0, double.MaxValue, ErrorMessage = "El precio de venta sin descuento debe ser un valor positivo.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal PrecioVentaSinDescuento { get; set; }
        [Range(0, 100, ErrorMessage = "El descuento debe estar entre 0 y 100%.")]
        [Column(TypeName = "decimal(18,2)")]
        public decimal DescuentoPctje { get; set; }
        [RegularExpression(@"^\d+$", ErrorMessage = "El código de barras solo puede contener números.")]
        public string CodigoBarras { get; set; }
        [Range(0, int.MaxValue, ErrorMessage = "La existencia no puede ser negativa.")]
        public int Existencia { get; set; }
        [RegularExpression(@"^(https?:\/\/[\w\-\.]+(\.[a-z]{2,})?(:\d+)?(\/[\w\-\.]*)*|(\w+\/)+[\w\-\.]+\.\w{2,4})$",
       ErrorMessage = "Debe ser una URL válida o una ruta relativa (ej. imagenes/productos/foto.png).")]
        public string? UrlImagen { get; set; }

        #region Relaciones
        public int CategoriaId { get; set; }
        public Categoria? Categoria { get; set; }

        public int AlmacenId { get; set; }
        public Almacen? Almacen { get; set; }
        #endregion


    }
}
