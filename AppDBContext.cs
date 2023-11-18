using Autoservice_Back.Models;
 
using Microsoft.EntityFrameworkCore;

namespace Autoservice_Back
{
    public class AppDBContext : DbContext
    {
        public AppDBContext(DbContextOptions<AppDBContext> options) : base(options)
        {
            
        }

        public DbSet<Client> Clients { get; set; }
        public DbSet<Car> Cars { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderWithoutReg> OrdersWithoutReg { get; set; }

    }
}
