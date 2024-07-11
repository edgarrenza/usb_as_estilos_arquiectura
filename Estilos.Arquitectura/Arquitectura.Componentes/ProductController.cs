namespace Arquitectura.Componentes
{
    public class ProductController : IController<Product>
    {
        private readonly IService<Product> _service;

        public ProductController(IService<Product> service)
        {
            _service = service;
        }

        public Product GetById(string id)
        {
            return _service.GetById(id);
        }

        public IEnumerable<Product> GetAll()
        {
            return _service.GetAll();
        }

        public void Save(Product product)
        {
            _service.Save(product);
        }

        public void Delete(string id)
        {
            _service.Delete(id);
        }
    }
}
