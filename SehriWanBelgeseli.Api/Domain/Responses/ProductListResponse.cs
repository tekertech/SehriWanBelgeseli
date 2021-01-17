using System.Collections.Generic;

namespace SehriWanBelgeseli.Api.Domain.Responses
{
    public class ProductListResponse:BaseResponse {
        public IEnumerable<Product> Products { get; set; }
        public ProductListResponse(string message, bool isSuccess, IEnumerable<Product> products):base(message,isSuccess) {
            this.Products = products;
        }
        public ProductListResponse(IEnumerable<Product> products):this(string.Empty,true,products) { }
        public ProductListResponse(string message):this(message,false,null) { }

    }
}
