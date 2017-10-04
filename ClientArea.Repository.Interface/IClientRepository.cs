using ClientsArea.Entities;
using System.Collections.Generic;

namespace ClientsArea.Repository.Interfaces
{
    public interface IClientRepository
    {
        bool AddClient(Client client);
        bool UpdateClient(Client client);
        bool DeleteClient(int clientId);
        IList<Client> GetAllClients();
        Client GetClientById(int clientID);
    }
}
