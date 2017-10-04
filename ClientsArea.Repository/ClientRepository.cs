using ClientsArea.Repository.Interfaces;
using System;
using System.Collections.Generic;
using ClientsArea.Entities;
using Dapper;
using System.Data;
using System.Linq;
using Microsoft.Extensions.Configuration;

namespace ClientsArea.Repository
{
    public class ClientRepository : BaseRepository, IClientRepository
    {
        public ClientRepository(IConfiguration configuration) : base(configuration)
        {
        }

        public bool AddClient(Client client)
        {
            try
            {
                using (IDbConnection dbConnection = con)
                {
                    dbConnection.Open();
                    dbConnection.Execute("INSERT INTO client (name, address, email, phone, latitude, longitude) VALUES(@name, @address, @email, @phone, @latitude, @longitude)", client);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        public bool DeleteClient(int clientId)
        {
            try
            {
                using (IDbConnection dbConnection = con)
                {
                    dbConnection.Open();
                    dbConnection.Execute("DELETE FROM client WHERE clientId = @clientId", new { clientId = clientId });
                }
                return true;
            }
            catch (Exception)
            {
                throw;
            }
        }

        public IList<Client> GetAllClients()
        {
            try
            {
                using (IDbConnection dbConnection = con)
                {
                    dbConnection.Open();
                    return dbConnection.Query<Client>("SELECT * FROM client").ToList();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public Client GetClientById(int clientId)
        {
            try
            {
                using (IDbConnection dbConnection = con)
                {
                    dbConnection.Open();
                    return dbConnection.Query<Client>("SELECT * FROM client WHERE clientId = @clientId", new { clientId = clientId }).FirstOrDefault();
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        public bool UpdateClient(Client client)
        {
            try
            {
                using (IDbConnection dbConnection = con)
                {
                    dbConnection.Open();
                    dbConnection.Query("UPDATE client SET name = @name, address = @address, email = @email, phone = @phone, latitude = @latitude, longitude = @longitude WHERE clientId = @clientId", client);
                }
                return true;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
