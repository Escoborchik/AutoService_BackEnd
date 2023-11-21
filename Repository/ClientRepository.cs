
using Autoservice_Back.Interfaces;
using Autoservice_Back.Models;
using Autoservice_Back ;
using Microsoft.EntityFrameworkCore;

namespace Autoservice_Back.Repository
{
    public class ClientRepository : IClients
    {
        private readonly AppDBContext _dbContext;

        public ClientRepository(AppDBContext dbContext)
        {
            _dbContext = dbContext;
        }

        public void AddClient(Client client)
        {
            _dbContext.Clients.Add(client);
            _dbContext.SaveChanges();
        }

        public  Client GetClient(int id)
        {
            return _dbContext.Clients.Where(x => x.Id == id).FirstOrDefault();
        }

        public IEnumerable<Client> GetClients()
        {
            return _dbContext.Clients;
        }
    }
}
