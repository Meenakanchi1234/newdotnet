using AspnetRun.Application.Models;
using AspnetRun.Core.Entities;
using AutoMapper;

namespace AspnetRun.Application.Mapper
{
    // The best implementation of AutoMapper for class libraries - https://stackoverflow.com/questions/26458731/how-to-configure-auto-mapper-in-class-library-project
    public class ObjectMapper
    {
        public static IMapper Mapper
        {
            get
            {
                return AutoMapper.Mapper.Instance;
            }
        }
        static ObjectMapper()
        {
            CreateMap();
        }

        private static void CreateMap()
        {
            AutoMapper.Mapper.Initialize(cfg =>
            {
                cfg.CreateMap<Product, ProductModel>()
                    .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name)).ReverseMap();
                cfg.CreateMap<Category, CategoryModel>().ReverseMap();
                cfg.CreateMap<Wishlist, WishlistModel>().ReverseMap();
                cfg.CreateMap<Compare, CompareModel>().ReverseMap();
                cfg.CreateMap<Order, OrderModel>().ReverseMap();
            });
        }
    }
}
