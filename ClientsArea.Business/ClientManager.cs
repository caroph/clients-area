using ClientsArea.Business.Interfaces;
using System.Collections.Generic;
using ClientsArea.Entities;
using ClientsArea.Repository.Interfaces;

namespace ClientsArea.Business
{
    public class ClientManager : IClientManager
    {
        IClientRepository _clientRepository;

        public ClientManager(IClientRepository clientRepository)
        {
            _clientRepository = clientRepository;
        }

        public bool AddClient(Client client)
        {
            return _clientRepository.AddClient(client);
        }

        public bool DeleteClient(int clientId)
        {
            return _clientRepository.DeleteClient(clientId);
        }

        public IList<Client> GetAllClient()
        {
            return _clientRepository.GetAllClients();
        }

        public Client GetClientById(int clientId)
        {
            return _clientRepository.GetClientById(clientId);
        }

        public bool UpdateClient(Client client)
        {
            return _clientRepository.UpdateClient(client);
        }
    }
}
