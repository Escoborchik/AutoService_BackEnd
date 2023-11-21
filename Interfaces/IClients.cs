using Autoservice_Back.Models;

namespace Autoservice_Back.Interfaces
{
    public interface IClients
    {
        void AddClient(Client client);
        Client GetClient(int id);

        IEnumerable<Client> GetClients();
    }
}
