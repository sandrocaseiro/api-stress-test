using System.Data;
using System.Data.Common;

namespace PerfTest.Data
{
    public class OracleConnectionFactory
    {
        private readonly string connectionString;

        public OracleConnectionFactory(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public IDbConnection CreateConnection()
        {
            var factory = new Oracle.ManagedDataAccess.Client.OracleClientFactory();
            var dbConnection = factory.CreateConnection();
            dbConnection.ConnectionString = connectionString;

            return dbConnection;
        }
    }
}
