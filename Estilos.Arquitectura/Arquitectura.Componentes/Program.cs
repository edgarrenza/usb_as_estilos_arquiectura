namespace Arquitectura.Componentes
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var productRepository = new ProductRepository();
            var productService = new ProductService(productRepository);
            var productController = new ProductController(productService);

            var newProduct = new Product("1", "Laptop", 999.99m);
            productController.Save(newProduct);

            var retrievedProduct = productController.GetById("1");
            Console.WriteLine($"Retrieved Product: {retrievedProduct.Name}, {retrievedProduct.Price:C}");

            var allProducts = productController.GetAll();
            Console.WriteLine("All Products:");
            foreach (var product in allProducts)
            {
                Console.WriteLine($"- {product.Name}, {product.Price:C}");
            }

            productController.Delete("1");
            Console.WriteLine("Product deleted.");

            var deletedProduct = productController.GetById("1");
            Console.WriteLine(deletedProduct == null ? "Product not found." : "Product still exists.");
        }
    }
}
