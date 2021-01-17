using SehriWanBelgeseli.Api.Domain;
using SehriWanBelgeseli.Api.Domain.IRepositories;
using SehriWanBelgeseli.Api.Domain.IServices;
using SehriWanBelgeseli.Api.Domain.Responses;
using SehriWanBelgeseli.Api.Domain.UnitOfWork;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SehriWanBelgeseli.Api.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository productRepository;
        private readonly IUnitOfWork unitOfWork; 
        public ProductService(IProductRepository productRepository, IUnitOfWork unitOfWork)
        {
            this.productRepository = productRepository;
            this.unitOfWork = unitOfWork;
        }

        public async Task<ProductResponse> AddProductAsync(Product product)
        {
            try {
                await productRepository.AddProductAsync(product);
                await unitOfWork.CompleteAsync();
                return new ProductResponse(product);
            }
            catch (System.Exception ex) {
                return new ProductResponse($"Ürün Eklerken Alınan Hata : {ex.Message.ToString()}");
            }
        }

        public async Task<ProductResponse> FindByIdAsync(int productId)
        {
            try
            {
                Product product = await productRepository.FindByIdAsync(productId);
                if(product == null) {
                    return new ProductResponse($" {productId} : Id li ürün bulunamadı.");
                } else {
                    return new ProductResponse(product);
                }
            }
            catch (System.Exception ex)
            {
                return new ProductResponse($"Ürün bulunurken hata alındı : {ex.Message.ToString()}");
            }
        }

        public async Task<ProductListResponse> ListAsync() {
            try {
                IEnumerable<Product> products = await productRepository.ListAsync();
              return new ProductListResponse(products);
            }
            catch (System.Exception ex) {
                return new ProductListResponse($"Ürün Listelerken Hata Alındı : {ex.Message.ToString()}");
            }
        }

        public async Task<ProductResponse> RemoveProductAsync(int productId)
        {
            try
            {
                ProductResponse productResponse = await FindByIdAsync(productId);
                if(productResponse.Product == null) {
                    return new ProductResponse($"Silinecek {productId} Id li ürün bulunamadı.");
                }
                else {
                    await productRepository.RemoveProductAsync(productId);
                    await unitOfWork.CompleteAsync();
                    return new ProductResponse("Ürün başarılı bir şekilde silinmiştir.");
                }
            }
            catch (System.Exception ex)
            {
                return new ProductResponse($"Ürün silme işlemi başarısız. Hata : {ex.Message.ToString()}");
            }
        }

        public async Task<ProductResponse> UpdateProduct(Product product, int productId)
        {
            try
            {
                Product oldProduct = await productRepository.FindByIdAsync(productId);
                if(oldProduct == null) {
                    return new ProductResponse($"Güncellenecek ürün bulunamadı");
                }
                else {
                    oldProduct.CategoryId = product.CategoryId;
                    oldProduct.ProductName = product.ProductName;
                    oldProduct.QuantityPerUnit = product.QuantityPerUnit;
                    oldProduct.UnitPrice = product.UnitPrice;
                    oldProduct.UnitsInStock = product.UnitsInStock;
                }
                productRepository.UpdateProduct(oldProduct);
                await unitOfWork.CompleteAsync();
                return new ProductResponse(oldProduct);
            }
            catch (System.Exception ex) {
                return new ProductResponse($"Ürün güncellerken hata alındı : Hata Detayı : {ex.Message.ToString()}");
            }
        }
    }
}
