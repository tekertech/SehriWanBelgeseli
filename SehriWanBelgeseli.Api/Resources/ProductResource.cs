using System.ComponentModel.DataAnnotations;

namespace SehriWanBelgeseli.Api.Resources
{
    public class ProductResource
    {
        public int CategoryId { get; set; }
        [Required]
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal UnitPrice { get; set; }
        public int UnitInStock { get; set; }
    }
}
