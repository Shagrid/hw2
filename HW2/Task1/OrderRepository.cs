using Task1.Interfaces;

namespace Task1
{
    public sealed class OrderRepository
    {
        public Order Load(IGetOrder connect, int orderId)
        {
            return connect.GetOrder(orderId);
        }

        public void Save(IAddOrder connect, Order order)
        {
            connect.Add(order);
        }
        public void Update(IUpdateOrder connect, Order order) { 
            connect.Update(order);
        }
        public void Delete(IDeleteOrder conncet, Order order)
        { 
            conncet.Delete(order);
        }
    }
}