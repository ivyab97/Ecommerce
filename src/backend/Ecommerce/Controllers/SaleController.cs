using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using Application.Interfaces;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;

namespace Ecommerce.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SaleController : ControllerBase
    {
        private readonly ISaleQueryService _queryService;
        private readonly ISaleCommandService _commandService;
        private readonly IMapper _mapper;

        public SaleController(ISaleQueryService queryService, ISaleCommandService commandService, IMapper mapper)
        {
            _queryService = queryService;
            _commandService = commandService;
            _mapper = mapper;
        }



        /// <summary>
        /// Obtiene un listado de ventas.
        /// </summary>
        /// <remarks>
        /// Recupera un resumen de las ventas realizadas, con opción de filtrado por fecha.
        /// </remarks>
        /// <response code="200">Éxito al recuperar las ventas.</response>
        /// <response code="400">Solicitud incorrecta.</response>

        [HttpGet]
        [ProducesResponseType(typeof(List<SaleGetResponse>), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> GetAll([FromQuery] DateTime? from, [FromQuery] DateTime? to)
        {
            try
            {
                var response = await _queryService.GetAll(from, to);
                return new JsonResult(response) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    return new JsonResult(_mapper.Map<ApiError>(e)) { StatusCode = (int)((HTTPError)e).StatusCode };
                }
                return new JsonResult(_mapper.Map<ApiError>(new InternalServerErrorException("Ha ocurrido un error en el servicodor."))) { StatusCode = 500 };
            }
        }



        /// <summary>
        /// Registra una nueva venta.
        /// </summary>
        /// <remarks>
        /// Permite ingresar una nueva venta al sistema.
        /// </remarks>
        /// <response code="201">Venta registrada con éxito.</response>
        /// <response code="400">Solicitud incorrecta.</response>

        [HttpPost]
        [ProducesResponseType(typeof(SaleResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status400BadRequest)]
        public async Task<ActionResult> CreateSale(SaleRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    CustomValidation.ReturnError(ModelState);
                }
                var response = await _commandService.Create(request);
                return new JsonResult(response) { StatusCode = 201 };
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    return new JsonResult(_mapper.Map<ApiError>(e)) { StatusCode = (int)((HTTPError)e).StatusCode };
                }
                return new JsonResult(_mapper.Map<ApiError>(new InternalServerErrorException("Ha ocurrido un error en el servicodor."))) { StatusCode = 500 };
            }
        }



        /// <summary>
        /// Obtiene los detalles de una venta específica.
        /// </summary>
        /// <remarks>
        /// Recupera los detalles de una venta por su ID único.
        /// </remarks>
        /// <response code="200">Éxito al recuperar los detalles de la venta.</response>
        /// <response code="404">Venta no encontrada.</response>

        [HttpGet("{id:int}")]
        [ProducesResponseType(typeof(SaleResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetById(int id)
        {
            try
            {
                var response = await _queryService.GetById(id);
                return new JsonResult(response) { StatusCode = 200 };
            }
            catch (Exception e)
            {
                if (e is HTTPError)
                {
                    return new JsonResult(_mapper.Map<ApiError>(e)) { StatusCode = (int)((HTTPError)e).StatusCode };
                }
                return new JsonResult(_mapper.Map<ApiError>(new InternalServerErrorException("Ha ocurrido un error en el servicodor."))) { StatusCode = 500 };
            }
        }

    }
}
