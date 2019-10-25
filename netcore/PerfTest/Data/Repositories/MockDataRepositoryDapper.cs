using Dapper;
using PerfTest.Domain;
using System.Collections.Generic;
using System.Data;
using System.Threading.Tasks;

namespace PerfTest.Data.Repositories
{
    public class MockDataRepositoryDapper
    {
        private readonly IDbConnection _dbConnection;

        //public MockDataRepositoryDapper(OracleConnectionFactory dbFactory)
        //{
        //    _dbConnection = dbFactory.CreateConnection();
        //}

        public Task<IEnumerable<MockData>> FindAllByIdSearchAsync(int idSearch)
        {
            return _dbConnection.QueryAsync<MockData>("select * from MOCKDATA where ID_SEARCH = :idSearch", new { idSearch });
        }
    }
}
