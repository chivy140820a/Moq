using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebApplication2.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class ProductController : ControllerBase
  {
    private readonly IProductService _productService;
    public ProductController(IProductService productService)
    {
      _productService = productService;
    }

    [HttpGet]
    public IActionResult GetAll()
    {
      var content = _productService.GetAll();
      return Ok(content);
    }
  }
}
