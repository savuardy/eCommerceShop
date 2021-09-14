using eCommerce_shop.Errors;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce_shop.Controllers
{
    [Route(("errors/{code}"))]
    [ApiExplorerSettings(IgnoreApi = true)]
    public class ErrorController : BaseApiController
    {
        public IActionResult Error(int code)
        {
            return new ObjectResult(new ApiResponse(code));
        }
    }
}