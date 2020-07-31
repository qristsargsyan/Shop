using Microsoft.AspNetCore.Mvc;
using Shop.BLL.Products;
using System.Threading.Tasks;

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        readonly IProductManager _productManager;
        public ProductsController(IProductManager productManager)
        {
            _productManager = productManager;
        }

        [HttpPost]
        public async Task<ActionResult> AddProduct()
        {
            await _productManager.Add();
            return Ok();
        }
    }
}
