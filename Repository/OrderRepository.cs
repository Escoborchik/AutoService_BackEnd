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
    }
}
