using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PosService.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class PaymentsController : ControllerBase
    {
        /// <summary>
        /// カートに支払を追加します
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Add()
        {
            await Task.Delay(100);
            return Ok();
        }
    }
}
