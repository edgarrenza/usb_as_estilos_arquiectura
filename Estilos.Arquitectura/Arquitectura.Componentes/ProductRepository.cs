namespace Arquitectura.Componentes
{
    public class ProductRepository : IRepository<Product>
    {
        private readonly Dictionary<string, Product> _productDatabase = new();

        public Product GetById(string id)
        {
            _productDatabase.TryGetValue(id, out var product);
            return product;
        }

        public IEnumerable<Product> GetAll()
        {
            return _productDatabase.Values;
        }

        public void Save(Product product)
        {
            _productDatabase[product.Id] = product;
        }

        public void Delete(string id)
        {
            _productDatabase.Remove(id);
        }
    }
}
