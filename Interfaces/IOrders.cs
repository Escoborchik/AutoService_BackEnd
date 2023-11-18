using Autoservice_Back.Models;

namespace Autoservice_Back.Interfaces
{
    public interface IOrders
    {
        IEnumerable<Order> GetAllOrders(int id);
        void AddOrder(Order order);
        
    }
}
