using Microsoft.AspNetCore.Mvc;

namespace eCommerce_shop.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsContoller : ControllerBase
    {
        [HttpGet]
        public string GetProducts()
        {
            return "this will be a list of products";
        }

        [HttpGet("{id}")]
        public string GetProducts(int id)
        {
            return "single product";
        }
    }
}