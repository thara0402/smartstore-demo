namespace ItemService.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string ItemCode { get; set; }
        public string ItemName { get; set; }
        public decimal UnitPrice { get; set; }
    }
}
