using System;
using System.Collections.Generic;

#nullable disable

namespace SehriWanBelgeseli.Api.Domain
{
    public partial class Product
    {
        public int Id { get; set; }
        public int? CategoryId { get; set; }
        public string ProductName { get; set; }
        public string QuantityPerUnit { get; set; }
        public decimal? UnitPrice { get; set; }
        public int? UnitsInStock { get; set; }
    }
}
