using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace PosService.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class CartController : ControllerBase
    {
        /// <summary>
        /// カートを取得します
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get()
        {
            await Task.Delay(100);
            return Ok();
        }

        /// <summary>
        /// カートに商品を追加します
        /// </summary>
        /// <returns></returns>
        [HttpPost("Item")]
        public async Task<IActionResult> AddItem()
        {
            await Task.Delay(100);
            return Created("", "");
        }

        /// <summary>
        /// カートから商品を削除します
        /// </summary>
        /// <returns></returns>
        [HttpDelete("Item")]
        public async Task<IActionResult> DeleteItem()
        {
            await Task.Delay(100);
            return NoContent();
        }
    }
}
