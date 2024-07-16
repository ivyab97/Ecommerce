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
    public class ProductController : ControllerBase
    {
        private readonly IProductQueryService _queryService;
        private readonly IProductCommandService _commandService;
        private readonly IMapper _mapper;

        public ProductController(IProductQueryService queryService, IProductCommandService commandService, IMapper mapper)
        {
            _queryService = queryService;
            _commandService = commandService;
            _mapper = mapper;
        }



        /// <summary>
        /// Obtiene detalles de un producto específico.
        /// </summary>
        /// <remarks>
        /// Recupera los detalles de un producto por su ID único.
        /// </remarks>
        /// <response code="200">Éxito al recuperar los detalles del producto.</response>
        /// <response code="404">Producto no encontrado.</response>

        [HttpGet("{id:Guid}")]
        [ProducesResponseType(typeof(ProductResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status404NotFound)]
        public async Task<ActionResult> GetById(Guid id)
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



        /// <summary>
        /// Crea un nuevo producto.
        /// </summary>
        /// <remarks>
        /// Permite la creación de un nuevo producto en el sistema.
        /// </remarks>
        /// <response code="201">Producto creado con éxito</response>
        /// <response code="400">Solicitud incorrecta.</response>
        /// <response code="409">Conflicto, el producto ya existe.</response>

        [HttpPost]
        [ProducesResponseType(typeof(ProductResponse), StatusCodes.Status201Created)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status409Conflict)]
        public async Task<ActionResult> CreateEntity([FromBody] ProductRequest request)
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
        /// Obtiene una lista de productos
        /// </summary>
        /// <remarks>
        /// Recupera una lista de productos disponibles, con opciones de filtrado.
        /// </remarks>
        /// <param name="categories">Filtrar productos por categorías. Es posible filtrar por 1 o más categorias. Filtro opcional</param>
        /// <param name="name">Filtrar productos por nombre. Es posible filtrar por nombres incompletos</param>
        /// <param name="limit">Limita el número de productos devueltos.</param>
        /// <param name="offset">Número de productos a omitir antes de empezar a devolver los resultados.</param>
        /// <response code="200">Éxito al recuperar los productos.</response>

        [HttpGet]
        [ProducesResponseType(typeof(List<ProductGetResponse>), StatusCodes.Status200OK)]
        public async Task<ActionResult> GetAll(
            [FromQuery] List<int>? categories, 
            [FromQuery] string? name, 
            [FromQuery] int? limit, 
            [FromQuery] int offset = 0
            )
        {
            try
            {
                var response = await _queryService.GetAllPaged(categories, name, limit, offset);
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
        /// Actualiza un producto existente.
        /// </summary>
        /// <remarks>
        /// Permite la actualización de los detalles de un producto específico.
        /// </remarks>
        /// <response code="200">Producto actualizado con éxito.</response>
        /// <response code="400">Solicitud incorrecta.</response>
        /// <response code="404">Producto no encontrado.</response>
        /// <response code="409">Conflicto al actualizar el producto.</response>

        [HttpPut("{id:Guid}")]
        [ProducesResponseType(typeof(ProductResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status400BadRequest)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status409Conflict)]
        public async Task<ActionResult> UpdateEntity(Guid id, [FromBody] ProductRequest request)
        {
            try
            {
                if (!ModelState.IsValid)
                {
                    CustomValidation.ReturnError(ModelState);
                }
                var response = await _commandService.Update(id, request);
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
        /// Elimina un producto específico.
        /// </summary>
        /// <remarks>
        /// Permite la eliminación de un producto del sistema usando su ID.
        /// </remarks>
        /// <response code="200">Producto eliminado con éxito.</response>
        /// <response code="404">Producto no encontrado.</response>
        /// <response code="409">Conflicto al eliminar el producto.</response>

        [HttpDelete("{id:Guid}")]
        [ProducesResponseType(typeof(ProductResponse), StatusCodes.Status200OK)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status404NotFound)]
        [ProducesResponseType(typeof(ApiError), StatusCodes.Status409Conflict)]
        public async Task<ActionResult> DeleteById(Guid id)
        {
            try
            {
                var response = await _commandService.DeleteById(id);
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
