using Microsoft.Extensions.Configuration;
using Npgsql;
using System.Data;

namespace NetBoiler.Infrastructure.Persistence
{
    public class DapperDbContext
    {
        private readonly IConfiguration _config;

        public DapperDbContext(IConfiguration config)
        {
            _config = config;
        }

        public IDbConnection CreateConnection()
        => new NpgsqlConnection(_config.GetConnectionString("Default"));
    }
}