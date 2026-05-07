using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.Data.SqlClient;
using SteCvp.Infrastructure.Database;

namespace SteCvp.Infrastructure.Repositories
{
    public class Repository
    {
        protected readonly DbConnectionFactory _connectionFactory;

        public Repository(DbConnectionFactory connectionFactory)
        {
            _connectionFactory = connectionFactory;
        }
    }
}
