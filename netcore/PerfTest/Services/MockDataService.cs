using PerfTest.Data.Repositories;
using PerfTest.Domain;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace PerfTest.Services
{
    public class MockDataService
    {
        private readonly MockDataRepository _mockDataRepository;
        private readonly MockDataRepositoryDapper _mockDataRepositoryDapper;

        public MockDataService(MockDataRepository mockDataRepository, MockDataRepositoryDapper mockDataRepositoryDapper)
        {
            _mockDataRepository = mockDataRepository;
            _mockDataRepositoryDapper = mockDataRepositoryDapper;
        }

        public Task<List<MockData>> FindAllByIdSearchAsync(int idSearch)
        {
            return _mockDataRepository.FindAllByIdSearchAsync(idSearch);
        }

        public Task<IEnumerable<MockData>> FindAllByIdSearchAsyncDapper(int idSearch)
        {
            return _mockDataRepositoryDapper.FindAllByIdSearchAsync(idSearch);
        }
    }
}
