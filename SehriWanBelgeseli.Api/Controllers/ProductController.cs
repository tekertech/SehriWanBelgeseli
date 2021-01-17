using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SehriWanBelgeseli.Api.Domain.IServices;
using SehriWanBelgeseli.Api.Domain.Responses;
using SehriWanBelgeseli.Api.Resources;
using SehriWanBelgeseli.Api.Extensions;
using System.Collections;
using System.Threading.Tasks;
using SehriWanBelgeseli.Api.Domain;

namespace SehriWanBelgeseli.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductController : ControllerBase
    {
        private readonly IProductService productService;
        private readonly IMapper mapper;
        public ProductController(IProductService productService, IMapper mapper)
        {
            this.productService = productService;
            this.mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> GetList() 
        {
            ProductListResponse productListResponse = await productService.ListAsync();
            if (productListResponse.IsSuccess) {
                return Ok(productListResponse.Products);
            } else {
                return BadRequest(productListResponse.Message);
            }
        }

        [HttpGet("{productId:int}")]
        public async Task<IActionResult> GetFindById(int productId)
        {
            ProductResponse productResponse = await productService.FindByIdAsync(productId);
            if (productResponse.IsSuccess) {
                return Ok(productResponse.Product);
            }else {
                return BadRequest(productResponse.Message.ToString());
            }
        }

        [HttpPost]
        public async Task<IActionResult> AddProduct(ProductResource productResource) 
        {
           if (!ModelState.IsValid) {
                    return BadRequest($"{ModelState.GetErrorMessage()}");
            } else {
                Product product = mapper.Map<ProductResource, Product>(productResource);
                ProductResponse productResponse = await productService.AddProductAsync(product);
                if (productResponse.IsSuccess) {
                    return Ok(productResponse.Product);
                }
                else {
                    return BadRequest(productResponse.Message.ToString());
                }
            }
        }

        [HttpPut]
        public async Task<IActionResult> UpdateProduct(ProductResource productResource,int productId) 
        {
            if (!ModelState.IsValid) {
                return BadRequest($"{ModelState.GetErrorMessage()}");
            } else {
                    Product product = mapper.Map<ProductResource, Product>(productResource);
                    ProductResponse productResponse =  await productService.UpdateProduct(product, productId);
                if (productResponse.IsSuccess) {
                    return Ok(productResponse.Product);
                } else {
                    return BadRequest($"{productId} Id li ürün güncellneirken hata alındı.");
                }
            } 
        }

        [HttpDelete]
        public async Task<IActionResult> RemoveProduct(int productId)
        {
            ProductResponse productResponse = await productService.RemoveProductAsync(productId);
            if (productResponse.IsSuccess) {
                return Ok($"Ürün Başarı ile silindi");
            } else {
                return BadRequest($"{productResponse.Message.ToString()}");
            }
        }


    }
}
