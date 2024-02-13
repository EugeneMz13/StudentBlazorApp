using Microsoft.Data.SqlClient;
using System.Data;

namespace StudentAppMint.Data
{
    public class DataBaseConnect
    {
        private readonly IConfiguration _configuration;

        public DataBaseConnect(IConfiguration configuration)
        {
            _configuration = configuration;
        }

        public IDbConnection CreateConnection()
             => new SqlConnection(_configuration.GetConnectionString("RemoteConnection"));
    }
}
