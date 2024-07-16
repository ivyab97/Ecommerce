using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Request
{
    public class SaleProductRequest
    {
        [Required(ErrorMessage = "El ID del producto es obligatorio.")]
        [RegularExpression(@"(?im)^[{(]?[0-9A-F]{8}[-]?(?:[0-9A-F]{4}[-]?){3}[0-9A-F]{12}[)}]?$", ErrorMessage = "El ID del producto no es válido, debe estar en formato Guid.")]
        public Guid productId { get; set; }

        [Required(ErrorMessage = "La cantidad de productos es obligatoria.")]
        [Range(1, int.MaxValue, ErrorMessage = "La cantidad de productos debe ser mayor a cero.")]
        [DefaultValue(0)]
        public int quantity { get; set; }
    }
}
