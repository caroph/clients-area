using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using ClientsArea.Business.Interfaces;
using ClientsArea.Entities;

namespace ClientsArea.Api.Controllers
{
    [Route("api/[controller]")]
    public class ClientsController : Controller
    {
        IClientManager _clientManager;
        public ClientsController(IClientManager clientManager)
        {
            _clientManager = clientManager;
        }

        // GET api/clients
        [HttpGet]
        public IEnumerable<Client> Get()
        {
            var clients = _clientManager.GetAllClient();
            return clients;
        }

        // GET api/clients/5
        [HttpGet("{id}")]
        public Client Get(int id)
        {
            var client = _clientManager.GetClientById(id);
            return client;
        }

        // POST api/clients
        [HttpPost]
        public void Post([FromBody] Client client)
        {
            if (client != null)
                _clientManager.AddClient(client);
        }

        [HttpPut("{id}")]
        public void Put(int id, [FromBody] Client client)
        {
            if (client != null)
                _clientManager.UpdateClient(client);
        }

        [HttpDelete("{id}")]
        public void Delete(int id)
        {
            _clientManager.DeleteClient(id);
        }
    }
}
