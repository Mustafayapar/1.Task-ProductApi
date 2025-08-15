namespace _1.Task_ProductApi.EntityLayer.Concrete
{
    public class Product
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public decimal Price { get; set; }
        public int Stock { get; set; } // Stok adedi
        public DateTime CreatedAtUtc { get; set; } = DateTime.UtcNow;
    }
}
