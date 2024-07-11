namespace Arquitectura.Monolitica
{
    public class OrderService
    {
        private readonly OrderRepository _repository;

        public OrderService()
        {
            _repository = new OrderRepository();
        }

        public Order GetById(string id)
        {
            return _repository.GetById(id);
        }

        public IEnumerable<Order> GetAll()
        {
            return _repository.GetAll();
        }

        public void Save(Order order)
        {
            _repository.Save(order);
        }

        public void Delete(string id)
        {
            _repository.Delete(id);
        }
    }
}
