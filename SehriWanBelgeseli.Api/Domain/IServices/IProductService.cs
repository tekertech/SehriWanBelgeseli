using SehriWanBelgeseli.Api.Domain.Responses;
using System.Threading.Tasks;

namespace SehriWanBelgeseli.Api.Domain.IServices
{
    public interface IProductService
    {
        Task<ProductListResponse> ListAsync();
        Task<ProductResponse> AddProductAsync(Product product);
        Task<ProductResponse> RemoveProductAsync(int productId);
        Task<ProductResponse> UpdateProduct(Product product,int productId);
        Task<ProductResponse> FindByIdAsync(int productId);
    }
}
