using Microsoft.EntityFrameworkCore;
using PerfTest.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PerfTest.Data.Repositories
{
    public class MockDataRepository
    {
        private readonly MockDbContext _dbContext;

        public MockDataRepository(MockDbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public Task<List<MockData>> FindAllByIdSearchAsync(int idSearch)
        {
            return _dbContext.MockDatas.Where(m => m.IdSearch == idSearch).ToListAsync();
        }
    }
}
