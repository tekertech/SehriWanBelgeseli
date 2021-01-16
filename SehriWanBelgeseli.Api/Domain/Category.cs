using System;
using System.Collections.Generic;

#nullable disable

namespace SehriWanBelgeseli.Api.Domain
{
    public partial class Category
    {
        public int Id { get; set; }
        public string CategoryName { get; set; }
        public string SeoUrl { get; set; }
    }
}
