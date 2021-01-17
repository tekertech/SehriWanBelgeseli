using System.Collections.Generic;

namespace SehriWanBelgeseli.Api.Domain.Responses
{
    public class ProductListResponse:BaseResponse {
        public IEnumerable<Product> Products { get; set; }
        private ProductListResponse(string message, bool isSuccess, IEnumerable<Product> products):base(message,isSuccess) {
            this.Products = products;
        }
        /// <summary>
        /// Operation successful
        /// </summary>
        /// <param name="products"></param>
        public ProductListResponse(IEnumerable<Product> products):this(string.Empty,true,products) { }
        /// <summary>
        /// Operation failed
        /// </summary>
        /// <param name="message"></param>
        public ProductListResponse(string message):this(message,false,null) { }

    }
}
