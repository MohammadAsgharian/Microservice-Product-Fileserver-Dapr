using Microservice.Product.Contracts.Products;
using Microsoft.AspNetCore.Mvc;

namespace Microservice.Product.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ProductController : ControllerBase
    {
     
        public ProductController()
        {
        }

        [HttpPost(Name = "PostProduct")]
        public IActionResult Post([FromForm]AddProductRequest addProductRequest)
        {
            return Ok();
        }
    }
}