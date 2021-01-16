using Microsoft.EntityFrameworkCore;
using SehriWanBelgeseli.Api.Domain.IRepositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace SehriWanBelgeseli.Api.Domain.Repositories
{
    public class ProductRepository : BaseRepository, IProductRepository
    {
        public ProductRepository(SehriWanBelgeselDBContext dbContext):base(dbContext) {}

        public async Task AddProductAsync(Product product) {
           await  dbContext.Products.AddAsync(product);
        }
        public async Task<Product> FindByIdAsync(int productId) {
            return await dbContext.Products.FindAsync(productId);
        }
        public async Task<IEnumerable<Product>> ListAsync() {
            return await dbContext.Products.ToListAsync();
        }
        public async Task RemoveProductAsync(int productId) {
            Product product = await FindByIdAsync(productId);
            dbContext.Products.Remove(product);
        }
        public void UpdateProduct(Product product) {
            dbContext.Products.Update(product);
        }
    }
}
