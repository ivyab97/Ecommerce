using Application.DTO.Error;
using Application.DTO.Request;
using Application.DTO.Response;
using AutoMapper;
using Domain.Entities;

namespace Application.DTO.Config
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            CreateMap<HTTPError, ApiError>().ReverseMap();

            CreateMap<ProductRequest, Product>()
                .ReverseMap()
                .ForMember(dest => dest.category, opt => opt.MapFrom(src => new Response.Category
                {
                    id = src.CategoryObject.CategoryId,
                    name = src.CategoryObject.Name
                }));
            CreateMap<ProductResponse, Product>()
                .ReverseMap()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dest => dest.category, opt => opt.MapFrom(src => new Response.Category
                {
                    id = src.CategoryObject.CategoryId,
                    name = src.CategoryObject.Name
                }));
            CreateMap<Product, ProductGetResponse>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dest => dest.categoryName, opt => opt.MapFrom(src => src.CategoryObject != null ? src.CategoryObject.Name : null));
            CreateMap<Product, SaleProduct>()
                .ForMember(dest => dest.Product, opt => opt.MapFrom(src => src.ProductId))
                .ForMember(dest => dest.Price, opt => opt.MapFrom(src => src.Price))
                .ForMember(dest => dest.Discount, opt => opt.MapFrom(src => src.Discount));


            CreateMap<Sale, SaleResponse>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.SaleId));

            CreateMap<SaleProduct, SaleProductResponse>()
                .ForMember(dest => dest.id, opt => opt.MapFrom(src => src.ShoppingCartId))
                .ForMember(dest => dest.productId, opt => opt.MapFrom(src => src.Product));
        }
    }
}
