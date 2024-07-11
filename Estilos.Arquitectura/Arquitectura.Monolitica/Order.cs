namespace Arquitectura.Monolitica
{
    public class Order
    {
        public string Id { get; set; }
        public string ProductName { get; set; }
        public int Quantity { get; set; }
        public decimal Price { get; set; }

        public Order(string id, string productName, int quantity, decimal price)
        {
            Id = id;
            ProductName = productName;
            Quantity = quantity;
            Price = price;
        }
    }
}
