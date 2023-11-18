using Autoservice_Back.Interfaces;
using Autoservice_Back.Models;

namespace Autoservice_Back.Repository
{
    public class OrderWithoutRegRepository : IOrdersWithoutReg
    {
        private readonly AppDBContext _dbContext;

        public OrderWithoutRegRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }
        
        public void AddOrderWithoutReg(OrderWithoutReg orderWithoutReg)
        {                        
            _dbContext.OrdersWithoutReg.Add(orderWithoutReg);
            _dbContext.SaveChanges();
        }
    }
}
