using ItemService.Models;
using Newtonsoft.Json;
using System.Text;

namespace ItemService.Infrastructure
{
    public class ItemRepository : IItemRepository
    {
        public async Task<IList<Item>> GetAsync()
        {
            await Task.Delay(100);
            var json = File.ReadAllText("Models/MOCK_DATA.json", Encoding.UTF8);
            var result = JsonConvert.DeserializeObject<List<Item>>(json);
            return result;
        }
    }
}
