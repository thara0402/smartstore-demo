using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace StockService.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class StockController : ControllerBase
    {
        /// <summary>
        /// 在庫を引き当てます
        /// </summary>
        /// <returns></returns>
        [HttpPost]
        public async Task<IActionResult> Create()
        {
            await Task.Delay(100);
            return Created("", "");
        }

        /// <summary>
        /// 在庫を取得します
        /// </summary>
        /// <param name="itemCode">商品コード</param>
        /// <returns></returns>
        [HttpGet]
        public async Task<IActionResult> Get(string itemCode)
        {
            await Task.Delay(100);
            return Ok();
        }
    }
}
