using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SteCvp.Infrastructure.Database
{
    public class DbConnectionFactory
    {
        private readonly string _connectionString =
            "Data Source=5CD52360WK\\SQLEXPRESS;Initial Catalog=PokemonDb;Integrated Security=True;Encrypt=True;TrustServerCertificate=True;";

        public IDbConnection CreateConnection()
        {
            return new SqlConnection(_connectionString);
        }
    }
}
