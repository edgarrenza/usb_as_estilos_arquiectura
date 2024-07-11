namespace Arquitectura.Componentes
{
    public class ProductService : IService<Product>
    {
        private readonly IRepository<Product> _repository;

        public ProductService(IRepository<Product> repository)
        {
            _repository = repository;
        }

        public Product GetById(string id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _repository.GetAll();
        }

        public void Save(Product product)
        {
            _repository.Save(product);
        }

        public void Delete(string id)
        {
            _repository.Delete(id);
        }
    }
}
