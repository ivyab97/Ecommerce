using System.ComponentModel;
using System.ComponentModel.DataAnnotations;

namespace Application.DTO.Request
{
    public class SaleRequest
    {
        [Required(ErrorMessage = "Se deben ingresar los productos a vender.")]
        public List<SaleProductRequest>? products { get; set; }

        [Required(ErrorMessage = "El total de pago es obligatorio.")]
        [Range(1, int.MaxValue, ErrorMessage = "El total de pago debe ser mayor a cero.")]
        [DefaultValue(0)]
        public double totalPayed { get; set; }
    }
}
