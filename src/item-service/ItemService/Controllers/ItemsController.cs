using ItemService.Infrastructure;
using ItemService.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ItemService.Controllers
{
    [Route("api/[controller]")]
    [Produces("application/json")]
    [ApiController]
    public class ItemsController : ControllerBase
    {
        private readonly IItemRepository _repository;

        public ItemsController(IItemRepository repository)
        {
            _repository = repository;
        }

        /// <summary>
        /// 商品を取得します
        /// </summary>
        /// <returns></returns>
        [HttpGet]
        [ProducesResponseType(typeof(IList<Item>), 200)]
        [ProducesResponseType(404)]
        public async Task<IActionResult> Get()
        {
            var result = await _repository.GetAsync();
            if (result == null || result.Count == 0)
            {
                return NotFound();
            }
            return Ok(result);
        }
    }
}
