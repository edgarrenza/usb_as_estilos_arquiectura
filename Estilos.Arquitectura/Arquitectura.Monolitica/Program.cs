namespace Arquitectura.Monolitica
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var orderController = new OrderController();

            var newOrder = new Order("1", "Laptop", 2, 1500.00m);
            orderController.Save(newOrder);

            var retrievedOrder = orderController.GetById("1");
            Console.WriteLine($"Retrieved Order: {retrievedOrder.ProductName}, {retrievedOrder.Quantity}, {retrievedOrder.Price:C}");

            var allOrders = orderController.GetAll();
            Console.WriteLine("All Orders:");
            foreach (var order in allOrders)
            {
                Console.WriteLine($"- {order.ProductName}, {order.Quantity}, {order.Price:C}");
            }

            orderController.Delete("1");
            Console.WriteLine("Order deleted.");

            var deletedOrder = orderController.GetById("1");
            Console.WriteLine(deletedOrder == null ? "Order not found." : "Order still exists.");
        }
    }
}
