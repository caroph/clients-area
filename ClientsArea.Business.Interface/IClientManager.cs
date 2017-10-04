using ClientsArea.Entities;
using System.Collections.Generic;

namespace ClientsArea.Business.Interfaces
{
    public interface IClientManager
    {
        bool AddClient(Client client);
        bool UpdateClient(Client client);
        bool DeleteClient(int clientId);
        IList<Client> GetAllClient();
        Client GetClientById(int clientId);
    }
}
