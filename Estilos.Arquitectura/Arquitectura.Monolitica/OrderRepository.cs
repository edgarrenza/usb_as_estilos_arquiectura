namespace Arquitectura.Monolitica
{
    public class OrderRepository
    {
        private readonly Dictionary<string, Order> _orderDatabase = new();

        public Order GetById(string id)
        {
            _orderDatabase.TryGetValue(id, out var order);
            return order;
        }

        public IEnumerable<Order> GetAll()
        {
            return _orderDatabase.Values;
        }

        public void Save(Order order)
        {
            _orderDatabase[order.Id] = order;
        }

        public void Delete(string id)
        {
            _orderDatabase.Remove(id);
        }
    }
}
