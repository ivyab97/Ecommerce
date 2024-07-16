using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Request
{
    public class ProductRequest
    {
        [Required(ErrorMessage = "El nombre del producto es obligatorio.")]
        public string? name { get; set; }
        public string? description { get; set; }

        [Required(ErrorMessage = "El precio del producto es obligatorio.")]
        [Range(1, double.MaxValue, ErrorMessage = "El precio del producto debe ser mayor a cero.")]
        [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "El precio del producto debe ser un número válido.")]
        public double price { get; set; }

        [Required(ErrorMessage = "El descuento del producto es obligatorio.")]
        [Range(0, 100, ErrorMessage = "El descuento debe estar entre 0 y 100.")]
        [RegularExpression(@"^\d+(\.\d+)?$", ErrorMessage = "El descuento del producto debe ser un número válido.")]
        public int discount { get; set; }
        public string? imageUrl { get; set; }

        [Required(ErrorMessage = "La categoría del producto es obligatoria.")]
        [Range(1, int.MaxValue, ErrorMessage = "La categoria del producto debe ser mayor a cero.")]
        [DefaultValue(0)]
        public int category { get; set; }
    }
}
