using Autoservice_Back;
using Autoservice_Back.Interfaces;
using Autoservice_Back.Models;
using Microsoft.EntityFrameworkCore;

namespace Autoservice_Back.Repository
{
    public class OrderRepository : IOrders
    {
        private readonly AppDBContext _dbContext;

        public OrderRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddOrder(Order order)
        {
            _dbContext.Orders.Add(order);
            _dbContext.SaveChanges();
        }

        public  IEnumerable<Order>  GetAllOrders(int id)
        {
            return  _dbContext.Orders.Where(order => order.ClientId == id).Include(order => order.Car);
        }

        public  Order GetOrder(int id, int id_order)
        {
            return _dbContext.Orders.Where(order => order.ClientId == id && order.Id == id_order).Include(order => order.Car).First();
        }
        public IEnumerable<Order> GetActiveOrders(int id)
        {
            return GetAllOrders(id).Where(order => order.IsActive);
        }

        public IEnumerable<Order> GetHistoryOrders(int id)
        {
            return GetAllOrders(id).Where(order => !order.IsActive);
        }

        public void EditOrder(string result, int id, int id_order)
        {
            var order = GetOrder(id, id_order);
            order.IsActive = false;
            order.Result = result;
            _dbContext.SaveChanges();
        }
    }
}
