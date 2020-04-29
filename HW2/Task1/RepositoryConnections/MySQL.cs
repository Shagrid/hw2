using Task1.Interfaces;

namespace Task1.RepositoryConnections
{
    public sealed class MySQL : IAddOrder, IDeleteOrder, IGetOrder, IUpdateOrder
    {
        public void Add(Order order)
        {
            throw new System.NotImplementedException();
        }

        public void Delete(Order order)
        {
            throw new System.NotImplementedException();
        }

        public Order GetOrder(int id)
        {
            throw new System.NotImplementedException();
        }

        public void Update(Order order)
        {
            throw new System.NotImplementedException();
        }
    }
   
}