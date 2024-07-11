namespace Arquitectura.Monolitica
{
    public class OrderController
    {
        private readonly OrderService _service;

        public OrderController()
        {
            _service = new OrderService();
        }

        public Order GetById(string id)
        {
            return _service.GetById(id);
        }

        public IEnumerable<Order> GetAll()
        {
            return _service.GetAll();
        }

        public void Save(Order order)
        {
            _service.Save(order);
        }

        public void Delete(string id)
        {
            _service.Delete(id);
        }
    }
}
