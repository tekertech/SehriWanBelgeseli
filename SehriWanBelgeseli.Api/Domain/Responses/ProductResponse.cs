namespace SehriWanBelgeseli.Api.Domain.Responses
{
    public class ProductResponse:BaseResponse
    {
        public Product Product { get; set; }
        private ProductResponse(string message, bool isSuccess, Product product):base(message,isSuccess) {
            this.Product = product;
        }

        public ProductResponse(Product product):this(string.Empty,true,product) {}

        public ProductResponse(string message):this(message,false,null) { }
    }
}
