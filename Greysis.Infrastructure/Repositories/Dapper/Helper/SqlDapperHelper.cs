using Greysis.Core.Repositories.Dapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.Common;

namespace Greysis.Infrastructure.Repositories.Dapper.Helper
{
    public class SqlDapperHelper : DapperHelper
    {
        protected override IDbConnection CreateConnection()
        {
            string connectionString = "server=localhost;database=Repository;user ID=sa;password=0";
            var factory = DbProviderFactories.GetFactory("System.Data.SqlClient");
            var connection = factory.CreateConnection();
            connection.ConnectionString = connectionString;
            return connection;
        }
    }
}
