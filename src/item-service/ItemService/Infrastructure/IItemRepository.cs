using ItemService.Models;

namespace ItemService.Infrastructure
{
    public interface IItemRepository
    {
        Task<IList<Item>> GetAsync();
    }
}
