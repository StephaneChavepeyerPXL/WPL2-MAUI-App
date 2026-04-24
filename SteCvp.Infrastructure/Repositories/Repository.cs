using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;

namespace SteCvp.Infrastructure.Repositories
{
    public class Repository

    {

        private readonly string _connectionString =

            "Data Source=5CD52360WK\\SQLEXPRESS;Integrated Security=True;Persist Security Info=False" +
            ";Pooling=False;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=True;" +
            "Application Name=\"SQL Server Management Studio\";Command Timeout=2147483647";

        public Repository() { }

        protected IDbConnection CreateConnection()

        {
            return new SqlConnection(_connectionString);
        }

    }
}
