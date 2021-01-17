using AutoMapper;
using SehriWanBelgeseli.Api.Domain;
using SehriWanBelgeseli.Api.Resources;

namespace SehriWanBelgeseli.Api.Mapping
{
    public class ProductMapping:Profile
    {
        public ProductMapping()
        {
            CreateMap<ProductResource, Product>();
            CreateMap<Product, ProductResource>();
        }
    }
}
