using Autoservice_Back.Models;

namespace Autoservice_Back.Interfaces
{
    public interface IOrders
    {
        IEnumerable<Order> GetAllOrders(int id);
        void AddOrder(Order order);

        void EditOrder(string result, int id, int id_order);
        Order GetOrder(int id, int id_Client);

        IEnumerable<Order> GetActiveOrders(int id);

        IEnumerable<Order> GetHistoryOrders(int id);


    }
}
