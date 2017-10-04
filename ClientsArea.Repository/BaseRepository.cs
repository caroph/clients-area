using System;
using System.Data;
using Npgsql;
using Microsoft.Extensions.Configuration;

namespace ClientsArea.Repository
{
    public class BaseRepository : IDisposable
    {
        private string connectionString;
        protected IDbConnection con;
        public BaseRepository(IConfiguration configuration)
        {
            connectionString = configuration.GetConnectionString("PostgreSQL");
            con = new NpgsqlConnection(connectionString);
        }

        public void Dispose()
        {
            //throw new NotImplementedException();
        }
    }
}
