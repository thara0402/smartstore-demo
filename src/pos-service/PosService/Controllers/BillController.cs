using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PosService.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class BillController : ControllerBase
    {
        /// <summary>
        /// カートの取引を確定します
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create()
        {
            await Task.Delay(100);
            return Created("", "");
        }

        /// <summary>
        /// カートの取引を中止します
        /// </summary>
        /// <returns></returns>
        [HttpDelete]
        public async Task<IActionResult> Delete()
        {
            await Task.Delay(100);
            return NoContent();
        }
    }
}
